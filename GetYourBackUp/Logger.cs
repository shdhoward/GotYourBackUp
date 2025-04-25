using System;
using System.Windows.Forms;
using System.IO;


namespace GotYourBackUp
{
    public class Logger
    {
        public string LogFileDirectory { get; set; }
        public string LogFileName { get; set; }
        public string LogFilePath { get; private set; }
        public bool LoggingIsActive{ get; private set; }

        private string logFilePath;
        private string tempDir = @"C:\\temp";

        public Logger()
        {
            LogFileDirectory = "";
            LogFileName = "GYBU_Logfile_datetime.txt";
            LogFilePath = ""; 
            LoggingIsActive = false;
       }

        public void MakeLogFile()
        {
            if (LogFileDirectory == "")
                return;

            try
            {
                if (!Directory.Exists(LogFileDirectory))
                    Directory.CreateDirectory(LogFileDirectory);

                LoggingIsActive = true;
            }
            catch
            {
                MessageBox.Show("Log file directory could not be created.\nLogging has been disabled.",
                                "Got Your Back Up?", MessageBoxButtons.OK,  MessageBoxIcon.Exclamation);
            }

            logFilePath = Path.Combine( LogFileDirectory, LogFileName);
            string datetime = DateTime.Now.ToString("yyyy-MM-dd-HHmmss", System.Globalization.CultureInfo.InvariantCulture);

            LogFilePath = logFilePath.Replace("datetime", datetime);

            try
            {
                System.IO.StreamWriter writer = new System.IO.StreamWriter(LogFilePath, true);
                writer.Close();
            }
            catch
            {
                MessageBox.Show("Log file could not be created.\nLogging has been disabled.",
                                "Got Your Back Up?", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                LoggingIsActive = false;
            }
        }

        public void WriteToLog(string message, int level)
        {
            string logMessage = "";

            if (!LoggingIsActive && level > 1)   //do not log levels other than 1 if user has looging disabled
                return;

            try
            {
                //System.IO.StreamWriter writer = new System.IO.StreamWriter(logFile, true);
                System.IO.StreamWriter writer = new System.IO.StreamWriter(LogFilePath, true);

                switch (level)
                {
                    case 1:  // with delimter characters and  datetime
                        logMessage = "#####################  " + message + "  at " + System.DateTime.Now.ToString() + "  #####################";
                        break;

                    case 2: // datetime - message
                        logMessage = System.DateTime.Now.ToString() + "  -- " + message;
                        break;

                    case 3: // message only
                        logMessage = "                          " + message;
                        break;
                }

                writer.WriteLine(logMessage);

                //if (ConsoleManager.HasConsole)
                //{
                //    switch (level)
                //    {
                //        case 1:  // with delimter characters and  datetime
                //            Console.ForegroundColor = ConsoleColor.Yellow;
                //            break;

                //        case 2: // datetime - message
                //            Console.ForegroundColor = ConsoleColor.Green;
                //            break;

                //        case 3: // message only
                //            Console.ForegroundColor = ConsoleColor.Red;
                //            break;
                //    }
                //    Console.WriteLine(logMessage);
                //}

                writer.Flush();
                writer.Close();
                writer = null;
            }
            catch { }
        }
    
        public void DeleteLogs()
        {
            DialogResult delete = MessageBox.Show(  "Confirm deletion of all log files",
                                                    "Got Your Back Up?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);

            if(delete == DialogResult.Yes)
            {
                string logfileDir = LogFileDirectory;
                string tempLogfile = LogFilePath.Replace(LogFileDirectory, tempDir);

                try
                {
                    File.Move(LogFilePath, tempLogfile);

                    Array.ForEach(Directory.GetFiles(logfileDir),
                                  delegate(string path) { File.Delete(path); });

                    File.Move(tempLogfile, LogFilePath);                   
                }
                catch
                {
                    return;
                }
            }
            else
            {
                return;
            }
        }
    
    }
}