namespace GotYourBackUp
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.NewFolderRadioButton = new System.Windows.Forms.RadioButton();
            this.PromptToOverwriteRadioButton = new System.Windows.Forms.RadioButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_backupPath = new System.Windows.Forms.ToolStripStatusLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.selectColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.typeColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.pathColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sizeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.removeColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.openColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.BackupFolderTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.newtaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.printToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printPreviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BackupListDataGridView = new System.Windows.Forms.DataGridView();
            this.select = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewImageColumn();
            this.path = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.AddFolderButton = new System.Windows.Forms.Button();
            this.BackupButton = new System.Windows.Forms.Button();
            this.AddFileButton = new System.Windows.Forms.Button();
            this.BackupFolderButton = new System.Windows.Forms.Button();
            this.OpenBackupFolderButton = new System.Windows.Forms.Button();
            this.OverwriteRadioButton = new System.Windows.Forms.RadioButton();
            this.SourceInstructionLabel = new System.Windows.Forms.Label();
            this.AutorunLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TotalSizeLabel = new System.Windows.Forms.Label();
            this.PromptCheckBox = new System.Windows.Forms.CheckBox();
            this.CloseAfterBackupCheckBox = new System.Windows.Forms.CheckBox();
            this.RunOnStartupCheckBox = new System.Windows.Forms.CheckBox();
            this.AutoCloseLabel = new System.Windows.Forms.Label();
            this.BackupModeGroupBox = new System.Windows.Forms.GroupBox();
            this.SchedulerGroupBox = new System.Windows.Forms.GroupBox();
            this.SchedulePanel = new System.Windows.Forms.Panel();
            this.ExpiryDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.FrequencyLabel = new System.Windows.Forms.Label();
            this.FrequencyComboBox = new System.Windows.Forms.ComboBox();
            this.TimePicker = new System.Windows.Forms.DateTimePicker();
            this.DayComboBox = new System.Windows.Forms.ComboBox();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.ExpiresLabel = new System.Windows.Forms.Label();
            this.DayDateLabel = new System.Windows.Forms.Label();
            this.ScheduleCheckBox = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.ResetSettingsButton = new System.Windows.Forms.Button();
            this.SetScheduleButton = new System.Windows.Forms.Button();
            this.NextRunLlabel = new System.Windows.Forms.Label();
            this.TestScheduleCheckBox = new System.Windows.Forms.CheckBox();
            this.ScheduleLabel = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.BackupModeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TaskSelectorGroupBox = new System.Windows.Forms.GroupBox();
            this.NumTaskslabel = new System.Windows.Forms.Label();
            this.TaskSelectorInfoLabel = new System.Windows.Forms.Label();
            this.AddTaskButton = new System.Windows.Forms.Button();
            this.TaskComboBox = new System.Windows.Forms.ComboBox();
            this.ActiveTaskPanel = new System.Windows.Forms.Panel();
            this.DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.SelectedSizeLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ClearListButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ActiveTaskNameLabel = new System.Windows.Forms.Label();
            this.ActiveTaskManagerGroupBox = new System.Windows.Forms.GroupBox();
            this.TaskManagerInfoLabel = new System.Windows.Forms.Label();
            this.DeleteTaskButton = new System.Windows.Forms.Button();
            this.RenameTaskButton = new System.Windows.Forms.Button();
            this.SaveTaskButton = new System.Windows.Forms.Button();
            this.ActiveTaskInfoLabel = new System.Windows.Forms.Label();
            this.RenameActiveTaskTextBox = new System.Windows.Forms.TextBox();
            this.ConfirmNameChangeButton = new System.Windows.Forms.Button();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RenameTaskPanel = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.CancelNameChangeButton = new System.Windows.Forms.Button();
            this.NewTaskNameLabel = new System.Windows.Forms.Label();
            this.RenameTaskLabel = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ActiveTaskTabPage = new System.Windows.Forms.TabPage();
            this.LoggingTabPage = new System.Windows.Forms.TabPage();
            this.DeleteLogsButton = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SettingsTabPage = new System.Windows.Forms.TabPage();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.LogFolderPathLinkLabel = new System.Windows.Forms.LinkLabel();
            this.SelectLogFolderButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackupListDataGridView)).BeginInit();
            this.BackupModeGroupBox.SuspendLayout();
            this.SchedulerGroupBox.SuspendLayout();
            this.SchedulePanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.TaskSelectorGroupBox.SuspendLayout();
            this.ActiveTaskPanel.SuspendLayout();
            this.ActiveTaskManagerGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.RenameTaskPanel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.ActiveTaskTabPage.SuspendLayout();
            this.LoggingTabPage.SuspendLayout();
            this.SettingsTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Multiselect = true;
            // 
            // NewFolderRadioButton
            // 
            this.NewFolderRadioButton.AutoSize = true;
            this.NewFolderRadioButton.Checked = true;
            this.NewFolderRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewFolderRadioButton.Location = new System.Drawing.Point(10, 23);
            this.NewFolderRadioButton.Name = "NewFolderRadioButton";
            this.NewFolderRadioButton.Size = new System.Drawing.Size(239, 17);
            this.NewFolderRadioButton.TabIndex = 0;
            this.NewFolderRadioButton.TabStop = true;
            this.NewFolderRadioButton.Text = "Full backup to new folder with date-time suffix";
            this.toolTip1.SetToolTip(this.NewFolderRadioButton, "This will create a new folder of the same name with a data-time suffix");
            this.NewFolderRadioButton.UseVisualStyleBackColor = true;
            this.NewFolderRadioButton.CheckedChanged += new System.EventHandler(this.NewFolderRadioButton_CheckedChanged);
            // 
            // PromptToOverwriteRadioButton
            // 
            this.PromptToOverwriteRadioButton.AutoSize = true;
            this.PromptToOverwriteRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PromptToOverwriteRadioButton.Location = new System.Drawing.Point(10, 46);
            this.PromptToOverwriteRadioButton.Name = "PromptToOverwriteRadioButton";
            this.PromptToOverwriteRadioButton.Size = new System.Drawing.Size(259, 17);
            this.PromptToOverwriteRadioButton.TabIndex = 1;
            this.PromptToOverwriteRadioButton.Text = "Full backup with prompts to overwrite existing files";
            this.toolTip1.SetToolTip(this.PromptToOverwriteRadioButton, "You will be promted to overwrite (or not) any previous backups  in this location");
            this.PromptToOverwriteRadioButton.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel_backupPath});
            this.statusStrip1.Location = new System.Drawing.Point(0, 708);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(919, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel_backupPath
            // 
            this.toolStripStatusLabel_backupPath.IsLink = true;
            this.toolStripStatusLabel_backupPath.Name = "toolStripStatusLabel_backupPath";
            this.toolStripStatusLabel_backupPath.Size = new System.Drawing.Size(180, 17);
            this.toolStripStatusLabel_backupPath.Text = "toolStripStatusLabel_backupPath";
            this.toolStripStatusLabel_backupPath.Click += new System.EventHandler(this.toolStripStatusLabel_backupPath_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowDrop = true;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selectColumn,
            this.typeColumn,
            this.pathColumn,
            this.sizeColumn,
            this.removeColumn,
            this.openColumn});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(9, 52);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 22;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView1.Size = new System.Drawing.Size(879, 170);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // selectColumn
            // 
            this.selectColumn.HeaderText = "";
            this.selectColumn.Name = "selectColumn";
            this.selectColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.selectColumn.Width = 20;
            // 
            // typeColumn
            // 
            this.typeColumn.HeaderText = "Type";
            this.typeColumn.Name = "typeColumn";
            this.typeColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.typeColumn.Width = 40;
            // 
            // pathColumn
            // 
            this.pathColumn.HeaderText = "Path";
            this.pathColumn.Name = "pathColumn";
            this.pathColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.pathColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.pathColumn.Width = 660;
            // 
            // sizeColumn
            // 
            this.sizeColumn.HeaderText = "Size";
            this.sizeColumn.Name = "sizeColumn";
            this.sizeColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.sizeColumn.Width = 60;
            // 
            // removeColumn
            // 
            this.removeColumn.HeaderText = "Remove";
            this.removeColumn.Image = global::GotYourBackUp.Properties.Resources.delete;
            this.removeColumn.Name = "removeColumn";
            this.removeColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.removeColumn.Width = 55;
            // 
            // openColumn
            // 
            this.openColumn.HeaderText = "Open";
            this.openColumn.Image = global::GotYourBackUp.Properties.Resources.eye;
            this.openColumn.Name = "openColumn";
            this.openColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.openColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.openColumn.ToolTipText = "Open folder or file";
            this.openColumn.Width = 40;
            // 
            // BackupFolderTextBox
            // 
            this.BackupFolderTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackupFolderTextBox.Location = new System.Drawing.Point(8, 263);
            this.BackupFolderTextBox.Name = "BackupFolderTextBox";
            this.BackupFolderTextBox.Size = new System.Drawing.Size(735, 23);
            this.BackupFolderTextBox.TabIndex = 4;
            this.BackupFolderTextBox.Leave += new System.EventHandler(this.BackupFolderTextBox_Leave);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(89, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 26);
            this.label5.TabIndex = 15;
            this.label5.Text = "Got your back up?";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(919, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resetToolStripMenuItem,
            this.toolStripSeparator7,
            this.newtaskToolStripMenuItem,
            this.toolStripSeparator6,
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.toolStripSeparator,
            this.saveToolStripMenuItem,
            this.saveAsToolStripMenuItem,
            this.toolStripSeparator1,
            this.printToolStripMenuItem,
            this.printPreviewToolStripMenuItem,
            this.toolStripSeparator2,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // resetToolStripMenuItem
            // 
            this.resetToolStripMenuItem.Name = "resetToolStripMenuItem";
            this.resetToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl-R";
            this.resetToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.resetToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.resetToolStripMenuItem.Text = "&Reset  all";
            this.resetToolStripMenuItem.Click += new System.EventHandler(this.resetToolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(172, 6);
            // 
            // newtaskToolStripMenuItem
            // 
            this.newtaskToolStripMenuItem.Name = "newtaskToolStripMenuItem";
            this.newtaskToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.newtaskToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.newtaskToolStripMenuItem.Text = "New &task";
            this.newtaskToolStripMenuItem.Click += new System.EventHandler(this.newtaskToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(172, 6);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
            this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.newToolStripMenuItem.Text = "&New file";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.openToolStripMenuItem.Text = "New f&older";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(172, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripMenuItem.Image")));
            this.saveToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsToolStripMenuItem
            // 
            this.saveAsToolStripMenuItem.Enabled = false;
            this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.saveAsToolStripMenuItem.Text = "Save &As";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(172, 6);
            // 
            // printToolStripMenuItem
            // 
            this.printToolStripMenuItem.Enabled = false;
            this.printToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripMenuItem.Image")));
            this.printToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripMenuItem.Name = "printToolStripMenuItem";
            this.printToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.printToolStripMenuItem.Text = "&Print";
            // 
            // printPreviewToolStripMenuItem
            // 
            this.printPreviewToolStripMenuItem.Enabled = false;
            this.printPreviewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("printPreviewToolStripMenuItem.Image")));
            this.printPreviewToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printPreviewToolStripMenuItem.Name = "printPreviewToolStripMenuItem";
            this.printPreviewToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.printPreviewToolStripMenuItem.Text = "Print Pre&view";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(172, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator3,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripSeparator4,
            this.selectAllToolStripMenuItem});
            this.editToolStripMenuItem.Enabled = false;
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.undoToolStripMenuItem.Text = "&Undo";
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.redoToolStripMenuItem.Text = "&Redo";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(141, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripMenuItem.Image")));
            this.cutToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.cutToolStripMenuItem.Text = "Cu&t";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripMenuItem.Image")));
            this.copyToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.copyToolStripMenuItem.Text = "&Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripMenuItem.Image")));
            this.pasteToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.pasteToolStripMenuItem.Text = "&Paste";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(141, 6);
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.selectAllToolStripMenuItem.Text = "Select &All";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customizeToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.logsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // customizeToolStripMenuItem
            // 
            this.customizeToolStripMenuItem.Enabled = false;
            this.customizeToolStripMenuItem.Name = "customizeToolStripMenuItem";
            this.customizeToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.customizeToolStripMenuItem.Text = "&Customize";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Enabled = false;
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // logsToolStripMenuItem
            // 
            this.logsToolStripMenuItem.Name = "logsToolStripMenuItem";
            this.logsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.logsToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.logsToolStripMenuItem.Text = "Delete &Logs";
            this.logsToolStripMenuItem.Click += new System.EventHandler(this.logsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator5,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.contentsToolStripMenuItem.Text = "&Contents";
            this.contentsToolStripMenuItem.Click += new System.EventHandler(this.contentsToolStripMenuItem_Click);
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Enabled = false;
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.indexToolStripMenuItem.Text = "&Index";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Enabled = false;
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.searchToolStripMenuItem.Text = "&Search";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(138, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.aboutToolStripMenuItem.Text = "&About...";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // BackupListDataGridView
            // 
            this.BackupListDataGridView.AllowDrop = true;
            this.BackupListDataGridView.AllowUserToAddRows = false;
            this.BackupListDataGridView.AllowUserToDeleteRows = false;
            this.BackupListDataGridView.AllowUserToOrderColumns = true;
            this.BackupListDataGridView.AllowUserToResizeColumns = false;
            this.BackupListDataGridView.AllowUserToResizeRows = false;
            this.BackupListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BackupListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.select,
            this.type,
            this.path});
            this.BackupListDataGridView.Location = new System.Drawing.Point(1036, 157);
            this.BackupListDataGridView.Name = "BackupListDataGridView";
            this.BackupListDataGridView.RowHeadersVisible = false;
            this.BackupListDataGridView.RowHeadersWidth = 22;
            this.BackupListDataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.BackupListDataGridView.RowTemplate.Height = 30;
            this.BackupListDataGridView.Size = new System.Drawing.Size(110, 75);
            this.BackupListDataGridView.TabIndex = 19;
            this.BackupListDataGridView.Visible = false;
            // 
            // select
            // 
            this.select.HeaderText = "";
            this.select.Name = "select";
            this.select.Width = 20;
            // 
            // type
            // 
            this.type.HeaderText = "Type";
            this.type.Name = "type";
            this.type.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.type.Width = 40;
            // 
            // path
            // 
            this.path.HeaderText = "Path";
            this.path.Name = "path";
            this.path.Width = 777;
            // 
            // AddFolderButton
            // 
            this.AddFolderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddFolderButton.Image = global::GotYourBackUp.Properties.Resources.folder_new;
            this.AddFolderButton.Location = new System.Drawing.Point(9, 7);
            this.AddFolderButton.Name = "AddFolderButton";
            this.AddFolderButton.Size = new System.Drawing.Size(232, 39);
            this.AddFolderButton.TabIndex = 1;
            this.AddFolderButton.Text = "Add a folder to the backup list";
            this.AddFolderButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.AddFolderButton, "Add new folder that you want to backup");
            this.AddFolderButton.UseVisualStyleBackColor = true;
            this.AddFolderButton.Click += new System.EventHandler(this.ButtonClickHub);
            // 
            // BackupButton
            // 
            this.BackupButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackupButton.Image = ((System.Drawing.Image)(resources.GetObject("BackupButton.Image")));
            this.BackupButton.Location = new System.Drawing.Point(748, 346);
            this.BackupButton.Name = "BackupButton";
            this.BackupButton.Size = new System.Drawing.Size(138, 52);
            this.BackupButton.TabIndex = 9;
            this.BackupButton.Text = "Backup now";
            this.BackupButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.BackupButton, "Copy all selected paths to backup location");
            this.BackupButton.UseVisualStyleBackColor = true;
            this.BackupButton.Click += new System.EventHandler(this.ButtonClickHub);
            // 
            // AddFileButton
            // 
            this.AddFileButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddFileButton.Image = global::GotYourBackUp.Properties.Resources.document_new1;
            this.AddFileButton.Location = new System.Drawing.Point(247, 7);
            this.AddFileButton.Name = "AddFileButton";
            this.AddFileButton.Size = new System.Drawing.Size(232, 39);
            this.AddFileButton.TabIndex = 2;
            this.AddFileButton.Text = "Add a file to the backup list";
            this.AddFileButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.AddFileButton, "Add new file that you want to backup");
            this.AddFileButton.UseVisualStyleBackColor = true;
            this.AddFileButton.Click += new System.EventHandler(this.ButtonClickHub);
            // 
            // BackupFolderButton
            // 
            this.BackupFolderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackupFolderButton.Image = global::GotYourBackUp.Properties.Resources.folder;
            this.BackupFolderButton.Location = new System.Drawing.Point(8, 226);
            this.BackupFolderButton.Name = "BackupFolderButton";
            this.BackupFolderButton.Size = new System.Drawing.Size(372, 33);
            this.BackupFolderButton.TabIndex = 3;
            this.BackupFolderButton.Text = "Select a folder where the backup copy will be made";
            this.BackupFolderButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.BackupFolderButton, "Select backup location");
            this.BackupFolderButton.UseVisualStyleBackColor = true;
            this.BackupFolderButton.Click += new System.EventHandler(this.ButtonClickHub);
            // 
            // OpenBackupFolderButton
            // 
            this.OpenBackupFolderButton.Image = global::GotYourBackUp.Properties.Resources.eye;
            this.OpenBackupFolderButton.Location = new System.Drawing.Point(748, 263);
            this.OpenBackupFolderButton.Name = "OpenBackupFolderButton";
            this.OpenBackupFolderButton.Size = new System.Drawing.Size(138, 23);
            this.OpenBackupFolderButton.TabIndex = 5;
            this.OpenBackupFolderButton.Text = "  Open backup folder";
            this.OpenBackupFolderButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.OpenBackupFolderButton, "Open the backup location directory");
            this.OpenBackupFolderButton.UseVisualStyleBackColor = true;
            this.OpenBackupFolderButton.Click += new System.EventHandler(this.ButtonClickHub);
            // 
            // OverwriteRadioButton
            // 
            this.OverwriteRadioButton.AutoSize = true;
            this.OverwriteRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OverwriteRadioButton.Location = new System.Drawing.Point(10, 69);
            this.OverwriteRadioButton.Name = "OverwriteRadioButton";
            this.OverwriteRadioButton.Size = new System.Drawing.Size(310, 17);
            this.OverwriteRadioButton.TabIndex = 2;
            this.OverwriteRadioButton.Text = "Incremental backup: changed files overwitten wthout prompt";
            this.OverwriteRadioButton.UseVisualStyleBackColor = true;
            // 
            // SourceInstructionLabel
            // 
            this.SourceInstructionLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.SourceInstructionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SourceInstructionLabel.ForeColor = System.Drawing.Color.Red;
            this.SourceInstructionLabel.Location = new System.Drawing.Point(260, 106);
            this.SourceInstructionLabel.Name = "SourceInstructionLabel";
            this.SourceInstructionLabel.Size = new System.Drawing.Size(379, 92);
            this.SourceInstructionLabel.TabIndex = 15;
            this.SourceInstructionLabel.Text = "The backup list is empty.\r\n\r\nSelect the folders or files that are to be backed up" +
    ".\r\nClick the\'Add folder\' or \'Add file\' buttons above.";
            this.SourceInstructionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AutorunLabel
            // 
            this.AutorunLabel.AutoSize = true;
            this.AutorunLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutorunLabel.ForeColor = System.Drawing.Color.Red;
            this.AutorunLabel.Location = new System.Drawing.Point(158, 32);
            this.AutorunLabel.Name = "AutorunLabel";
            this.AutorunLabel.Size = new System.Drawing.Size(35, 17);
            this.AutorunLabel.TabIndex = 24;
            this.AutorunLabel.Text = "OFF";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(752, 225);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 17);
            this.label7.TabIndex = 25;
            this.label7.Text = "Total size: ";
            // 
            // TotalSizeLabel
            // 
            this.TotalSizeLabel.AutoSize = true;
            this.TotalSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalSizeLabel.Location = new System.Drawing.Point(834, 226);
            this.TotalSizeLabel.Name = "TotalSizeLabel";
            this.TotalSizeLabel.Size = new System.Drawing.Size(54, 17);
            this.TotalSizeLabel.TabIndex = 26;
            this.TotalSizeLabel.Text = "999 XB";
            // 
            // PromptCheckBox
            // 
            this.PromptCheckBox.AutoSize = true;
            this.PromptCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PromptCheckBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PromptCheckBox.Location = new System.Drawing.Point(94, 98);
            this.PromptCheckBox.Name = "PromptCheckBox";
            this.PromptCheckBox.Size = new System.Drawing.Size(132, 17);
            this.PromptCheckBox.TabIndex = 1;
            this.PromptCheckBox.Text = "Suppress idiot prompts";
            this.PromptCheckBox.UseVisualStyleBackColor = true;
            this.PromptCheckBox.CheckedChanged += new System.EventHandler(this.PromptCheckBox_CheckedChanged);
            // 
            // CloseAfterBackupCheckBox
            // 
            this.CloseAfterBackupCheckBox.AutoCheck = false;
            this.CloseAfterBackupCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CloseAfterBackupCheckBox.Location = new System.Drawing.Point(12, 65);
            this.CloseAfterBackupCheckBox.Name = "CloseAfterBackupCheckBox";
            this.CloseAfterBackupCheckBox.Size = new System.Drawing.Size(147, 34);
            this.CloseAfterBackupCheckBox.TabIndex = 1;
            this.CloseAfterBackupCheckBox.Text = "Close after successful backup";
            this.CloseAfterBackupCheckBox.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.CloseAfterBackupCheckBox.UseVisualStyleBackColor = true;
            this.CloseAfterBackupCheckBox.CheckedChanged += new System.EventHandler(this.CloseAfterBackupCheckBox_CheckedChanged);
            // 
            // RunOnStartupCheckBox
            // 
            this.RunOnStartupCheckBox.AutoSize = true;
            this.RunOnStartupCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RunOnStartupCheckBox.Location = new System.Drawing.Point(12, 47);
            this.RunOnStartupCheckBox.Name = "RunOnStartupCheckBox";
            this.RunOnStartupCheckBox.Size = new System.Drawing.Size(122, 17);
            this.RunOnStartupCheckBox.TabIndex = 0;
            this.RunOnStartupCheckBox.Text = "Run at program start";
            this.RunOnStartupCheckBox.UseVisualStyleBackColor = true;
            this.RunOnStartupCheckBox.CheckedChanged += new System.EventHandler(this.RunOnStartupCheckBox_CheckedChanged);
            // 
            // AutoCloseLabel
            // 
            this.AutoCloseLabel.AutoSize = true;
            this.AutoCloseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AutoCloseLabel.ForeColor = System.Drawing.Color.Red;
            this.AutoCloseLabel.Location = new System.Drawing.Point(158, 49);
            this.AutoCloseLabel.Name = "AutoCloseLabel";
            this.AutoCloseLabel.Size = new System.Drawing.Size(35, 17);
            this.AutoCloseLabel.TabIndex = 24;
            this.AutoCloseLabel.Text = "OFF";
            // 
            // BackupModeGroupBox
            // 
            this.BackupModeGroupBox.Controls.Add(this.OverwriteRadioButton);
            this.BackupModeGroupBox.Controls.Add(this.PromptToOverwriteRadioButton);
            this.BackupModeGroupBox.Controls.Add(this.NewFolderRadioButton);
            this.BackupModeGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackupModeGroupBox.Location = new System.Drawing.Point(416, 298);
            this.BackupModeGroupBox.Name = "BackupModeGroupBox";
            this.BackupModeGroupBox.Size = new System.Drawing.Size(324, 100);
            this.BackupModeGroupBox.TabIndex = 7;
            this.BackupModeGroupBox.TabStop = false;
            this.BackupModeGroupBox.Text = "Backup mode options";
            // 
            // SchedulerGroupBox
            // 
            this.SchedulerGroupBox.Controls.Add(this.SchedulePanel);
            this.SchedulerGroupBox.Controls.Add(this.CloseAfterBackupCheckBox);
            this.SchedulerGroupBox.Controls.Add(this.ScheduleCheckBox);
            this.SchedulerGroupBox.Controls.Add(this.RunOnStartupCheckBox);
            this.SchedulerGroupBox.Controls.Add(this.label8);
            this.SchedulerGroupBox.Controls.Add(this.ResetSettingsButton);
            this.SchedulerGroupBox.Controls.Add(this.SetScheduleButton);
            this.SchedulerGroupBox.Controls.Add(this.NextRunLlabel);
            this.SchedulerGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SchedulerGroupBox.Location = new System.Drawing.Point(312, 33);
            this.SchedulerGroupBox.Name = "SchedulerGroupBox";
            this.SchedulerGroupBox.Size = new System.Drawing.Size(605, 110);
            this.SchedulerGroupBox.TabIndex = 8;
            this.SchedulerGroupBox.TabStop = false;
            this.SchedulerGroupBox.Text = "Scheduler";
            // 
            // SchedulePanel
            // 
            this.SchedulePanel.Controls.Add(this.ExpiryDateTimePicker);
            this.SchedulePanel.Controls.Add(this.FrequencyLabel);
            this.SchedulePanel.Controls.Add(this.FrequencyComboBox);
            this.SchedulePanel.Controls.Add(this.TimePicker);
            this.SchedulePanel.Controls.Add(this.DayComboBox);
            this.SchedulePanel.Controls.Add(this.TimeLabel);
            this.SchedulePanel.Controls.Add(this.ExpiresLabel);
            this.SchedulePanel.Controls.Add(this.DayDateLabel);
            this.SchedulePanel.Location = new System.Drawing.Point(184, 19);
            this.SchedulePanel.Name = "SchedulePanel";
            this.SchedulePanel.Size = new System.Drawing.Size(315, 45);
            this.SchedulePanel.TabIndex = 2;
            // 
            // ExpiryDateTimePicker
            // 
            this.ExpiryDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpiryDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ExpiryDateTimePicker.Location = new System.Drawing.Point(219, 19);
            this.ExpiryDateTimePicker.Name = "ExpiryDateTimePicker";
            this.ExpiryDateTimePicker.Size = new System.Drawing.Size(87, 20);
            this.ExpiryDateTimePicker.TabIndex = 7;
            // 
            // FrequencyLabel
            // 
            this.FrequencyLabel.AutoSize = true;
            this.FrequencyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FrequencyLabel.Location = new System.Drawing.Point(3, 4);
            this.FrequencyLabel.Name = "FrequencyLabel";
            this.FrequencyLabel.Size = new System.Drawing.Size(57, 13);
            this.FrequencyLabel.TabIndex = 1;
            this.FrequencyLabel.Text = "Frequency";
            // 
            // FrequencyComboBox
            // 
            this.FrequencyComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FrequencyComboBox.FormattingEnabled = true;
            this.FrequencyComboBox.Location = new System.Drawing.Point(6, 19);
            this.FrequencyComboBox.Name = "FrequencyComboBox";
            this.FrequencyComboBox.Size = new System.Drawing.Size(65, 21);
            this.FrequencyComboBox.TabIndex = 2;
            this.FrequencyComboBox.SelectedIndexChanged += new System.EventHandler(this.FrequencyComboBox_SelectedIndexChanged);
            // 
            // TimePicker
            // 
            this.TimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimePicker.Location = new System.Drawing.Point(144, 19);
            this.TimePicker.Name = "TimePicker";
            this.TimePicker.ShowUpDown = true;
            this.TimePicker.Size = new System.Drawing.Size(67, 20);
            this.TimePicker.TabIndex = 6;
            // 
            // DayComboBox
            // 
            this.DayComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DayComboBox.FormattingEnabled = true;
            this.DayComboBox.Items.AddRange(new object[] {
            "Hourly",
            "Daily",
            "Weekly",
            "Monthly"});
            this.DayComboBox.Location = new System.Drawing.Point(80, 19);
            this.DayComboBox.Name = "DayComboBox";
            this.DayComboBox.Size = new System.Drawing.Size(54, 21);
            this.DayComboBox.TabIndex = 4;
            // 
            // TimeLabel
            // 
            this.TimeLabel.AutoSize = true;
            this.TimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.Location = new System.Drawing.Point(144, 4);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(39, 13);
            this.TimeLabel.TabIndex = 5;
            this.TimeLabel.Text = "At time";
            // 
            // ExpiresLabel
            // 
            this.ExpiresLabel.AutoSize = true;
            this.ExpiresLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpiresLabel.Location = new System.Drawing.Point(219, 4);
            this.ExpiresLabel.Name = "ExpiresLabel";
            this.ExpiresLabel.Size = new System.Drawing.Size(41, 13);
            this.ExpiresLabel.TabIndex = 1;
            this.ExpiresLabel.Text = "Expires";
            // 
            // DayDateLabel
            // 
            this.DayDateLabel.AutoSize = true;
            this.DayDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DayDateLabel.Location = new System.Drawing.Point(80, 4);
            this.DayDateLabel.Name = "DayDateLabel";
            this.DayDateLabel.Size = new System.Drawing.Size(45, 13);
            this.DayDateLabel.TabIndex = 3;
            this.DayDateLabel.Text = "On date";
            // 
            // ScheduleCheckBox
            // 
            this.ScheduleCheckBox.AutoSize = true;
            this.ScheduleCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScheduleCheckBox.Location = new System.Drawing.Point(12, 23);
            this.ScheduleCheckBox.Name = "ScheduleCheckBox";
            this.ScheduleCheckBox.Size = new System.Drawing.Size(150, 17);
            this.ScheduleCheckBox.TabIndex = 0;
            this.ScheduleCheckBox.Text = "Start program on schedule";
            this.ScheduleCheckBox.UseVisualStyleBackColor = true;
            this.ScheduleCheckBox.CheckedChanged += new System.EventHandler(this.ScheduleCheckBox_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(187, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 17);
            this.label8.TabIndex = 32;
            this.label8.Text = "Next run at:";
            // 
            // ResetSettingsButton
            // 
            this.ResetSettingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetSettingsButton.Image = global::GotYourBackUp.Properties.Resources.restart_1;
            this.ResetSettingsButton.Location = new System.Drawing.Point(506, 65);
            this.ResetSettingsButton.Name = "ResetSettingsButton";
            this.ResetSettingsButton.Size = new System.Drawing.Size(89, 39);
            this.ResetSettingsButton.TabIndex = 17;
            this.ResetSettingsButton.Text = "Reset";
            this.ResetSettingsButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ResetSettingsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ResetSettingsButton.UseVisualStyleBackColor = true;
            this.ResetSettingsButton.Click += new System.EventHandler(this.ButtonClickHub);
            // 
            // SetScheduleButton
            // 
            this.SetScheduleButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetScheduleButton.Image = global::GotYourBackUp.Properties.Resources.config_date;
            this.SetScheduleButton.Location = new System.Drawing.Point(505, 19);
            this.SetScheduleButton.Name = "SetScheduleButton";
            this.SetScheduleButton.Size = new System.Drawing.Size(90, 41);
            this.SetScheduleButton.TabIndex = 2;
            this.SetScheduleButton.Text = "Set ";
            this.SetScheduleButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SetScheduleButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SetScheduleButton.UseVisualStyleBackColor = true;
            this.SetScheduleButton.Click += new System.EventHandler(this.ButtonClickHub);
            // 
            // NextRunLlabel
            // 
            this.NextRunLlabel.AutoSize = true;
            this.NextRunLlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NextRunLlabel.ForeColor = System.Drawing.Color.Blue;
            this.NextRunLlabel.Location = new System.Drawing.Point(274, 79);
            this.NextRunLlabel.Name = "NextRunLlabel";
            this.NextRunLlabel.Size = new System.Drawing.Size(35, 17);
            this.NextRunLlabel.TabIndex = 24;
            this.NextRunLlabel.Text = "OFF";
            // 
            // TestScheduleCheckBox
            // 
            this.TestScheduleCheckBox.AutoSize = true;
            this.TestScheduleCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestScheduleCheckBox.Location = new System.Drawing.Point(1063, 122);
            this.TestScheduleCheckBox.Name = "TestScheduleCheckBox";
            this.TestScheduleCheckBox.Size = new System.Drawing.Size(47, 17);
            this.TestScheduleCheckBox.TabIndex = 1;
            this.TestScheduleCheckBox.Text = "Test";
            this.TestScheduleCheckBox.UseVisualStyleBackColor = true;
            this.TestScheduleCheckBox.Visible = false;
            this.TestScheduleCheckBox.CheckedChanged += new System.EventHandler(this.TestScheduleCheckBox_CheckedChanged);
            // 
            // ScheduleLabel
            // 
            this.ScheduleLabel.AutoSize = true;
            this.ScheduleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScheduleLabel.ForeColor = System.Drawing.Color.Red;
            this.ScheduleLabel.Location = new System.Drawing.Point(158, 10);
            this.ScheduleLabel.Name = "ScheduleLabel";
            this.ScheduleLabel.Size = new System.Drawing.Size(35, 17);
            this.ScheduleLabel.TabIndex = 24;
            this.ScheduleLabel.Text = "OFF";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(11, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(127, 17);
            this.label12.TabIndex = 32;
            this.label12.Text = "Program schedule:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(11, 32);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(140, 17);
            this.label13.TabIndex = 32;
            this.label13.Text = "Run backup  at start:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(11, 49);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(130, 17);
            this.label14.TabIndex = 32;
            this.label14.Text = "Close after backup:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.AutorunLabel);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.AutoCloseLabel);
            this.panel1.Controls.Add(this.ScheduleLabel);
            this.panel1.Location = new System.Drawing.Point(1006, 274);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(222, 81);
            this.panel1.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(1003, 82);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 17);
            this.label9.TabIndex = 32;
            this.label9.Text = "Backup mode:";
            // 
            // BackupModeLabel
            // 
            this.BackupModeLabel.AutoSize = true;
            this.BackupModeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackupModeLabel.ForeColor = System.Drawing.Color.Blue;
            this.BackupModeLabel.Location = new System.Drawing.Point(1113, 82);
            this.BackupModeLabel.Name = "BackupModeLabel";
            this.BackupModeLabel.Size = new System.Drawing.Size(202, 17);
            this.BackupModeLabel.TabIndex = 24;
            this.BackupModeLabel.Text = "New folder with date-time suffix";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(737, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 15);
            this.label1.TabIndex = 34;
            this.label1.Text = "A Green Lantern Group app";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TaskSelectorGroupBox
            // 
            this.TaskSelectorGroupBox.Controls.Add(this.NumTaskslabel);
            this.TaskSelectorGroupBox.Controls.Add(this.TaskSelectorInfoLabel);
            this.TaskSelectorGroupBox.Controls.Add(this.AddTaskButton);
            this.TaskSelectorGroupBox.Controls.Add(this.TaskComboBox);
            this.TaskSelectorGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskSelectorGroupBox.Location = new System.Drawing.Point(4, 147);
            this.TaskSelectorGroupBox.Name = "TaskSelectorGroupBox";
            this.TaskSelectorGroupBox.Size = new System.Drawing.Size(429, 79);
            this.TaskSelectorGroupBox.TabIndex = 37;
            this.TaskSelectorGroupBox.TabStop = false;
            this.TaskSelectorGroupBox.Text = "Task selector";
            // 
            // NumTaskslabel
            // 
            this.NumTaskslabel.AutoSize = true;
            this.NumTaskslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumTaskslabel.ForeColor = System.Drawing.Color.Black;
            this.NumTaskslabel.Location = new System.Drawing.Point(11, 58);
            this.NumTaskslabel.Name = "NumTaskslabel";
            this.NumTaskslabel.Size = new System.Drawing.Size(70, 13);
            this.NumTaskslabel.TabIndex = 1;
            this.NumTaskslabel.Text = "No. of tasks: ";
            // 
            // TaskSelectorInfoLabel
            // 
            this.TaskSelectorInfoLabel.AutoSize = true;
            this.TaskSelectorInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskSelectorInfoLabel.ForeColor = System.Drawing.Color.Red;
            this.TaskSelectorInfoLabel.Location = new System.Drawing.Point(110, 58);
            this.TaskSelectorInfoLabel.Name = "TaskSelectorInfoLabel";
            this.TaskSelectorInfoLabel.Size = new System.Drawing.Size(161, 13);
            this.TaskSelectorInfoLabel.TabIndex = 1;
            this.TaskSelectorInfoLabel.Text = "Choose the task to make \'active\'";
            // 
            // AddTaskButton
            // 
            this.AddTaskButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddTaskButton.Image = global::GotYourBackUp.Properties.Resources.add_task;
            this.AddTaskButton.Location = new System.Drawing.Point(277, 20);
            this.AddTaskButton.Name = "AddTaskButton";
            this.AddTaskButton.Size = new System.Drawing.Size(146, 36);
            this.AddTaskButton.TabIndex = 1;
            this.AddTaskButton.Text = "Add a new task";
            this.AddTaskButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.AddTaskButton.UseVisualStyleBackColor = true;
            this.AddTaskButton.Click += new System.EventHandler(this.ButtonClickHub);
            // 
            // TaskComboBox
            // 
            this.TaskComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskComboBox.FormattingEnabled = true;
            this.TaskComboBox.Location = new System.Drawing.Point(8, 27);
            this.TaskComboBox.Name = "TaskComboBox";
            this.TaskComboBox.Size = new System.Drawing.Size(263, 24);
            this.TaskComboBox.TabIndex = 0;
            this.TaskComboBox.SelectedIndexChanged += new System.EventHandler(this.TaskComboBox_SelectedIndexChanged);
            // 
            // ActiveTaskPanel
            // 
            this.ActiveTaskPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ActiveTaskPanel.Controls.Add(this.DescriptionTextBox);
            this.ActiveTaskPanel.Controls.Add(this.label16);
            this.ActiveTaskPanel.Controls.Add(this.AddFolderButton);
            this.ActiveTaskPanel.Controls.Add(this.BackupButton);
            this.ActiveTaskPanel.Controls.Add(this.AddFileButton);
            this.ActiveTaskPanel.Controls.Add(this.BackupFolderButton);
            this.ActiveTaskPanel.Controls.Add(this.SourceInstructionLabel);
            this.ActiveTaskPanel.Controls.Add(this.SelectedSizeLabel);
            this.ActiveTaskPanel.Controls.Add(this.TotalSizeLabel);
            this.ActiveTaskPanel.Controls.Add(this.BackupFolderTextBox);
            this.ActiveTaskPanel.Controls.Add(this.label3);
            this.ActiveTaskPanel.Controls.Add(this.label7);
            this.ActiveTaskPanel.Controls.Add(this.BackupModeGroupBox);
            this.ActiveTaskPanel.Controls.Add(this.ClearListButton);
            this.ActiveTaskPanel.Controls.Add(this.OpenBackupFolderButton);
            this.ActiveTaskPanel.Controls.Add(this.dataGridView1);
            this.ActiveTaskPanel.Location = new System.Drawing.Point(3, 29);
            this.ActiveTaskPanel.Name = "ActiveTaskPanel";
            this.ActiveTaskPanel.Size = new System.Drawing.Size(892, 408);
            this.ActiveTaskPanel.TabIndex = 35;
            // 
            // DescriptionTextBox
            // 
            this.DescriptionTextBox.ForeColor = System.Drawing.Color.Gray;
            this.DescriptionTextBox.Location = new System.Drawing.Point(11, 298);
            this.DescriptionTextBox.Multiline = true;
            this.DescriptionTextBox.Name = "DescriptionTextBox";
            this.DescriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DescriptionTextBox.Size = new System.Drawing.Size(399, 100);
            this.DescriptionTextBox.TabIndex = 28;
            this.DescriptionTextBox.Text = "Comments for this backup (optional)";
            this.DescriptionTextBox.Enter += new System.EventHandler(this.DescriptionTextBox_Enter);
            this.DescriptionTextBox.Leave += new System.EventHandler(this.DescriptionTextBox_Leave);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(719, 228);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(27, 13);
            this.label16.TabIndex = 27;
            this.label16.Text = "from";
            // 
            // SelectedSizeLabel
            // 
            this.SelectedSizeLabel.AutoSize = true;
            this.SelectedSizeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectedSizeLabel.Location = new System.Drawing.Point(655, 226);
            this.SelectedSizeLabel.Name = "SelectedSizeLabel";
            this.SelectedSizeLabel.Size = new System.Drawing.Size(54, 17);
            this.SelectedSizeLabel.TabIndex = 26;
            this.SelectedSizeLabel.Text = "999 XB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(583, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Selected: ";
            // 
            // ClearListButton
            // 
            this.ClearListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearListButton.Image = global::GotYourBackUp.Properties.Resources.remove;
            this.ClearListButton.Location = new System.Drawing.Point(737, 6);
            this.ClearListButton.Name = "ClearListButton";
            this.ClearListButton.Size = new System.Drawing.Size(154, 40);
            this.ClearListButton.TabIndex = 17;
            this.ClearListButton.Text = "Clear backup list";
            this.ClearListButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ClearListButton.UseVisualStyleBackColor = true;
            this.ClearListButton.Click += new System.EventHandler(this.ButtonClickHub);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 39;
            this.label2.Text = "Active task:";
            // 
            // ActiveTaskNameLabel
            // 
            this.ActiveTaskNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActiveTaskNameLabel.ForeColor = System.Drawing.Color.Red;
            this.ActiveTaskNameLabel.Location = new System.Drawing.Point(104, 8);
            this.ActiveTaskNameLabel.Name = "ActiveTaskNameLabel";
            this.ActiveTaskNameLabel.Size = new System.Drawing.Size(272, 21);
            this.ActiveTaskNameLabel.TabIndex = 39;
            this.ActiveTaskNameLabel.Text = "<task name>";
            // 
            // ActiveTaskManagerGroupBox
            // 
            this.ActiveTaskManagerGroupBox.Controls.Add(this.TaskManagerInfoLabel);
            this.ActiveTaskManagerGroupBox.Controls.Add(this.DeleteTaskButton);
            this.ActiveTaskManagerGroupBox.Controls.Add(this.RenameTaskButton);
            this.ActiveTaskManagerGroupBox.Controls.Add(this.SaveTaskButton);
            this.ActiveTaskManagerGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActiveTaskManagerGroupBox.Location = new System.Drawing.Point(439, 147);
            this.ActiveTaskManagerGroupBox.Name = "ActiveTaskManagerGroupBox";
            this.ActiveTaskManagerGroupBox.Size = new System.Drawing.Size(475, 79);
            this.ActiveTaskManagerGroupBox.TabIndex = 40;
            this.ActiveTaskManagerGroupBox.TabStop = false;
            this.ActiveTaskManagerGroupBox.Text = "Active task manager";
            // 
            // TaskManagerInfoLabel
            // 
            this.TaskManagerInfoLabel.AutoSize = true;
            this.TaskManagerInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskManagerInfoLabel.ForeColor = System.Drawing.Color.Red;
            this.TaskManagerInfoLabel.Location = new System.Drawing.Point(6, 58);
            this.TaskManagerInfoLabel.Name = "TaskManagerInfoLabel";
            this.TaskManagerInfoLabel.Size = new System.Drawing.Size(310, 13);
            this.TaskManagerInfoLabel.TabIndex = 1;
            this.TaskManagerInfoLabel.Text = "These actions and the backup will apply to the active task only. ";
            // 
            // DeleteTaskButton
            // 
            this.DeleteTaskButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteTaskButton.Image = global::GotYourBackUp.Properties.Resources.delete_task;
            this.DeleteTaskButton.Location = new System.Drawing.Point(322, 20);
            this.DeleteTaskButton.Name = "DeleteTaskButton";
            this.DeleteTaskButton.Size = new System.Drawing.Size(146, 36);
            this.DeleteTaskButton.TabIndex = 0;
            this.DeleteTaskButton.Text = "Delete this task";
            this.DeleteTaskButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DeleteTaskButton.UseVisualStyleBackColor = true;
            this.DeleteTaskButton.Click += new System.EventHandler(this.ButtonClickHub);
            // 
            // RenameTaskButton
            // 
            this.RenameTaskButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RenameTaskButton.Image = global::GotYourBackUp.Properties.Resources.rename_task;
            this.RenameTaskButton.Location = new System.Drawing.Point(6, 20);
            this.RenameTaskButton.Name = "RenameTaskButton";
            this.RenameTaskButton.Size = new System.Drawing.Size(152, 36);
            this.RenameTaskButton.TabIndex = 0;
            this.RenameTaskButton.Text = "Rename this task";
            this.RenameTaskButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.RenameTaskButton.UseVisualStyleBackColor = true;
            this.RenameTaskButton.Click += new System.EventHandler(this.ButtonClickHub);
            // 
            // SaveTaskButton
            // 
            this.SaveTaskButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveTaskButton.Image = global::GotYourBackUp.Properties.Resources.add_task_2;
            this.SaveTaskButton.Location = new System.Drawing.Point(164, 20);
            this.SaveTaskButton.Name = "SaveTaskButton";
            this.SaveTaskButton.Size = new System.Drawing.Size(152, 36);
            this.SaveTaskButton.TabIndex = 0;
            this.SaveTaskButton.Text = "Save task profile";
            this.SaveTaskButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SaveTaskButton.UseVisualStyleBackColor = true;
            this.SaveTaskButton.Click += new System.EventHandler(this.ButtonClickHub);
            // 
            // ActiveTaskInfoLabel
            // 
            this.ActiveTaskInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ActiveTaskInfoLabel.ForeColor = System.Drawing.Color.Red;
            this.ActiveTaskInfoLabel.Location = new System.Drawing.Point(447, 228);
            this.ActiveTaskInfoLabel.Name = "ActiveTaskInfoLabel";
            this.ActiveTaskInfoLabel.Size = new System.Drawing.Size(457, 19);
            this.ActiveTaskInfoLabel.TabIndex = 1;
            this.ActiveTaskInfoLabel.Text = "You can save multiple \'backup tasks\' each with its own settings.  Only the active" +
    " task will run.";
            // 
            // RenameActiveTaskTextBox
            // 
            this.RenameActiveTaskTextBox.Location = new System.Drawing.Point(82, 59);
            this.RenameActiveTaskTextBox.Name = "RenameActiveTaskTextBox";
            this.RenameActiveTaskTextBox.Size = new System.Drawing.Size(218, 20);
            this.RenameActiveTaskTextBox.TabIndex = 41;
            // 
            // ConfirmNameChangeButton
            // 
            this.ConfirmNameChangeButton.Location = new System.Drawing.Point(148, 139);
            this.ConfirmNameChangeButton.Name = "ConfirmNameChangeButton";
            this.ConfirmNameChangeButton.Size = new System.Drawing.Size(73, 28);
            this.ConfirmNameChangeButton.TabIndex = 42;
            this.ConfirmNameChangeButton.Text = "Confirm";
            this.ConfirmNameChangeButton.UseVisualStyleBackColor = true;
            this.ConfirmNameChangeButton.Click += new System.EventHandler(this.ButtonClickHub);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Remove";
            this.dataGridViewImageColumn1.Image = global::GotYourBackUp.Properties.Resources.remove;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.Width = 60;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.HeaderText = "Open";
            this.dataGridViewImageColumn2.Image = global::GotYourBackUp.Properties.Resources.eye;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn2.ToolTipText = "Open folder or file";
            this.dataGridViewImageColumn2.Width = 40;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 33);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(79, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // RenameTaskPanel
            // 
            this.RenameTaskPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.RenameTaskPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.RenameTaskPanel.Controls.Add(this.label11);
            this.RenameTaskPanel.Controls.Add(this.CancelNameChangeButton);
            this.RenameTaskPanel.Controls.Add(this.ConfirmNameChangeButton);
            this.RenameTaskPanel.Controls.Add(this.textBox1);
            this.RenameTaskPanel.Controls.Add(this.RenameActiveTaskTextBox);
            this.RenameTaskPanel.Controls.Add(this.label15);
            this.RenameTaskPanel.Controls.Add(this.NewTaskNameLabel);
            this.RenameTaskPanel.Controls.Add(this.RenameTaskLabel);
            this.RenameTaskPanel.Location = new System.Drawing.Point(944, 371);
            this.RenameTaskPanel.Name = "RenameTaskPanel";
            this.RenameTaskPanel.Size = new System.Drawing.Size(323, 199);
            this.RenameTaskPanel.TabIndex = 43;
            this.RenameTaskPanel.Visible = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 157);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 13);
            this.label11.TabIndex = 44;
            this.label11.Text = "Location 332, 244";
            this.label11.Visible = false;
            // 
            // CancelNameChangeButton
            // 
            this.CancelNameChangeButton.Location = new System.Drawing.Point(227, 140);
            this.CancelNameChangeButton.Name = "CancelNameChangeButton";
            this.CancelNameChangeButton.Size = new System.Drawing.Size(73, 27);
            this.CancelNameChangeButton.TabIndex = 14;
            this.CancelNameChangeButton.Text = "Cancel";
            this.CancelNameChangeButton.UseVisualStyleBackColor = true;
            this.CancelNameChangeButton.Click += new System.EventHandler(this.ButtonClickHub);
            // 
            // NewTaskNameLabel
            // 
            this.NewTaskNameLabel.AutoSize = true;
            this.NewTaskNameLabel.Location = new System.Drawing.Point(15, 62);
            this.NewTaskNameLabel.Name = "NewTaskNameLabel";
            this.NewTaskNameLabel.Size = new System.Drawing.Size(64, 13);
            this.NewTaskNameLabel.TabIndex = 10;
            this.NewTaskNameLabel.Text = "New name: ";
            // 
            // RenameTaskLabel
            // 
            this.RenameTaskLabel.AutoSize = true;
            this.RenameTaskLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RenameTaskLabel.Location = new System.Drawing.Point(15, 12);
            this.RenameTaskLabel.Name = "RenameTaskLabel";
            this.RenameTaskLabel.Size = new System.Drawing.Size(214, 17);
            this.RenameTaskLabel.TabIndex = 9;
            this.RenameTaskLabel.Text = "Rename Active Backup Task";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ActiveTaskTabPage);
            this.tabControl1.Controls.Add(this.LoggingTabPage);
            this.tabControl1.Controls.Add(this.SettingsTabPage);
            this.tabControl1.Location = new System.Drawing.Point(8, 233);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(906, 472);
            this.tabControl1.TabIndex = 44;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // ActiveTaskTabPage
            // 
            this.ActiveTaskTabPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ActiveTaskTabPage.Controls.Add(this.label2);
            this.ActiveTaskTabPage.Controls.Add(this.ActiveTaskNameLabel);
            this.ActiveTaskTabPage.Controls.Add(this.ActiveTaskPanel);
            this.ActiveTaskTabPage.Location = new System.Drawing.Point(4, 22);
            this.ActiveTaskTabPage.Name = "ActiveTaskTabPage";
            this.ActiveTaskTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ActiveTaskTabPage.Size = new System.Drawing.Size(898, 446);
            this.ActiveTaskTabPage.TabIndex = 0;
            this.ActiveTaskTabPage.Text = "Active Backup Task";
            // 
            // LoggingTabPage
            // 
            this.LoggingTabPage.Controls.Add(this.DeleteLogsButton);
            this.LoggingTabPage.Controls.Add(this.checkBox2);
            this.LoggingTabPage.Controls.Add(this.richTextBox1);
            this.LoggingTabPage.Location = new System.Drawing.Point(4, 22);
            this.LoggingTabPage.Name = "LoggingTabPage";
            this.LoggingTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.LoggingTabPage.Size = new System.Drawing.Size(898, 446);
            this.LoggingTabPage.TabIndex = 1;
            this.LoggingTabPage.Text = "Log file";
            this.LoggingTabPage.UseVisualStyleBackColor = true;
            // 
            // DeleteLogsButton
            // 
            this.DeleteLogsButton.Location = new System.Drawing.Point(805, 58);
            this.DeleteLogsButton.Name = "DeleteLogsButton";
            this.DeleteLogsButton.Size = new System.Drawing.Size(75, 38);
            this.DeleteLogsButton.TabIndex = 2;
            this.DeleteLogsButton.Text = "Delete log files";
            this.DeleteLogsButton.UseVisualStyleBackColor = true;
            this.DeleteLogsButton.Click += new System.EventHandler(this.ButtonClickHub);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Enabled = false;
            this.checkBox2.Location = new System.Drawing.Point(805, 19);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(79, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Text = "Logging off";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(3, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(787, 430);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // SettingsTabPage
            // 
            this.SettingsTabPage.Controls.Add(this.label10);
            this.SettingsTabPage.Controls.Add(this.label6);
            this.SettingsTabPage.Controls.Add(this.LogFolderPathLinkLabel);
            this.SettingsTabPage.Controls.Add(this.SelectLogFolderButton);
            this.SettingsTabPage.Controls.Add(this.label4);
            this.SettingsTabPage.Controls.Add(this.checkBox1);
            this.SettingsTabPage.Location = new System.Drawing.Point(4, 22);
            this.SettingsTabPage.Name = "SettingsTabPage";
            this.SettingsTabPage.Size = new System.Drawing.Size(898, 446);
            this.SettingsTabPage.TabIndex = 2;
            this.SettingsTabPage.Text = "Settings";
            this.SettingsTabPage.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(112, 131);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 8;
            this.label10.Text = "TODO ....";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Logging detail";
            // 
            // LogFolderPathLinkLabel
            // 
            this.LogFolderPathLinkLabel.AutoSize = true;
            this.LogFolderPathLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogFolderPathLinkLabel.Location = new System.Drawing.Point(283, 33);
            this.LogFolderPathLinkLabel.Name = "LogFolderPathLinkLabel";
            this.LogFolderPathLinkLabel.Size = new System.Drawing.Size(72, 17);
            this.LogFolderPathLinkLabel.TabIndex = 6;
            this.LogFolderPathLinkLabel.TabStop = true;
            this.LogFolderPathLinkLabel.Text = "linkLabel1";
            this.LogFolderPathLinkLabel.Click += new System.EventHandler(this.LogFolderPathLinkLabel_Click);
            // 
            // SelectLogFolderButton
            // 
            this.SelectLogFolderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectLogFolderButton.Image = global::GotYourBackUp.Properties.Resources.folder;
            this.SelectLogFolderButton.Location = new System.Drawing.Point(22, 25);
            this.SelectLogFolderButton.Name = "SelectLogFolderButton";
            this.SelectLogFolderButton.Size = new System.Drawing.Size(83, 33);
            this.SelectLogFolderButton.TabIndex = 5;
            this.SelectLogFolderButton.Text = "Select";
            this.SelectLogFolderButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SelectLogFolderButton.UseVisualStyleBackColor = true;
            this.SelectLogFolderButton.Click += new System.EventHandler(this.ButtonClickHub);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(111, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Log file location";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(114, 74);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(124, 17);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "Delete log file on exit";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Enabled = false;
            this.label15.Location = new System.Drawing.Point(15, 96);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 13);
            this.label15.TabIndex = 10;
            this.label15.Text = "Dscription: ";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(82, 93);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(218, 20);
            this.textBox1.TabIndex = 41;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(919, 730);
            this.Controls.Add(this.RenameTaskPanel);
            this.Controls.Add(this.ActiveTaskInfoLabel);
            this.Controls.Add(this.TaskSelectorGroupBox);
            this.Controls.Add(this.PromptCheckBox);
            this.Controls.Add(this.ActiveTaskManagerGroupBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.BackupModeLabel);
            this.Controls.Add(this.TestScheduleCheckBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SchedulerGroupBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BackupListDataGridView);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.Text = "Got your back up";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BackupListDataGridView)).EndInit();
            this.BackupModeGroupBox.ResumeLayout(false);
            this.BackupModeGroupBox.PerformLayout();
            this.SchedulerGroupBox.ResumeLayout(false);
            this.SchedulerGroupBox.PerformLayout();
            this.SchedulePanel.ResumeLayout(false);
            this.SchedulePanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.TaskSelectorGroupBox.ResumeLayout(false);
            this.TaskSelectorGroupBox.PerformLayout();
            this.ActiveTaskPanel.ResumeLayout(false);
            this.ActiveTaskPanel.PerformLayout();
            this.ActiveTaskManagerGroupBox.ResumeLayout(false);
            this.ActiveTaskManagerGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.RenameTaskPanel.ResumeLayout(false);
            this.RenameTaskPanel.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ActiveTaskTabPage.ResumeLayout(false);
            this.ActiveTaskTabPage.PerformLayout();
            this.LoggingTabPage.ResumeLayout(false);
            this.LoggingTabPage.PerformLayout();
            this.SettingsTabPage.ResumeLayout(false);
            this.SettingsTabPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackupFolderButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button BackupButton;
        private System.Windows.Forms.RadioButton NewFolderRadioButton;
        private System.Windows.Forms.RadioButton PromptToOverwriteRadioButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AddFolderButton;
        private System.Windows.Forms.Button AddFileButton;
        private System.Windows.Forms.TextBox BackupFolderTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem printToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem printPreviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button ResetSettingsButton;
        private System.Windows.Forms.DataGridView BackupListDataGridView;
        private System.Windows.Forms.DataGridViewCheckBoxColumn select;
        private System.Windows.Forms.DataGridViewImageColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn path;
        private System.Windows.Forms.Button ClearListButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button OpenBackupFolderButton;
        private System.Windows.Forms.RadioButton OverwriteRadioButton;
        private System.Windows.Forms.Label SourceInstructionLabel;
        private System.Windows.Forms.Label AutorunLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label TotalSizeLabel;
        private System.Windows.Forms.CheckBox CloseAfterBackupCheckBox;
        private System.Windows.Forms.CheckBox RunOnStartupCheckBox;
        private System.Windows.Forms.Button SetScheduleButton;
        private System.Windows.Forms.Label AutoCloseLabel;
        private System.Windows.Forms.GroupBox BackupModeGroupBox;
        private System.Windows.Forms.GroupBox SchedulerGroupBox;
        private System.Windows.Forms.ComboBox FrequencyComboBox;
        private System.Windows.Forms.DateTimePicker ExpiryDateTimePicker;
        private System.Windows.Forms.CheckBox ScheduleCheckBox;
        private System.Windows.Forms.DateTimePicker TimePicker;
        private System.Windows.Forms.Label ExpiresLabel;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label FrequencyLabel;
        private System.Windows.Forms.ComboBox DayComboBox;
        private System.Windows.Forms.Label DayDateLabel;
        private System.Windows.Forms.Label ScheduleLabel;
        private System.Windows.Forms.Panel SchedulePanel;
        private System.Windows.Forms.CheckBox TestScheduleCheckBox;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label BackupModeLabel;
        private System.Windows.Forms.Label NextRunLlabel;
        private System.Windows.Forms.CheckBox PromptCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox TaskSelectorGroupBox;
        private System.Windows.Forms.Button AddTaskButton;
        private System.Windows.Forms.ComboBox TaskComboBox;
        private System.Windows.Forms.Panel ActiveTaskPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SaveTaskButton;
        private System.Windows.Forms.Button RenameTaskButton;
        private System.Windows.Forms.Button DeleteTaskButton;
        private System.Windows.Forms.Label ActiveTaskNameLabel;
        private System.Windows.Forms.GroupBox ActiveTaskManagerGroupBox;
        private System.Windows.Forms.Label NumTaskslabel;
        private System.Windows.Forms.Label TaskSelectorInfoLabel;
        private System.Windows.Forms.Label ActiveTaskInfoLabel;
        private System.Windows.Forms.TextBox RenameActiveTaskTextBox;
        private System.Windows.Forms.Button ConfirmNameChangeButton;
        private System.Windows.Forms.Panel RenameTaskPanel;
        private System.Windows.Forms.Button CancelNameChangeButton;
        private System.Windows.Forms.Label NewTaskNameLabel;
        private System.Windows.Forms.Label RenameTaskLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label TaskManagerInfoLabel;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ActiveTaskTabPage;
        private System.Windows.Forms.TabPage LoggingTabPage;
        private System.Windows.Forms.TabPage SettingsTabPage;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.LinkLabel LogFolderPathLinkLabel;
        private System.Windows.Forms.Button SelectLogFolderButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewCheckBoxColumn selectColumn;
        private System.Windows.Forms.DataGridViewImageColumn typeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pathColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sizeColumn;
        private System.Windows.Forms.DataGridViewImageColumn removeColumn;
        private System.Windows.Forms.DataGridViewImageColumn openColumn;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label SelectedSizeLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_backupPath;
        private System.Windows.Forms.ToolStripMenuItem resetToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem newtaskToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.Button DeleteLogsButton;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.ToolStripMenuItem logsToolStripMenuItem;
        private System.Windows.Forms.TextBox DescriptionTextBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label15;
    }
}

