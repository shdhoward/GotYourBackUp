using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.IO;



namespace GotYourBackUp
{
    public class SourceItem
    {
        public bool IsSelected  { get; set; }       //item is selected (or not) for backup
        public bool IsFolder { get; set; }          //item to be backed up is folder (or file)
        public string Path  { get; set; }           //path to item
        //public long ByteSize  { get; set; }           //size in bytes

        public string ErrorMessage  { get; set; }

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
            //this.ByteSize = GetPathSize();
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
            myFileDialog.Multiselect = false;
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
            //http://www.devcurry.com/2010/07/calculate-size-of-folderdirectory-using.html
            // Enumerate all the files
            long totalSize = dInfo.EnumerateFiles()
                         .Sum(file => file.Length);

            // If Subdirectories are to be included
            if (includeSubDir)
            {
                // Enumerate all sub-directories
                totalSize += dInfo.EnumerateDirectories()
                         .Sum(dir => DirectorySize(dir, true));
            }
            return totalSize;
        }

    }
}
