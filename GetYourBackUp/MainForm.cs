using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;

using System.Windows.Forms;
using System.Reflection;
using System.Diagnostics;

using Microsoft.Win32.TaskScheduler;

using System.Xml;


namespace GotYourBackUp
{
    public partial class MainForm : Form
    {
        #region declarations
        private bool programAbort = false;                          //close wtihout saving if abnomal program termination
        private string gybuDirectory = @"c:\GotYourBackUp\";
        private string xmlFileName = "GotYourBackUp.xml";                       //xml file that holds the Backup class details

        private string logFileDirectory = "GotYourBackUp_Logs";           //log file directory under root... this cannot be changed
        private string logFileName = "";                                                   //TODO      //log file path and name for current session

        private Backup myBackup = new Backup();                 //backup class contains all settings and tasks
        private BackupTask theBackupTask = new BackupTask();    //currently active task profile

        private int activeTaskIndex = 0;                        //index of currently selected task

        private SourceItem selectedSource;
        private SourceItem backupFolder;

        private Logger logger = new Logger();

        string defaultBackupMode = "Suffix";

        private FileInfo file;              //info for single source file to backup
        private DirectoryInfo folder;       //info for single folder to backup

        private bool formIsReady = false;   //to bypass event actions while form is loading
        private bool populatingFreqCombo;   //to bypass FreqCombo change events when populating at start
        private bool populatingTaskCombo;   //to bypass TaskCombo change trigger when populating
        private bool taskIsLoading;         //to bypass source item size computations 

        private string backupDir;           //backup directory
        private string backupPath;          //full path to backup directory and (source) filename
        private bool okToRun = false;       //if valid backup from and to paths have been set
        private long totalBackupSize;       //total size of backup itesm in task
        private long selectedBackupSize;       // size of selectedbackup itesm in task

        string prevFrequency = "";          //schedule settings prior to schedule turned off
        string prevDayDate = "";
        DateTime prevSchedTime = DateTime.MinValue;
        DateTime prevExpiry = DateTime.MinValue;

         //clunky solution to add/renaname task actions -- TODO improve
        private string renameMode = "";
        private string renameAction = "";    
        private string newTaskName = "";

        //location of executable on local machine for scheduler
        private string exeLocation = System.Reflection.Assembly.GetExecutingAssembly().Location.ToString();

