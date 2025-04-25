using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Reflection;

namespace GotYourBackUp
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
            VersionLabel.Text = GetVersion();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://servicedesk:81/hd/ticket/ticketView.ssp?ticket_id=201945&backToUrl=/hd/report/repTabRun.ssp&backToPrompt=Open+Requests+%28Not+%3d+CLEAR%2fWAMEX%29");
     
        
        
        }



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
                    myVersion = "v " + _assemblyInfo.GetName().Version.ToString();
                    myDate = DateTime.Today.ToShortDateString();
                }
            }
            return myVersion;
        }

    }
}
