using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Xml.Serialization;
using System.Diagnostics;
using System.Windows.Forms;


namespace GotYourBackUp
{
    public class Backup
    {
        #region properties and declarations

        public string XmlFile { get; set; }
        public string LogFileDirectory  { get; set; }
        public bool RunOnStartup { get; set; }
        public bool CloseAfterBackup { get; set; }
        public bool IdiotPrompt { get; set; }
        public bool ScheduleIsSet { get; set; }
        public string Frequency { get; set; }
        public string DayDate { get; set; }
        public DateTime SchedTime { get; set; }
        public DateTime Expiry { get; set; }
        public List<BackupTask> TaskList {get; set;}

        private XmlSerializer mySerialiser =  new XmlSerializer(typeof(Backup));

        #endregion properties and declarations

        //constructor
        public  Backup()
        {
            XmlFile = "";
            LogFileDirectory = "";
            TaskList = new List<BackupTask>();

            RunOnStartup = false;
            CloseAfterBackup = false;
            IdiotPrompt = true;
            ScheduleIsSet = false;
            Frequency = "";
            DayDate = "";
            SchedTime = DateTime.MinValue;
            Expiry = DateTime.MinValue;
        }

        // public methods
        public void AddNewTask(string taskName)
        {
            BackupTask newTask = new BackupTask();
            newTask.Name = taskName;

            if (taskName == "")
                newTask.Name = "Task #" + ((int)TaskList.Count + 1).ToString();

            foreach (BackupTask task in TaskList)
            {
                if (task.Name == newTask.Name)
                {
                    newTask.Name = newTask.Name + " (x)";
                }
            }
            this.TaskList.Add(newTask); 
        }

        public Backup GetInfo()
        {
            return ReadXml();
        }

        public void SaveInfo()
        {
            WriteXml(this);
        }

        // private methods
        private Backup ReadXml()
        {
            Backup myBackup = new Backup();
            FileStream myFileStream = new FileStream(XmlFile, FileMode.Open);
            // Call the Deserialize method and cast to the object type.
            myBackup = (Backup)mySerialiser.Deserialize(myFileStream);
            myFileStream.Close();
            return myBackup;
        }

        private void WriteXml(Backup myBackup)
        {
            //http://msdn.microsoft.com/en-us/library/ekw4dh3f.aspx
            //http://codesamplez.com/programming/serialize-deserialize-c-sharp-objects
            StreamWriter myWriter = new StreamWriter(XmlFile);
            mySerialiser.Serialize(myWriter, myBackup);
            myWriter.Close();
        }

    }

    public class BackupTask
    {
        //public string xmlFile { get; set; }
        public string Name { get; set; }
        public List<SourceItem> SourceItems { get; set; }
        public string BackupLocation { get; set; }
        public string CopyMode { get; set; }
        public bool IsActive { get; set; }

        //contructor
        public BackupTask()
        {
            SourceItems = new List<SourceItem>();
            BackupLocation = "";
            CopyMode = "";
            IsActive = true;
        }

        public void Rename (string newName)
        {
            this.Name = newName;
        }
    }

    public class SourceItem
    {
        public bool IsSelected { get; set; }       //item is selected (or not) for backup
        public bool IsFolder { get; set; }          //item to be backed up is folder (or file)
        public string Path { get; set; }           //path to item
        //public long ByteSize  { get; set; }           //size in bytes

        public string ErrorMessage { get; set; }

        private FolderBrowserDialog myFolderDialog = new FolderBrowserDialog();
        private OpenFileDialog myFileDialog = new OpenFileDialog();

        //constructor
        public SourceItem()
        {
            IsFolder = true;
            Path = "";
            //ByteSize = 0;
            IsSelected = true;
            ErrorMessage = "";
        }

        //public methods
        public void GetPath()
        {
            GetSourcePath();
        }

        public long ByteSize()
        {
            return GetPathSize();
        }


        //private methods
        private void GetSourcePath()
        {
            Path = "";
            if (IsFolder)
                Path = GetFolderPath();
            else
                Path = GetFilePath();

        }

        private string GetFolderPath()
        {
            string path = "";
            try
            {
                myFolderDialog.RootFolder = Environment.SpecialFolder.MyComputer;
                //myFolderDialog.SelectedPath = initialDirectory;
                path = (myFolderDialog.ShowDialog() == DialogResult.OK) ? myFolderDialog.SelectedPath : null;
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.ToString();
            }
            return path;

        }

        private string GetFilePath()
        {
            string path = "";
            myFileDialog.Multiselect = false ;
            myFileDialog.Title = "Browse to select a single file";
            myFileDialog.Filter = "All files (*.*) | *.*";
            //openFileDialog1.InitialDirectory = initialDirectory;
            path = (myFileDialog.ShowDialog() == DialogResult.OK) ? myFileDialog.FileName : null;
            return path;
        }

        private long GetPathSize()
        {
            long myItemSizeBytes = 0;
            if (this.IsFolder)
            {
                DirectoryInfo dirInfo = new DirectoryInfo(this.Path);


                // set bool parameter to false if you
                // do not want to include subdirectories.
                myItemSizeBytes = DirectorySize(dirInfo, true);
            }
            else
            {
                FileInfo fileInfo = new FileInfo(this.Path);
                myItemSizeBytes = fileInfo.Length;
            }
            return myItemSizeBytes;
        }

        static long DirectorySize(DirectoryInfo dInfo, bool includeSubDir)
        {
            long totalSize = 0;
            try
            {
                //http://www.devcurry.com/2010/07/calculate-size-of-folderdirectory-using.html
                // Enumerate all the files
                totalSize = dInfo.EnumerateFiles()
                             .Sum(file => file.Length);

                // If Subdirectories are to be included
                if (includeSubDir)
                {
                    // Enumerate all sub-directories
                    totalSize += dInfo.EnumerateDirectories()
                             .Sum(dir => DirectorySize(dir, true));
                }
                
            }
            catch
            {
                
            }
            return totalSize;
        }

    }


}