        private List<string> frequencyList = new List<string> { "Once", "Daily", "Weekly", "Monthly"};
        private List<string> daysList = new List<string> { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
        private List<string> fullDaysList = new List<string> { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
        private List<int> dateList = new List<int> {1 ,2 ,3, 4, 5, 6, 7, 8, 9, 10,11 ,12 ,13, 14, 15, 16, 17, 18, 19,20, 21 ,22 ,23, 24, 25, 26, 27, 28, 29, 30, 31};

        private string backupFolderInstruction = "You must set a valid backup location before you can make a backup copy";

        private string backupDirName = "";  //name of dir holding backup
        private string descriptionInfoText = "Comments for this backup (optional)";
        private string backupDescription = "";

        //private BindingSource backupList = new BindingSource();  // not used yet... for future data grid approach

        #endregion declarations

        //constructor
        #region constructor and setup

        public MainForm()
        {
            InitializeComponent();

            MakeReady();
        }

        // initial setup
        private void MakeReady()
        {
            GetBackupInfo();
            LoadGeneralFormFields();
            MakeLogFile();
            FillTaskComboBox();

            TaskComboBox.SelectedIndex = activeTaskIndex;       // ... on change he active task profile will be loaded into form fieldspopulatingTaskCombo = true;

            LoadActiveBackupProfile();

            TestIfReady();

            formIsReady = true;
        }

        private void GetBackupInfo()
        {
            //check for directory and settings file
            try
            {
                if (!Directory.Exists(gybuDirectory))
                    Directory.CreateDirectory(gybuDirectory);                
            }
            catch (Exception ex)
            {
                MessageBox.Show("The GotYourBackUp directory cannot be created.\nError details for developer follow:\n\n" + ex.ToString(),
                                "Got Your Back Up?", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                programAbort = true;
                CloseProgram();
            }

            string latestXmlFile =  Path.Combine(gybuDirectory, xmlFileName);
            myBackup.XmlFile = Path.Combine(gybuDirectory, xmlFileName);
            //myBackup.XmlFile = xmlFileName;

            if (!File.Exists(myBackup.XmlFile))             //no file... so create it 
            {
                FileStream fileStream = new FileStream(myBackup.XmlFile, FileMode.CreateNew);
                fileStream.Close();

                myBackup.AddNewTask("");                    //add dummy task
                myBackup.SaveInfo();                        //save the new Pack with dummy task in file
            }
            else
            {
                myBackup = myBackup.GetInfo();              // read existing file to get previous task pack with tasks
            }

            if (myBackup.XmlFile != latestXmlFile)         // read existing file to get previous task pack with tasks
                myBackup.XmlFile = latestXmlFile;

            //get active task index
            int indx = 0;
            foreach( BackupTask task in myBackup.TaskList)
            {
                if (task.IsActive)
                {
                    activeTaskIndex = indx;
                    break;
                }
            }
        }

        private void LoadGeneralFormFields()
        {
            this.Text = "Got Your Back Up?  " + GetVersion();           // form title and version
            PromptCheckBox.Checked = !myBackup.IdiotPrompt;

            RenameTaskPanel.Location = new Point(332, 244);
            RenameTaskPanel.Visible = false;

            //------ Scheduler settings
            populatingFreqCombo = true;
            FrequencyComboBox.DataSource = frequencyList;
            FrequencyComboBox.SelectedIndex = -1;
            populatingFreqCombo = false;

            ScheduleCheckBox.Checked = myBackup.ScheduleIsSet;
            RunOnStartupCheckBox.Checked = myBackup.RunOnStartup;
            CloseAfterBackupCheckBox.Checked = myBackup.CloseAfterBackup;

            if (myBackup.ScheduleIsSet)
                SetScheduleOn();
            else
                SetScheduleOff();

            tabControl1.TabPages.Remove(SettingsTabPage);
            toolStripStatusLabel_backupPath.Text = "";

        }

        private void MakeLogFile()
        {
            if (myBackup.LogFileDirectory == "")                //no log file directory saved... set as default
                logFileDirectory = Path.Combine(gybuDirectory, logFileDirectory);
            else if (myBackup.LogFileDirectory != "")
                logFileDirectory = myBackup.LogFileDirectory;

            LogFolderPathLinkLabel.Text = logFileDirectory;

            logger.LogFileDirectory = logFileDirectory;
            logger.MakeLogFile();


            if (logger.LoggingIsActive)
            {
                myBackup.LogFileDirectory = logFileDirectory;
                AddLog("Got Your Back Up? program started from machine " + System.Environment.MachineName, 2);
            }
        }

        private void FillTaskComboBox()
        {
            populatingTaskCombo = true;  //suppress TaskCombo change trigger

            BindingSource bs = new BindingSource();
            bs.DataSource = myBackup.TaskList;
            TaskComboBox.DataSource = bs;
            TaskComboBox.DisplayMember = "Name";

            if (myBackup.TaskList.Count < 2)
                DeleteTaskButton.Enabled = false;
            else
                DeleteTaskButton.Enabled = true;

            NumTaskslabel.Text = "# of tasks: " + myBackup.TaskList.Count.ToString();

            int indx = 0;
            foreach (BackupTask task in myBackup.TaskList)
            {
                if (task.IsActive)
                {
                    activeTaskIndex = indx;
                    break;
                }
                indx++;
            }

            populatingTaskCombo = false;  //reactivate TaskCombo change trigger
        }

        private void ShowSettingsSummary()
        {
            if (SettingsAreDefault())
                ResetSettingsButton.Enabled = false;
            else
                ResetSettingsButton.Enabled = true;
            
            GetScheduleSettings();

            if (myBackup.ScheduleIsSet)
            {
                ScheduleLabel.Text = myBackup.Frequency;
                ScheduleLabel.ForeColor = Color.Green; 

                using (TaskService ts = new TaskService())
                {
                    TaskFolder tf = ts.RootFolder;
                    Microsoft.Win32.TaskScheduler.Task runningTask = tf.Tasks["Got Your Back Up"];
                    NextRunLlabel.Text = runningTask.NextRunTime.ToShortDateString() + " at " + runningTask.NextRunTime.ToShortTimeString();
                    NextRunLlabel.ForeColor = Color.Green;
                }
            }
            else
            {
                ScheduleLabel.Text = "OFF";
                ScheduleLabel.ForeColor = Color.Red;
                NextRunLlabel.Text = "N/A";
                NextRunLlabel.ForeColor = Color.Red;
            }

            if (myBackup.RunOnStartup)
            {
                AutorunLabel.Text = "YES";
                AutorunLabel.ForeColor = Color.Green; ;
            }
            else
            {
                AutorunLabel.Text = "NO";
                AutorunLabel.ForeColor = Color.Red; ;
            }

            if (myBackup.CloseAfterBackup)
            {
                AutoCloseLabel.Text = "YES";
                AutoCloseLabel.ForeColor = Color.Green; ;
            }
            else
            {
                AutoCloseLabel.Text = "NO";
                AutoCloseLabel.ForeColor = Color.Red; ;
            }

            if (theBackupTask.CopyMode == "Suffix")
                BackupModeLabel.Text = "New folder with date-time suffix";
            else if (theBackupTask.CopyMode == "Prompt")
                BackupModeLabel.Text = "Overwrite with prompt";

        }

        private bool SettingsAreDefault()
        {
            bool settingsAreDefault = false;

            //if (theBackupTask.CopyMode == defaultBackupMode && !myBackup.RunOnStartup && !myBackup.CloseAfterBackup && !myBackup.ScheduleIsSet)
                //&& myBackup.BackupLocation == "" && myBackup.SourceItems.Count == 0)
            {
                settingsAreDefault = true;
            }

            return settingsAreDefault;
        }

        private bool TestForScheduleSettings()
        {
            bool ok = true;

            if (FrequencyComboBox.SelectedIndex == -1) ok = false;
            if ((FrequencyComboBox.Text != "Once" || FrequencyComboBox.Text != "Daily" ) && DayComboBox.SelectedIndex == -1) ok = false;
            if (TimePicker.Value == DateTime.MinValue) ok = false;
            if (ExpiryDateTimePicker.Value == DateTime.MinValue) ok = false;

            return ok;
        }

        private void ClearScheduleValues()
        {
            myBackup.ScheduleIsSet = false;
            myBackup.Frequency = "";
            myBackup.DayDate = "";
            myBackup.SchedTime = DateTime.MinValue;
            myBackup.Expiry = DateTime.MinValue;
       }


        #region setup utilities

        private void FormatGridViewCells()
        {
            //SetCellButtonSize();
            //SetCellToolTip();
   
            // size cell format
            //Font font = new F
            //DataGridViewCellStyle style = new DataGridViewCellStyle();

            dataGridView1.Columns[2].Resizable = DataGridViewTriState.False;

            dataGridView1.Columns[3].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[3].DefaultCellStyle.Font = new Font("Verdana", 8, FontStyle.Regular);
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            //http://tech.chitgoks.com/2008/11/17/c-add-select-all-deselect-all-checkbox-in-column-header-in-datagridview-control/
            // add checkbox header
            Rectangle rect = dataGridView1.GetCellDisplayRectangle(0, -1, true);
            // set checkbox header to center of header cell. +1 pixel to position correctly.
            //rect.X = rect.Location.X + (rect.Width / 4);
            rect.X = rect.Location.X + 4;
            rect.Y = rect.Location.Y + 2;

            CheckBox checkboxHeader = new CheckBox();
            checkboxHeader.Name = "checkboxHeader";
            checkboxHeader.Size = new Size(18, 18);
            checkboxHeader.Location = rect.Location;
            checkboxHeader.CheckedChanged += new EventHandler(checkboxHeader_CheckedChanged);

            dataGridView1.Controls.Add(checkboxHeader);
        }

        private void checkboxHeader_CheckedChanged(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                dataGridView1[0, i].Value = ((CheckBox)dataGridView1.Controls.Find("checkboxHeader", true)[0]).Checked;
            }
            dataGridView1.EndEdit();
        }

        private void SetCellButtonSize()
        {
            //this.dataGridView1.RowTemplate.DefaultCellStyle.Padding = new Padding(0, 1, 0, 30);
            Rectangle rect = dataGridView1.GetCellDisplayRectangle(openColumn.Index, 0, true);
            Padding p = openColumn.DefaultCellStyle.Padding;
            p.Left = rect.X + 5;  //my column width is 100 adjusting x to 75 so that button goes to corner of the cell
            p.Right = rect.Y+ 5;
            p.Top = rect.Y + 5;
            p.Bottom = rect.X + 5;
            openColumn.DefaultCellStyle.Padding = p;
        }

        private void SetCellToolTip()
        {
            string ttText = "";
            foreach (DataGridViewRow row in  dataGridView1.Rows)
            {
                if (row.Cells[1].Value == Properties.Resources.folder)
                    ttText = "Open this folder";
                else if (row.Cells[1].Value == Properties.Resources.file)
                    ttText = "Open this file";

                row.Cells[4].ToolTipText = ttText;
            }
     
        }

        private void MakeDataTable()        // not being used for the moment
        {
            DataTable dt= new DataTable();

            dt.Columns.Add("IsSelected");
            dt.Columns.Add("Type");
            dt.Columns.Add("Path");

            dt.Columns[0].DataType = System.Type.GetType("System.Boolean");
            dt.Columns[1].DataType = System.Type.GetType("System.String");
            dt.Columns[2].DataType = System.Type.GetType("System.String");


            DataRow row;

            foreach (SourceItem item in theBackupTask.SourceItems)
            {
                row = dt.NewRow();

                row[0] = item.IsSelected;

                if (item.IsFolder)
                    row[1] = Properties.Resources.folder;
                else
                    row[1] = Properties.Resources.file;

                row[2] = item.Path;
                dt.Rows.Add(row);
            }

            BackupListDataGridView.DataSource = dt;
             

        }
        
        #endregion setup utilities

        #endregion constructor


        #region display utilities
 
        private void SetScheduleOn()
        {
            SchedulePanel.Enabled = true;

            //myBackup.ScheduleIsSet = true;  // only when confirmed
            if (myBackup.Frequency =="")
            {

            }
                myBackup.Frequency = (prevFrequency == "" ? "Weekly" : prevFrequency);

            // if 'once', and scheduled time not passed, display current schedule, else turn off
            if (myBackup.Frequency == "Once" && DateTime.Now > myBackup.SchedTime)
            {
                ScheduleCheckBox.Checked = false;
                return;
            }
            else
            {

            }


            if (myBackup.Frequency == "Monthly")
                myBackup.DayDate = (prevDayDate == "" ? "1" : prevDayDate);                 //default monthly backup on 1st of month
            else if (myBackup.Frequency == "Weekly")
                myBackup.DayDate = (prevDayDate == "" ? "Fri" : prevDayDate);               //default Weekly backup on Friday

            myBackup.SchedTime = (prevSchedTime == DateTime.MinValue ? DateTime.Today + TimeSpan.FromHours(9) : prevSchedTime);     //default time 9 amprev
            myBackup.Expiry = (prevExpiry == DateTime.MinValue ? DateTime.Now.AddYears(1) : prevExpiry);                            //default expiry 1 year


            FrequencyComboBox.SelectedIndex = FrequencyComboBox.FindString(myBackup.Frequency);
            DayComboBox.SelectedIndex = DayComboBox.FindString(myBackup.DayDate);

            if (myBackup.SchedTime == DateTime.MinValue)
            {
                TimePicker.CustomFormat = " ";
            }
            else
            {
                TimePicker.Format = DateTimePickerFormat.Custom;
                TimePicker.CustomFormat = "HH:mm ";
                TimePicker.Value = DateTime.Today.AddHours(myBackup.SchedTime.Hour).AddMinutes(myBackup.SchedTime.Minute);
            }

            if (myBackup.Expiry == DateTime.MinValue)
            {
                ExpiryDateTimePicker.CustomFormat = " ";
            }
            else
            {
                ExpiryDateTimePicker.Format = DateTimePickerFormat.Custom;
                ExpiryDateTimePicker.CustomFormat = "dd MMM yyyy";
                ExpiryDateTimePicker.Value = myBackup.Expiry;
            }

            if (TestForScheduleSettings())
                SetScheduleButton.Enabled = true;

            ResetSettingsButton.Enabled = true;

        }      //**

        private void SetScheduleOff()
        {
            //temp hold of last settings
            prevFrequency = myBackup.Frequency;
            prevDayDate = myBackup.DayDate;
            prevSchedTime = myBackup.SchedTime;
            prevExpiry = myBackup.Expiry;

            ClearScheduleValues();

            FrequencyComboBox.SelectedIndex = -1;
            FrequencyComboBox.Text = "";

            DayComboBox.SelectedIndex = -1;
            DayComboBox.Text = "";

            TimePicker.Format = DateTimePickerFormat.Custom;
            TimePicker.CustomFormat = " ";

            ExpiryDateTimePicker.Format = DateTimePickerFormat.Custom;
            ExpiryDateTimePicker.CustomFormat = " ";

            SchedulePanel.Enabled = false;
            SetScheduleButton.Enabled = false;
            ResetSettingsButton.Enabled = false;
        }      //**

        private void TestBackupFolder()
        {
            theBackupTask.BackupLocation = BackupFolderTextBox.Text;
             
            if (BackupFolderTextBox.Text.Trim() == "")
            {
                ShowFolderNotSetInstruction();
                return;
            }

            //arrives here if non blank
            if (!Directory.Exists(BackupFolderTextBox.Text)) 
            {
                BackupFolderTextBox.ForeColor = Color.Red;
                DialogResult dialogResult = MessageBox.Show("Backup location folder does not exist.\n\nDo you want to create it?", "Got your back up?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        Directory.CreateDirectory(BackupFolderTextBox.Text);
                        DirectoryInfo di = new DirectoryInfo(BackupFolderTextBox.Text);

                        BackupFolderTextBox.Text = di.FullName;
                        theBackupTask.BackupLocation = di.FullName;
                        BackupFolderTextBox.ForeColor = Color.Black;
                    }
                    catch
                    {
                        MessageBox.Show("Cannot create backup folder.", "Got your back up?",
                            MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        BackupFolderTextBox.Text = "";
                        theBackupTask.BackupLocation = "";
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    BackupFolderTextBox.Text = "";
                    theBackupTask.BackupLocation = "";
                }
            }
            //else
            //{
            //    MessageBox.Show("Not valid path name", "Got your back up?",
            //                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            //    theBackupTask.BackupLocation = "";
            //}

            SaveActiveTask();
            TestIfReady();
        }      //**

       private void ShowFolderNotSetInstruction()      //**
        {
            if (myBackup.IdiotPrompt)
            {
                BackupFolderTextBox.Text = backupFolderInstruction;
                BackupFolderTextBox.ForeColor = Color.Red;
            }
        }   

        private void LoadActiveBackupProfile()
        {
            activeTaskIndex = TaskComboBox.SelectedIndex;

            //get the settings for the selected task from the MyBackup.TaskList
            int indx = 0;
            foreach (BackupTask task in myBackup.TaskList)
            {
                if (indx == activeTaskIndex)
                    myBackup.TaskList[indx].IsActive = true;
                else
                    myBackup.TaskList[indx].IsActive = false;

                indx++;
            }

            theBackupTask = myBackup.TaskList[activeTaskIndex];

            ActiveTaskNameLabel.Text = theBackupTask.Name;

            //------ source list in grid view
            //MakeDataTable();                              //for future use
            dataGridView1.Rows.Clear();
            FormatGridViewCells();                          //format Source grid view cells

            totalBackupSize = 0;
            selectedBackupSize = 0;

            foreach (SourceItem item in theBackupTask.SourceItems)
            {
                AddNewRow(item);
            }

            //------ display backup path
            //theBackupTask = myBackup.TaskList[activeTaskIndex];  //
            BackupFolderTextBox.Text = theBackupTask.BackupLocation;

            if (theBackupTask.BackupLocation.Trim() == "")
                ShowFolderNotSetInstruction();

            if (dataGridView1.Rows.Count > 0)
                dataGridView1.Rows[0].Selected = false;



            //------ final form settings
            //ShowSettingsSummary();

            if (theBackupTask.SourceItems.Count > 0 && (theBackupTask.BackupLocation != "" || theBackupTask.BackupLocation != null))
                okToRun = true;


            //------ backup mode options
            if (theBackupTask.CopyMode == "Suffix")
                NewFolderRadioButton.Checked = true;
            else if (theBackupTask.CopyMode == "Prompt")
                PromptToOverwriteRadioButton.Checked = true;
            else if (theBackupTask.CopyMode == "Overwrite")
                OverwriteRadioButton.Checked = true;

            //TestIfReady();
            SaveActiveTask();

        }    

        private void TestIfReady()
        {
            BackupButton.Enabled = false;
            toolStripStatusLabel1.ForeColor = Color.Black;
            
            ShowIdiotPromts();

            if (dataGridView1.Rows.Count == 0)
            {
                if (myBackup.IdiotPrompt)  
                    SourceInstructionLabel.Visible = true;
                else
                    SourceInstructionLabel.Visible = false;

                ClearListButton.Enabled = false;
            }
            else
            {
                SourceInstructionLabel.Visible = false;
                ClearListButton.Enabled = true;                
            }

            if (theBackupTask.SourceItems.Count == 0 && theBackupTask.BackupLocation == "")
            {
                toolStripStatusLabel1.Text = "Select folders/files to back up and the directory where backup will be made";
            }
            else if (theBackupTask.SourceItems.Count == 0 && theBackupTask.BackupLocation != "")
            {
                toolStripStatusLabel1.Text = "Select folders/files to back up";
            }
            else if (theBackupTask.SourceItems.Count > 0 && theBackupTask.BackupLocation == "")
            {
                toolStripStatusLabel1.Text = "Set location to the directory where the backup copy will be made";
            }
            else
            {
                BackupButton.Enabled = true;
                toolStripStatusLabel1.Text = "Click 'Backup now' to copy selected items to backup location.";
            }

            bool backupButtonState = BackupButton.Enabled;
            string toolStripText = toolStripStatusLabel1.Text;

            //if nothing selected ... disable
            bool somethingSelected = false;
            foreach (SourceItem item in theBackupTask.SourceItems)
            {
                if (item.IsSelected)
                {
                    somethingSelected = true;
                    break;
                }
            }

            if (!somethingSelected && theBackupTask.SourceItems.Count > 0)
            {
                BackupButton.Enabled = false;
                toolStripStatusLabel1.Text = "All items in the backup list are deselected.";
                toolStripStatusLabel1.ForeColor = Color.Red;
            }
            else
            {
                BackupButton.Enabled = backupButtonState;
                toolStripStatusLabel1.Text = toolStripText;
            }

            OpenBackupFolderButton.Enabled = true;
            if (theBackupTask.BackupLocation == "")
            {
                OpenBackupFolderButton.Enabled = false;

                if (myBackup.IdiotPrompt)
                    ShowFolderNotSetInstruction();
                else
                    BackupFolderTextBox.Text = "";
            }

        }
        
        private void ShowIdiotPromts()
        {
            if (myBackup.IdiotPrompt)
            {
                TaskSelectorInfoLabel.Visible = true;
                TaskManagerInfoLabel.Visible = true;
                ActiveTaskInfoLabel.Visible = true;                
            }
            else
            {
                TaskSelectorInfoLabel.Visible = false;
                TaskManagerInfoLabel.Visible = false;
                ActiveTaskInfoLabel.Visible = false;                  
            }            
        }

        #endregion display utilities


        // starting ...
        private void MainForm_Shown(object sender, EventArgs e)
        {
            if (!programAbort && okToRun && myBackup.RunOnStartup)
                DoBackup();
        }       

        //user (button) commands
        private void ButtonClickHub(object sender, EventArgs e)
        {
            Control theControl = (Control)sender;
            switch (theControl.Name)
            {
                //Scheduler
                case "SetScheduleButton": SetSchedule(); break;
                case "ResetSettingsButton": DoResetSetttings(); break;

                //Task manager
                case "AddTaskButton": GetNewTaskName("add");  break;
                case "RenameTaskButton": GetNewTaskName("rename"); break;
                case "SaveTaskButton": SaveActiveTask(); break;
                case "DeleteTaskButton": DeleteActiveTask(true); break;

                case "ConfirmNameChangeButton":DoTaskNameChange("confirm"); break;
                case "CancelNameChangeButton": DoTaskNameChange("cancel"); break;

                //backup source list
                case "AddFolderButton": AddNewItem("folder"); break;
                case "AddFileButton": AddNewItem("file"); break;
                case "ClearListButton": ClearBackupList();   break;               

                //backup 
                case "BackupFolderButton": SetBackupFolder(); break;
                case "OpenBackupFolderButton": OpenBackupFolder();   break;               

                case "BackupButton": DoBackup(); break;

                // log tab
                case "DeleteLogsButton": DeleteLogs();break; 

                //settings tab
                case "SelectLogFolderButton":SetLogRootFolder();break;
                 

            }
        }

        #region user commands

        //Scheduler
        private void SetSchedule()
        {
            Cursor.Current = Cursors.WaitCursor;

            //Process.Start(exeLocation);   //test exe location
            //http://taskscheduler.codeplex.com/wikipage?title=Examples
            //http://taskscheduler.codeplex.com/wikipage?title=Examples&referringTitle=Documentation

            DateTime startBounday = DateTime.Today + TimeSpan.FromHours(TimePicker.Value.Hour) + TimeSpan.FromMinutes(TimePicker.Value.Minute);


            // Get the service on the local machine
            using (TaskService taskService = new TaskService())
            {
                try
                {
                    taskService.RootFolder.DeleteTask("Got Your Back Up");
                }
                catch
                {

                }

                DailyTrigger dt = new DailyTrigger();
                WeeklyTrigger wt = new WeeklyTrigger();
                MonthlyTrigger mt = new MonthlyTrigger();

                Trigger myTrigger = null;

                // Create a new task definition and assign properties
                TaskDefinition taskDefinition = taskService.NewTask();
                taskDefinition.RegistrationInfo.Description = "Got Your Back Up?";

                // Create a trigger that will fire the task at the set frequency
                switch (myBackup.Frequency)
                {
                    case "Monthly":
                        mt.DaysOfMonth[0] = int.Parse(DayComboBox.Text);
                        mt.StartBoundary = startBounday;
                        mt.Enabled = true;
                        myTrigger = mt;
                        break;
                    case "Weekly":
                        switch (DayComboBox.Text)
                        {
                            case "Sun": wt.DaysOfWeek = DaysOfTheWeek.Sunday; break;
                            case "Mon": wt.DaysOfWeek = DaysOfTheWeek.Monday; break;
                            case "Tue": wt.DaysOfWeek = DaysOfTheWeek.Tuesday; break;
                            case "Wed": wt.DaysOfWeek = DaysOfTheWeek.Wednesday; break;
                            case "Thu": wt.DaysOfWeek = DaysOfTheWeek.Thursday; break;
                            case "Fri": wt.DaysOfWeek = DaysOfTheWeek.Friday; break;
                            case "Sat": wt.DaysOfWeek = DaysOfTheWeek.Saturday; break;
                        }
                        wt.StartBoundary = startBounday;
                        wt.Enabled = true;
                        myTrigger = wt;
                        break;

                    case "Daily":
                        dt.StartBoundary = startBounday;
                        dt.Enabled = true;
                        myTrigger = dt;
                        break;

                    case "Once":
                        //string x = ""; //test
                        dt.StartBoundary = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour + 1, 0, 0);
                        dt.StartBoundary = ExpiryDateTimePicker.Value.Date + TimePicker.Value.TimeOfDay;
                        dt.Enabled = true;
                        myTrigger = dt;
                        break;

                }

                if (myBackup.Frequency == "Once")
                    myTrigger.EndBoundary = myTrigger.StartBoundary + TimeSpan.FromHours(23);
                else
                    myTrigger.EndBoundary = myBackup.Expiry;


                if (TestScheduleCheckBox.Checked)
                {
                    ////DailyTrigger dt = new DailyTrigger();
                    //dt.StartBoundary = DateTime.Now + TimeSpan.FromMinutes(2);
                    //dt.Repetition.Interval = TimeSpan.FromMinutes(1);
                    //dt.Enabled = true;
                    //myTrigger = dt;
                }

                Microsoft.Win32.TaskScheduler.Action myAction;
                myAction = new ExecAction(exeLocation);
                taskDefinition.Actions.Add(myAction);

                Microsoft.Win32.TaskScheduler.Task task = taskService.AddTask("Got Your Back Up", myTrigger,
                           new ExecAction(exeLocation, null, null));


                // Register the task in the root folder
                taskService.RootFolder.RegisterTaskDefinition(@"GotYourBackUp", taskDefinition);

                //// Remove the task we just created
                //taskService.RootFolder.DeleteTask("Got Your Back Up");

                myBackup.ScheduleIsSet = true;
                myBackup.SchedTime = (myBackup.Frequency == "Once" ? myTrigger.StartBoundary : DateTime.Today + TimeSpan.FromHours(9));
                myBackup.Expiry = myTrigger.EndBoundary;


                Cursor.Current = Cursors.Default;


                DisplayTaskDetails();

                if (myBackup.ScheduleIsSet)
                {
                    ScheduleLabel.Text = myBackup.Frequency;
                    ScheduleLabel.ForeColor = Color.Green;

                    using (TaskService ts = new TaskService())
                    {
                        TaskFolder tf = ts.RootFolder;
                        Microsoft.Win32.TaskScheduler.Task runningTask = tf.Tasks["Got Your Back Up"];
                        NextRunLlabel.Text = runningTask.NextRunTime.ToShortDateString() + " at " + runningTask.NextRunTime.ToShortTimeString();
                        NextRunLlabel.ForeColor = Color.Green;
                    }
                }
                else
                {
                    ScheduleLabel.Text = "OFF";
                    ScheduleLabel.ForeColor = Color.Red;
                    NextRunLlabel.Text = "N/A";
                    NextRunLlabel.ForeColor = Color.Red;
                }
                //ShowSettingsSummary();

                DoSaveSetttings();
                AddLog("Schedule set -- " + myBackup.Frequency + " -- Next run at: " + NextRunLlabel.Text, 2);
            }
        }
        
        private void DoResetSetttings()
        {
            theBackupTask.CopyMode = defaultBackupMode;
            myBackup.RunOnStartup =false;
            myBackup.CloseAfterBackup = false;
            myBackup.ScheduleIsSet = false;

            if (RunOnStartupCheckBox.Checked)
                RunOnStartupCheckBox.Checked = false;

            if (!NewFolderRadioButton.Checked)
                NewFolderRadioButton.Checked = true;

            if (ScheduleCheckBox.Checked)
                ScheduleCheckBox.Checked = false;

            if (myBackup.ScheduleIsSet)
            {
                ScheduleLabel.Text = myBackup.Frequency;
                ScheduleLabel.ForeColor = Color.Green;

                using (TaskService ts = new TaskService())
                {
                    TaskFolder tf = ts.RootFolder;
                    Microsoft.Win32.TaskScheduler.Task runningTask = tf.Tasks["Got Your Back Up"];
                    NextRunLlabel.Text = runningTask.NextRunTime.ToShortDateString() + " at " + runningTask.NextRunTime.ToShortTimeString();
                    NextRunLlabel.ForeColor = Color.Green;
                }
            }
            else
            {
                ScheduleLabel.Text = "OFF";
                ScheduleLabel.ForeColor = Color.Red;
                NextRunLlabel.Text = "N/A";
                NextRunLlabel.ForeColor = Color.Red;
            }

        }

        //Task manager        
        private void GetNewTaskName(string mode)
        {
            renameMode = mode;

            if (mode == "add")
            {
                RenameTaskLabel.Text = "Add a new backup task";
                NewTaskNameLabel.Text = "Task name: ";
            }
            else if (mode == "rename")
            {
                RenameTaskLabel.Text = "Rename Active Backup Task";
                NewTaskNameLabel.Text = "New name: ";
            }

            RenameActiveTaskTextBox.Visible = true;
            RenameActiveTaskTextBox.Text = "";
            RenameActiveTaskTextBox.Focus();
            RenameTaskPanel.Visible = true;

            //disable other controls... why isn't this happening when containers are disabled?
            SchedulerGroupBox.Enabled = false;
            TaskSelectorGroupBox.Enabled = false;
            ActiveTaskManagerGroupBox.Enabled = false;
            AddFolderButton.Enabled = false;
            AddFileButton.Enabled = false;
            ClearListButton.Enabled = false;

            BackupFolderTextBox.Enabled = false;
            BackupFolderButton.Enabled = false;
            OpenBackupFolderButton.Enabled = false;
            BackupModeGroupBox.Enabled = false;
            BackupButton.Enabled = false;
        }

        private void AddNewTask(string taskName)
        {
            myBackup.AddNewTask(taskName);                  //add  task
            myBackup.SaveInfo();                            //save the new xml 

            FillTaskComboBox();

            NumTaskslabel.Text = "# of tasks: " + myBackup.TaskList.Count.ToString();

            TaskComboBox.SelectedIndex = myBackup.TaskList.Count - 1;

            DeleteTaskButton.Enabled = true;

            ShowListSize("Reset", 0, false);
            //selectedBackupSize = 0;
            //totalBackupSize = 0;

            //SelectedSizeLabel.Text = ItemSize(selectedBackupSize);
            //TotalSizeLabel.Text = ItemSize(totalBackupSize); 

            AddLog("New task added -- task name: "+ theBackupTask.Name, 2);
        }

        private void SaveActiveTask()
        {
            SetTaskPropertiesFromFormFields();
            myBackup.SaveInfo();

            AddLog("Task saved -- " + theBackupTask.Name, 2);

            //ShowListSize("Reset", 0, false);
            //selectedBackupSize = 0;
            //totalBackupSize = 0;

            //SelectedSizeLabel.Text = ItemSize(selectedBackupSize);                    
            //TotalSizeLabel.Text = ItemSize(totalBackupSize);                    

            //foreach (SourceItem item in theBackupTask.SourceItems)
            //{
            //    totalBackupSize =  totalBackupSize + item.ByteSize();
            //    if (item.IsSelected)
            //    {
            //        selectedBackupSize = selectedBackupSize + item.ByteSize();
            //    }
            //}
            //SelectedSizeLabel.Text = ItemSize(selectedBackupSize);                    
            //TotalSizeLabel.Text = ItemSize(totalBackupSize);                    


        }

        private void DeleteActiveTask(bool withPrompt)
        {
            if (withPrompt)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete task\n'" + theBackupTask.Name + "'", 
                                                            "Got Your Back up?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (dialogResult == DialogResult.No)
                {
                    return;
                }                
            }

            int myIndex = TaskComboBox.SelectedIndex;
            string myName = myBackup.TaskList[myIndex].Name;

            //var onlyMatch = myBuPack.TaskList.Single(s => s.Name == myName);
            //myBuPack.TaskList.Remove(onlyMatch);

            myBackup.TaskList.RemoveAll(s => s.Name == myName); // remove by condition

            AddLog("Task deleted -- " + theBackupTask.Name, 2);

            myBackup.SaveInfo();
            FillTaskComboBox();
            LoadActiveBackupProfile();
            TestIfReady();

        }

        private void HideRenamePanel()
        {
            RenameTaskPanel.Visible = false;

            SchedulerGroupBox.Enabled = true;
            TaskSelectorGroupBox.Enabled = true;
            ActiveTaskManagerGroupBox.Enabled = true;
            AddFolderButton.Enabled = true;
            AddFileButton.Enabled = true;
            ClearListButton.Enabled = true;

            BackupFolderTextBox.Enabled = true;
            BackupFolderButton.Enabled = true;
            OpenBackupFolderButton.Enabled = true;
            BackupModeGroupBox.Enabled = true;

            BackupButton.Enabled = true;
        }

        private void DoTaskNameChange(string action)
        {
            HideRenamePanel();

            if (action == "cancel")
                return;

            newTaskName = RenameActiveTaskTextBox.Text;

            if (renameMode == "add")
            {
                AddNewTask(newTaskName);
            }
            else
            {
                RenameActiveTask (newTaskName);
            }
        }

        private void RenameActiveTask(string newTaskName)
        {
            AddLog("Task name change from '" + theBackupTask.Name + " to '" + RenameActiveTaskTextBox.Text + "'", 2);

            theBackupTask.Name = RenameActiveTaskTextBox.Text;
            ActiveTaskNameLabel.Text = theBackupTask.Name;

            myBackup.TaskList[activeTaskIndex].Name = theBackupTask.Name;
            myBackup.SaveInfo();
            FillTaskComboBox();
            TaskComboBox.SelectedIndex = activeTaskIndex;
        }

        //backup source list
        private void AddNewItem(string type)
        {
            selectedSource = new SourceItem();
            selectedSource.IsFolder = (type == "folder");
            selectedSource.GetPath();
            selectedSource.IsSelected = true;

            if (selectedSource.Path == "" || selectedSource.Path == null)
                return;

            if (SourceAlreadySelected()) //test for already selected
            {
                MessageBox.Show("Path already in backup list", "Get your back up", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (selectedSource.Path == theBackupTask.BackupLocation)
            {
                MessageBox.Show("Path to backup is same as backup location!", "Get your back up", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            theBackupTask.SourceItems.Add(selectedSource);

            AddNewRow(selectedSource);

            SaveActiveTask(); //*****
            TestIfReady();
        }

        private void ClearBackupList()
        {
            for (int i = dataGridView1.Rows.Count - 1; i >= 0; i--)
                dataGridView1.Rows.RemoveAt(i);

            ShowListSize ("Reset", 0, false);

            theBackupTask.SourceItems = new List<SourceItem>();

            TestIfReady();

        }

        //backup
        private void SetBackupFolder()
        {
            toolStripStatusLabel1.Text = "";
            backupFolder = new SourceItem();
            backupFolder.GetPath();

            theBackupTask.BackupLocation = backupFolder.Path;

            if (backupFolder.Path == "" ||  backupFolder.Path == null)
            {
                ShowFolderNotSetInstruction();
            }
            else 
            {
                if (BackupIsSource(theBackupTask.BackupLocation)) //test that bckup folder is not a source folder
                {
                    return;
                }
                else
                {
                    BackupFolderTextBox.Text = backupFolder.Path;
                    BackupFolderTextBox.ForeColor = Color.Black;                    
                }
            }

            SaveActiveTask();
            TestIfReady();
        }

        private void DoBackup()
        {
            if (!Directory.Exists(BackupFolderTextBox.Text))
            {
                MessageBox.Show ("Backup target folder does not exist");
                return;
            }

            toolStripStatusLabel1.Text = "Backup in progress ...";
            Application.DoEvents();

            Cursor.Current = Cursors.WaitCursor;

            if (NewFolderRadioButton.Checked)
                theBackupTask.CopyMode = "Suffix";
            else if (PromptToOverwriteRadioButton.Checked)
                theBackupTask.CopyMode = "Prompt";
            else if (OverwriteRadioButton.Checked)
                theBackupTask.CopyMode = "Overwrite";


            backupDir = theBackupTask.BackupLocation;
            backupDirName = "GotYourBackUp";
            //backupDir = Path.Combine(backupDir, "GotYourBackUp");
            backupDir = Path.Combine(backupDir, backupDirName);

            if (theBackupTask.CopyMode == "Suffix")
            {
                backupDir = backupDir + "_" + DateTimeSuffix();
                backupDirName = backupDirName + "_" + DateTimeSuffix();

                if (!Directory.Exists(backupDir))
                    Directory.CreateDirectory(backupDir);
            }

            backupPath = backupDir;

            DoSaveSetttings();

            string result = "";
            if (theBackupTask.CopyMode == "Suffix" || theBackupTask.CopyMode == "Prompt")
                result = DoFullCopy();
            else
                result = DoIncrementalCopy();

            toolStripStatusLabel1.Text = "Backup " + result;

            if (result == "complete")
            {
                toolStripStatusLabel_backupPath.Text = " in " + backupDir;
                WriteDescriptionFile();
            }
            else 
                toolStripStatusLabel_backupPath.Text = "";


            if (result != "complete" && result != "cancelled")
                MessageBox.Show(result);

            Cursor.Current = Cursors.Default;

            if (myBackup.CloseAfterBackup && result =="complete")
                CloseProgram();
        }

        private void WriteDescriptionFile()
        {
            backupDescription = DescriptionTextBox.Text;
            if (backupDescription == descriptionInfoText)
                return;

            System.IO.StreamWriter writer = new System.IO.StreamWriter(backupDir + @"\description.txt", true);

            writer.WriteLine(backupDirName);
            writer.WriteLine("GYBU task name: " + theBackupTask.Name);
            writer.WriteLine();
            writer.WriteLine(backupDescription);
            writer.Flush();
            writer.Close();
            writer = null;
        }

        private string DoFullCopy()
        {
            string status = "complete";
            foreach (SourceItem item in theBackupTask.SourceItems)
            {
                if (item.IsSelected)
                {
                    if (item.IsFolder)
                    {
                        folder = new DirectoryInfo(item.Path);
                        backupPath = Path.Combine(backupDir, folder.Name);
                    }
                    if (!item.IsFolder)
                    {
                        file = new FileInfo(item.Path);
                        backupPath = Path.Combine(backupDir, file.Name);
                    }

                    try
                    {
                        if (item.IsFolder)
                            FileSystem.CopyDirectory(item.Path, backupPath, UIOption.AllDialogs, UICancelOption.ThrowException);
                        else
                            FileSystem.CopyFile(item.Path, backupPath, UIOption.AllDialogs, UICancelOption.ThrowException);
                    }
                    catch (Exception ex)
                    {
                        if (ex.Message == "The operation was canceled.")
                            status = "cancelled";
                        else
                            status = "error.... \n" + ex.ToString();
                    }
                }

            }

            return status;
        }

        private string DoIncrementalCopy()
        {
            string status = "complete";
            foreach (SourceItem item in theBackupTask.SourceItems)
            {
                if (item.IsSelected)
                {
                    if (item.IsFolder)
                    {
                        folder = new DirectoryInfo(item.Path);
                        backupPath = Path.Combine(backupDir, folder.Name);
                    }
                    if (!item.IsFolder)
                    {
                        file = new FileInfo(item.Path);
                        backupPath = Path.Combine(backupDir, file.Name);
                    }

                    try
                    {
                        if (item.IsFolder)
                            //FileSystem.CopyDirectory(item.Path, backupPath, UIOption.AllDialogs, UICancelOption.ThrowException);
                            CopyDirectory(item.Path, backupPath);
                        else
                        {
                            //FileSystem.CopyFile(item.Path, backupPath, UIOption.AllDialogs, UICancelOption.ThrowException);
                            FileInfo sourceFileInfo = new FileInfo(item.Path);
                            string backupFile = backupPath + "\\" + sourceFileInfo.Name;

                            FileInfo backupFileInfo = new FileInfo(backupFile);

                            if (backupFileInfo.LastWriteTime != sourceFileInfo.LastWriteTime)
                                File.Copy(item.Path, backupPath, true);


                        }
                    }
                    catch (Exception ex)
                    {
                        if (ex.Message == "The operation was canceled.")
                            status = "cancelled";
                        else
                            status = "error.... \n" + ex.ToString();
                    }
                }

            }
            return status;
        }

        private void OpenBackupFolder()
        {
            if (backupDir == null)
                backupDir = theBackupTask.BackupLocation;

            try
            {
                Process.Start(backupDir);   
            }      
            catch
            {
                TestBackupFolder();
            }

       
         }



        private void ResetForm()
        {
            DialogResult dialogResult = MessageBox.Show("Reset to default (new) start state:\n\n" 
                                                        + "This action will delete all your task definitions\n"
                                                        + "and settings.\n\n"
                                                        + "Are you sure?", "Got Your Back Up?"
                                                        , MessageBoxButtons.YesNo,  MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);

            if (dialogResult == DialogResult.Yes)
            {
                myBackup = new Backup();
                myBackup.XmlFile = Path.Combine(gybuDirectory, xmlFileName);
                myBackup.AddNewTask("");                    //add dummy task

                myBackup.SaveInfo();
                MakeReady();

                AddLog("Reset all " + System.Environment.MachineName, 2);
            }
        }

        private void SetLogRootFolder()         // not used ???
        {
            //string selectedPath = "";
            //try
            //{
            //    folderBrowserDialog1.RootFolder = Environment.SpecialFolder.MyComputer;
            //    selectedPath = (folderBrowserDialog1.ShowDialog() == DialogResult.OK) ? folderBrowserDialog1.SelectedPath : null;
            //}
            //catch (Exception ex)
            //{
            //    //ErrorMessage = ex.ToString();
            //}
            //if (selectedPath != "")
            //{
            //    if (selectedPath != logFileRootDirectory)       //log files root
            //    {
            //                            logFileRootDirectory = selectedPath;
            //        myBackup.LogFileDirectory = Path.Combine(logFileRootDirectory, logFileDirectory);
            //    }


            //}
        }

        private void DeleteLogs()
        {
            logger.DeleteLogs();
            AddLog("All previous log files deleted.", 2);
        }


        #endregion user commands


        //Save settings
        private void SetTaskPropertiesFromFormFields()
        {
            DataGridViewCheckBoxCell cell;

            myBackup.TaskList[activeTaskIndex].Name = theBackupTask.Name;

            int itemIndx = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                myBackup.TaskList[activeTaskIndex].SourceItems[itemIndx].IsSelected = (bool)row.Cells[0].Value; //true;
                itemIndx++;
            }

            if (BackupFolderTextBox.Text == backupFolderInstruction || BackupFolderTextBox.Text.Trim() == "")
                theBackupTask.BackupLocation = "";

            if (NewFolderRadioButton.Checked)
            {
                myBackup.TaskList[activeTaskIndex].CopyMode = "Suffix";
            }
            else if (PromptToOverwriteRadioButton.Checked)
            {
                myBackup.TaskList[activeTaskIndex].CopyMode = "Prompt";
            }
            else if (OverwriteRadioButton.Checked)
            {
                myBackup.TaskList[activeTaskIndex].CopyMode = "Overwrite";
            }


        }

        private void DoSaveSetttings()
        {
            myBackup.XmlFile = xmlFileName;

            myBackup.RunOnStartup = RunOnStartupCheckBox.Checked;
            myBackup.CloseAfterBackup = CloseAfterBackupCheckBox.Checked;
            GetScheduleSettings();

            //SetTaskPropertiesFromFormFields();
            SaveActiveTask();
            myBackup.SaveInfo();
            toolStripStatusLabel1.Text = "Settings saved";
        }




        //event helpers
        #region event helper methods

        private void AddNewRow(SourceItem source)
        {
            if (source.Path == "")
                return;

            //if (source.Path != "")
            //{
                int index = dataGridView1.Rows.Add();

                DataGridViewRow row = dataGridView1.Rows[index];

                row.Cells[0].Value = source.IsSelected;

                if (source.IsFolder)
                    row.Cells[1].Value = Properties.Resources.folder_blue;
                else
                    row.Cells[1].Value = Properties.Resources.document24;

                row.Cells[2].Value = source.Path;

                row.Cells[3].Value = ItemSize(source.ByteSize());

                ShowListSize("Add", source.ByteSize(), source.IsSelected);

                //selectedBackupSize = selectedBackupSize + source.ByteSize();
                //SelectedSizeLabel.Text = ItemSize(selectedBackupSize);

                //totalBackupSize = totalBackupSize + source.ByteSize();
                //TotalSizeLabel.Text = ItemSize(totalBackupSize);

                dataGridView1.Rows[index].Cells[0].Selected = false;
            //}

            if (dataGridView1.Rows.Count >5)
                dataGridView1.Columns["pathColumn"].Width = 643;
            else
                dataGridView1.Columns["pathColumn"].Width = 660;


            //VScrollBar vsb = new VScrollBar();
            //if (dataGridView1.Controls.Contains(vsb))
            //{
            //    int i =0;
            //}

            //if (VerticalScrollVisible(dataGridView1))
            //    dataGridView1.Columns["pathColumn"].Width = 643;
            //else
            //    dataGridView1.Columns["pathColumn"].Width = 660;

            if (dataGridView1.Rows.Count > 5)
                dataGridView1.Columns["pathColumn"].Width = 643;
            else
                dataGridView1.Columns["pathColumn"].Width = 660;

        }

        private void ShowListSize(string operation, long sourceSize, bool isSelected)
        {
            if (operation == "Reset")
            {
                selectedBackupSize = 0;
                totalBackupSize= 0;

                SelectedSizeLabel.Text = ItemSize(selectedBackupSize);
                TotalSizeLabel.Text = ItemSize(totalBackupSize);

                return;
            }

            if (operation.Contains("Subtract"))
                sourceSize = -sourceSize;

            //selected label
            if (isSelected || operation.Contains("Selected"))
                selectedBackupSize = selectedBackupSize + sourceSize;

            if (selectedBackupSize < 0) selectedBackupSize = 0;
            SelectedSizeLabel.Text = ItemSize(selectedBackupSize);

            //total label
            if (!operation.Contains("Selected"))
            {
                totalBackupSize = totalBackupSize + sourceSize;
                if (totalBackupSize < 0) totalBackupSize = 0;
                TotalSizeLabel.Text = ItemSize(totalBackupSize);
            }

        }

        private bool VerticalScrollVisible(DataGridView dataGridView1)
        {
            //http://stackoverflow.com/questions/4205402/c-sharp-identifying-scrollbar-on-control

            VScrollBar _verticalScrollBar = new VScrollBar();
            HScrollBar _horizontalScrollBar = new HScrollBar();

            foreach (Control c in dataGridView1.Controls)
            {
                if (c is VScrollBar)
                {
                    _verticalScrollBar = c as VScrollBar;
                    //if (_horizontalScrollBar != null)
                    //{
                    break;
                    //}
                }
                //if (c is HScrollBar)
                //{
                //    _horizontalScrollBar = c as HScrollBar;
                //    if (_verticalScrollBar != null)
                //    {
                //        break;
                //    }
                //}
            }

            return _verticalScrollBar.Visible;

        }

         private bool SourceAlreadySelected()
        {
            bool ok = false;
            foreach (SourceItem item in theBackupTask.SourceItems)
            {
                if (selectedSource.Path == item.Path)
                {
                    ok = true;
                    break;
                }
            }
            return ok;
        }

        private bool BackupIsSource(string path)
         {
             bool ok = false;
             foreach (SourceItem item in theBackupTask.SourceItems)
             {
                 if (item.Path == path)
                 {
                     ok = true;
                     MessageBox.Show("Selected backup path is the same as a source path!", "Get your back up", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                     theBackupTask.BackupLocation = BackupFolderTextBox.Text;
                     break;
                 }
             }
             return ok;
         }   

        #endregion helper methods

        #region utility methods

        private string GetVersion()
        {
            System.Reflection.Assembly _assemblyInfo = System.Reflection.Assembly.GetExecutingAssembly();

            string myVersion = string.Empty;
            string myDate = string.Empty;

            //if running the deployed application, you can get the version
            //  from the ApplicationDeployment information. If you try
            //  to access this when you are running in Visual Studio, it will not work.
            if (System.Deployment.Application.ApplicationDeployment.IsNetworkDeployed)
            {
                myVersion = System.Deployment.Application.ApplicationDeployment.CurrentDeployment.CurrentVersion.ToString();
                myDate = System.IO.File.GetLastWriteTime(Assembly.GetExecutingAssembly().Location).ToShortDateString();
            }
            else
            {
                if (_assemblyInfo != null)
                {
                    myVersion = "v" + _assemblyInfo.GetName().Version.ToString();
                    myDate = DateTime.Today.ToShortDateString();
                }
            }
            return myVersion;
        }

        private string DateTimeSuffix()
        {
            string suffix = "";
            string year = "";
            string mon = "";
            string day = "";
            string hour = "";
            string min = "";
            string sec = "";

            DateTime now = DateTime.Now;
            year = now.Year.ToString();
            mon = now.Month.ToString();
            if (mon.Length == 1) mon = "0" + mon;
            day = now.Day.ToString();
            if (day.Length == 1) day = "0" + day;
            hour = now.Hour.ToString();
            if (hour.Length == 1) hour = "0" + hour;
            min = now.Minute.ToString();
            if (min.Length == 1) min = "0" + min;
            sec = now.Second.ToString();
            if (sec.Length == 1) sec = "0" + sec;
            //suffix = year + "-" + mon + "-" + day + "-" + hour + "-" + min;
            suffix = year + mon + day + "-" + hour + min+sec; 
            return suffix;
        }

        private static void DirectoryCopy(string sourceDirName, string destDirName, bool copySubDirs)
        {
            //from msdn code
            DirectoryInfo dir = new DirectoryInfo(sourceDirName);
            DirectoryInfo[] dirs = dir.GetDirectories();

            if (!dir.Exists)
            {
                throw new DirectoryNotFoundException(
                    "Source directory does not exist or could not be found: "
                    + sourceDirName);
            }

            if (!Directory.Exists(destDirName))
            {
                Directory.CreateDirectory(destDirName);
            }

            FileInfo[] files = dir.GetFiles();
            foreach (FileInfo file in files)
            {
                string temppath = Path.Combine(destDirName, file.Name);
                file.CopyTo(temppath, true);  //copy with verwrite
            }

            if (copySubDirs)
            {
                foreach (DirectoryInfo subdir in dirs)
                {
                    string temppath = Path.Combine(destDirName, subdir.Name);
                    DirectoryCopy(subdir.FullName, temppath, copySubDirs);
                }
            }
        }

        private void AddLog(string logMessage, int level)
        {
            if (!logger.LoggingIsActive)
                return;

            logger.WriteToLog(logMessage, level);

            richTextBox1.LoadFile(logger.LogFilePath, RichTextBoxStreamType.PlainText);

        }

        private string ItemSize(long byteSize)
        {
            string[] byteDim = new string[] { "B", "kB", "MB", "GB", "TB", "PB", "EB", "ZB", "YB" };
            int dimCount = 0;

            while (byteSize > 1024)
            {
                byteSize = byteSize / 1024;
                dimCount++;
            }
            string mySize = byteSize.ToString() + " " + byteDim[dimCount];
            return mySize;
        }

        #endregion utilities

        #region gridview actions

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int columnIndex = dataGridView1.CurrentCell.ColumnIndex;
            int rowIndex = dataGridView1.CurrentCell.RowIndex;


            switch (e.ColumnIndex)
            {
                case 0: // select check box
                    this.dataGridView1.Rows[rowIndex].Cells[0].Selected = false;
                    //this.dataGridView1.Rows[rowIndex].Selected = true;
                    //theBackupTask.SourceItems[rowIndex].IsSelected = (bool)this.dataGridView1.Rows[rowIndex].Cells[0].Value;
                    break;

                case 4: //remove row

                    dataGridView1.Rows.RemoveAt(rowIndex);
                    theBackupTask.SourceItems.RemoveAt(rowIndex);

                    totalBackupSize = 0;
                    foreach (SourceItem item in theBackupTask.SourceItems)
                    {
                        totalBackupSize = totalBackupSize + item.ByteSize();
                    }
                    TotalSizeLabel.Text = ItemSize(totalBackupSize);

                    TestIfReady();
                    break;

                case 5: // open button
                    Process.Start(dataGridView1.Rows[rowIndex].Cells[2].Value.ToString());
                    break;
            }

            SaveActiveTask();

            TestIfReady();
        }




        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            AddNewItem("folder");
        }

        #endregion gridview actions

        #region menuitems

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void newtaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GetNewTaskName("add");
        }


        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewItem("file");
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewItem("folder");
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DoSaveSetttings();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
                CloseProgram();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
            aboutForm.Close();
        }

        private void logsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteLogs();
        }

