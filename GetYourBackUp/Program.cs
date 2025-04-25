using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GotYourBackUp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //======================================
            //make sure program is not already running
            //======================================
            //http://bytes.com/topic/c-sharp/answers/237932-check-if-previous-instance-application-exists

            string proc = Process.GetCurrentProcess().ProcessName;          // get the name of our process
            Process[] processes = Process.GetProcessesByName(proc);         // get the list of all processes by that name

            if (processes.Length > 1)                                       // if there is more than one process...
            {
                MessageBox.Show("Scheduled run of 'Got Your Back Up' aborted \nbecause program is already open.", "Got Your Back Up?",
                                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //======================================
            //unhandled exceptions
            //======================================
            //http://www.switchonthecode.com/tutorials/csharp-tutorial-dealing-with-unhandled-exceptions

            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);
            Application.ThreadException += new System.Threading.ThreadExceptionEventHandler(Application_ThreadException);



            Application.Run(new MainForm());
        }

        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            try
            {
                Exception ex = (Exception)e.ExceptionObject;

                MessageBox.Show("Whoops! Please contact the developers with the following"
                      + " information:\n\n" + ex.Message + ex.StackTrace,
                      "Got Your Back Up: Fatal Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            finally
            {
                Application.Exit();
            }
        }

        public static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            DialogResult result = DialogResult.Abort;
            try
            {
                result = MessageBox.Show("Whoops! Please contact the developers with the"
                  + " following information:\n\n" + e.Exception.Message + e.Exception.StackTrace,
                  "Application Error", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Stop);
            }
            finally
            {
                if (result == DialogResult.Abort)
                {
                    Application.Exit();
                }
            }
        }

    }
}