        #endregion menuitems

        #region Settings options actions

        private void CloseAfterBackupCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!formIsReady) return;
            myBackup.CloseAfterBackup = CloseAfterBackupCheckBox.Checked;
            //ShowSettingsSummary();

        }

        private void RunOnStartupCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!formIsReady) return;

            myBackup.RunOnStartup = RunOnStartupCheckBox.Checked;
            //ShowSettingsSummary();
        }

        private void ScheduleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!ScheduleCheckBox.Checked)
            {
                SetScheduleOff();            //blank schedule settings 
            }
            else
            {
                SetScheduleOn();
            }
            
            //ShowSettingsSummary();

        }



        private void FrequencyComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (populatingFreqCombo) return;
            if (FrequencyComboBox.SelectedIndex == -1) return;

            ScheduleNormalLayout();

            switch (FrequencyComboBox.Text)
            {
                case "Monthly":
                    DayDateLabel.Text = "On date";
                    DayComboBox.DataSource = dateList;
                    break;

                case "Weekly":
                    DayDateLabel.Text = "On day";
                    DayComboBox.DataSource = daysList;
                    break;

                case "Daily":
                    DayDateLabel.Visible = false;
                    DayComboBox.Visible = false;
                    DayComboBox.SelectedIndex = -1;
                    break;

                case "Once":
                    ScheduleOnceLayout();
                    break;
            }

            myBackup.Frequency = FrequencyComboBox.Text;

            //scheduleRunTime = GetSchedRunTime();

            //if (myBackup.ScheduleIsSet)
            //    SetScheduler();

            
        }

        private void ScheduleNormalLayout()
        {
            DayDateLabel.Visible = true;
            DayComboBox.Visible = true;

            ExpiresLabel.Text = "Expires";
            ExpiresLabel.Location = new Point(219, 4);
            ExpiryDateTimePicker.Location = new Point(219, 19);
            ExpiryDateTimePicker.Value = DateTime.Now.AddYears(1);

            TimeLabel.Location = new Point(144, 4);
            TimePicker.Location = new Point(144, 19);
            TimePicker.Value = DateTime.Today + TimeSpan.FromHours(9);
        }

        private void ScheduleOnceLayout()
        {
            DayDateLabel.Visible = false;
            DayComboBox.Visible = false;
            DayComboBox.SelectedIndex = -1;

            ExpiresLabel.Text = "On date";
            ExpiresLabel.Location = new Point(80, 4);
            ExpiryDateTimePicker.Location = new Point(80, 19);
            ExpiryDateTimePicker.Value = DateTime.Now;

            TimeLabel.Location = new Point(170, 4);
            TimePicker.Location = new Point(170, 19);
            TimePicker.Value = DateTime.Now.AddHours(1);

            myBackup.DayDate = "";
         
        }

        private void TestScheduleCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (TestScheduleCheckBox.Checked && myBackup.ScheduleIsSet)
                SetSchedule();
        }


        #endregion Settings options actions


        #region schedule stuff

        private void GetScheduleSettings()
        {
            if (ScheduleCheckBox.Checked)
            {
                myBackup.ScheduleIsSet = true;
                myBackup.Frequency = FrequencyComboBox.Text;
            }
            else
            {
                myBackup.ScheduleIsSet = false;
                myBackup.Frequency = "";
            }

            if (myBackup.Frequency != "Once")
            {
                myBackup.DayDate = DayComboBox.Text;
            }
            else
            {                               //one run scheduled... this will trigger when ready
                 myBackup.DayDate = "";
            }

        }

        private DateTime GetSchedRunTime()
        {
            DateTime myRunTime = DateTime.MinValue;

            //bool dayIsOK = false;
            //bool timeIsOk = false;

            int year = DateTime.Now.Year;
            int month = DateTime.Now.Month;
            int day = DateTime.Now.Day;
            int hour = DateTime.Now.Hour;
            int minute = DateTime.Now.Minute;

            switch (myBackup.Frequency)
            {
                case "Monthly":
                    //if (day = int.Parse(DayComboBox.Text))
                        
                    //    ;

                    DayComboBox.DataSource = dateList;
                    break;

                case "Weekly":
                    DayDateLabel.Text = "On day";
                    DayComboBox.DataSource = daysList;

                    break;

                case "Daily":
                    DayDateLabel.Visible = false;
                    DayComboBox.Visible = false;

                    break;
            }



            return myRunTime; ;
        }

        private void DisplayTaskDetails()
        {
            using (TaskService ts = new TaskService())
            {
                TaskFolder tf = ts.RootFolder;

                Microsoft.Win32.TaskScheduler.Task runningTask = tf.Tasks["Got Your Back Up"];

                string line1 = "\nProgram schedule:";
                string line2 = "\n\nNext run scheduled: ";
                string line3 = "";

                for (int i = 0; i < runningTask.Definition.Triggers.Count; i++)
                    line1 = line1 + "\n" + runningTask.Definition.Triggers[i].ToString();

                line2 = line2 + runningTask.NextRunTime.ToShortDateString() + " at " + runningTask.NextRunTime.ToShortTimeString();

                //line3 = line3 + expiry.ToShortDateString();


                //string line3 = "\nNew task actions:";
                //for (int i = 0; i < runningTask.Definition.Actions.Count; i++)
                //    line3 = line3 + "\n" + runningTask.Definition.Actions[i].ToString();


                MessageBox.Show(line1 + line2 + line3, "Got Your Back Up?");

            }
        }

        private void RemoveSchedule()
        {
            using (TaskService taskService = new TaskService())
            {

                //// Remove the task we just created
                //taskService.RootFolder.DeleteTask(@"GotYourBackUp");

                try
                {
                    taskService.RootFolder.DeleteTask(@"GotYourBackUp");
                }
                catch
                {
                    //taks does not exist.... do nothing
                }
            }
        }

        #endregion schedule stuff

        #region other events

        private void NewFolderRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (NewFolderRadioButton.Checked)
                theBackupTask.CopyMode = "Suffix";
            else
                theBackupTask.CopyMode = "Prompt";

            //ShowSettingsSummary();
        }

        private void PromptCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (PromptCheckBox.Checked)
                myBackup.IdiotPrompt = false;
            else
                myBackup.IdiotPrompt = true;

            TestIfReady();
        }

        private void TaskComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!populatingTaskCombo)
            {
                LoadActiveBackupProfile();
                SaveActiveTask();
                TestIfReady();
            }

        }
        
        private void BackupFolderTextBox_Leave(object sender, EventArgs e)
        {
            if (BackupFolderTextBox.Text != backupFolderInstruction)
                TestBackupFolder();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            richTextBox1.LoadFile(logger.LogFilePath, RichTextBoxStreamType.PlainText);
        }

        private void XmlFolderPathLinkLabel_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    Process.Start(XmlFolderPathLinkLabel.Text);
            //}
            //catch
            //{
            //    //;
            //}
        }

        private void LogFolderPathLinkLabel_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(LogFolderPathLinkLabel.Text);
            }
            catch
            {
                //;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Application.DoEvents();
            int columnIndex = dataGridView1.CurrentCell.ColumnIndex;
            int rowIndex = dataGridView1.CurrentCell.RowIndex;

            if (dataGridView1.IsCurrentCellDirty)
            {
                dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }

            switch (e.ColumnIndex)
            {
                case 0: // select check box
                    SourceItem item = theBackupTask.SourceItems[rowIndex];
                    item.IsSelected = (bool)this.dataGridView1.Rows[rowIndex].Cells[0].Value;

                    string operation = "Add-Selected";
                    if ( !item.IsSelected)
                        operation = "Subtract-Selected";

                    ShowListSize(operation, item.ByteSize(), item.IsSelected);
                    break;

                case 4: //remove row
                    RemoveItem(rowIndex);
                    //dataGridView1.Rows.RemoveAt(rowIndex);
                    //theBackupTask.SourceItems.RemoveAt(rowIndex);

                    //if (VerticalScrollVisible(dataGridView1))
                    //    dataGridView1.Columns["pathColumn"].Width = 643;
                    //else
                    //    dataGridView1.Columns["pathColumn"].Width = 660;

                    //totalBackupSize = 0;
                    //foreach (SourceItem item in theBackupTask.SourceItems)
                    //{
                    //    totalBackupSize = totalBackupSize + item.ByteSize();
                    //}
                    //TotalSizeLabel.Text = ItemSize(totalBackupSize);

                    //TestIfReady();
                    break;

                case 5: // open button
                    Process.Start(dataGridView1.Rows[rowIndex].Cells[2].Value.ToString());
                    break;
            }

            SaveActiveTask();
            TestIfReady();



        }

        private void RemoveItem(int index)
        {
            dataGridView1.Rows.RemoveAt(index);

            SourceItem item = theBackupTask.SourceItems[index];

            ShowListSize("Subtract", item.ByteSize(), item.IsSelected); 

            theBackupTask.SourceItems.RemoveAt(index);

            if (dataGridView1.Rows.Count >5)
                dataGridView1.Columns["pathColumn"].Width = 643;
            else
                dataGridView1.Columns["pathColumn"].Width = 660;

            //if (VerticalScrollVisible(dataGridView1))
            //    dataGridView1.Columns["pathColumn"].Width = 643;
            //else
            //    dataGridView1.Columns["pathColumn"].Width = 660;

            //totalBackupSize = 0;
            //foreach (SourceItem item in theBackupTask.SourceItems)
            //{
            //    totalBackupSize = totalBackupSize + item.ByteSize();
            //}
            //TotalSizeLabel.Text = ItemSize(totalBackupSize);

            TestIfReady();
        }

        private void toolStripStatusLabel_backupPath_Click(object sender, EventArgs e)
        {
            Process.Start(toolStripStatusLabel_backupPath.Text);
        }

        #endregion other events



        //closing ...
        private void CloseProgram()
        {
            if (!programAbort)
                DoSaveSetttings();

            this.Close();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (programAbort)
                return;

            if (dataGridView1.IsCurrentCellDirty)
            {
                dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
            
            DoSaveSetttings();

            AddLog("Got Your Back Up? program ended ", 2);
        }




        //copy utilitites
        public static void CopyDirectory(string source, string target)
        {
            var stack = new Stack<Folders>();
            stack.Push(new Folders(source, target));

            while (stack.Count > 0)
            {
                var folders = stack.Pop();
                Directory.CreateDirectory(folders.Target);
                foreach (var file in Directory.GetFiles(folders.Source, "*.*"))
                {
                    string targetFile = Path.Combine(folders.Target, Path.GetFileName(file));
                    //if (File.Exists(targetFile)) File.Delete(targetFile);
                    //File.Copy(file, targetFile);

                    FileInfo sFileInfo = new FileInfo(file);
                    FileInfo tFileInfo = new FileInfo(targetFile);

                    if (tFileInfo.LastWriteTime != sFileInfo.LastWriteTime)
                        File.Copy(file, targetFile, true);

                }

                foreach (var folder in Directory.GetDirectories(folders.Source))
                {
                    try
                    {
                        stack.Push(new Folders(folder, Path.Combine(folders.Target, Path.GetFileName(folder))));
                        
                    }
                    catch
                    {
                    
                    }
                }
            }
        }
        public static void MoveDirectory(string source, string target)
        {
            var stack = new Stack<Folders>();
            stack.Push(new Folders(source, target));

            while (stack.Count > 0)
            {
                var folders = stack.Pop();
                Directory.CreateDirectory(folders.Target);
                foreach (var file in Directory.GetFiles(folders.Source, "*.*"))
                {
                    string targetFile = Path.Combine(folders.Target, Path.GetFileName(file));
                    if (File.Exists(targetFile)) File.Delete(targetFile);
                    File.Move(file, targetFile);
                }

                foreach (var folder in Directory.GetDirectories(folders.Source))
                {
                    stack.Push(new Folders(folder, Path.Combine(folders.Target, Path.GetFileName(folder))));
                }
            }
            Directory.Delete(source, true);
        }

        public class Folders
        {
            public string Source { get; private set; }
            public string Target { get; private set; }

            public Folders(string source, string target)
            {
                Source = source;
                Target = target;
            }
        }

        private void contentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (PromptCheckBox.Checked)
            {
                MessageBox.Show("Uncheck the 'Suppress idiot prompts'.\n\n"
                                + "Let me do it for you.","Got Your Back Up?",
                                 MessageBoxButtons.OK, MessageBoxIcon.Information);
                PromptCheckBox.Checked = false;
            }
            else
            {
                MessageBox.Show("You don't need any help. Just read the 'idiot prompts'.", "Got Your Back Up?",
                 MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void DescriptionTextBox_Enter(object sender, EventArgs e)
        {
            if (DescriptionTextBox.Text == descriptionInfoText)
                DescriptionTextBox.Text = "";

            DescriptionTextBox.ForeColor = Color.Black;
        }

        private void DescriptionTextBox_Leave(object sender, EventArgs e)
        {
            if (DescriptionTextBox.Text.Trim() != "")
                return;

            DescriptionTextBox.ForeColor = Color.Gray;
            DescriptionTextBox.Text = descriptionInfoText;
        }










        





    }
}
