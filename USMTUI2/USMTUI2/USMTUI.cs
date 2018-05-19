using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using USMTUI2.Classes;

namespace USMTUI2
{
    public partial class USMTUIForm : Form
    {
        public USMTUIForm()
        {
            InitializeComponent();
            this.Text = "User State Migration Tool Utility";
        }

        private void USMTUIForm_Load(object sender, EventArgs e)
        {

        }

        private void BackupNow_Click(object sender, EventArgs e)
        {
            var is64bit = new Validation();
            bool arch = is64bit.GetArch();

            //Sets the status to Backing Up Profile...
            StatusText.Text = "Backing Up Profile...";

            //Actvates the progress bar to indicate activity
            ProgressBar.Value = 100;
            ProgressBar.MarqueeAnimationSpeed = 50;

            var getCMD = new Usmt();
            getCMD.UsmtBackup(ServerName.Text, FolderName.Text);

            //Sets the status to No Status
            StatusText.Text = "No Status";

            //Resets the progress bar
            ProgressBar.Value = 0;
            ProgressBar.MarqueeAnimationSpeed = 0;
        }

        private void ShareFolderBrowser_Click(object sender, EventArgs e)
        {
            string sharePath = "";
            FolderBrowserDialog shareBrowser = new FolderBrowserDialog();
            shareBrowser.SelectedPath = ServerName.Text;
            if (shareBrowser.ShowDialog() == DialogResult.OK)
            {
                sharePath = shareBrowser.SelectedPath;
                ServerName.Text = sharePath;
                Validation.ValidateServername(ServerName.Text);
                StatusText.Text = Convert.ToString(Validation.ValidateServername(ServerName.Text));
            }
        }

        private void RestoreNow_Click(object sender, EventArgs e)
        {
            //Sets the status to Restoring Profile...
            StatusText.Text = "Restoring Profile...";

            //Actvates the progress bar to indicate activity
            ProgressBar.Value = 100;
            ProgressBar.MarqueeAnimationSpeed = 50;

            var getCMD = new Usmt();
            getCMD.UsmtRestore(ServerName.Text, FolderName.Text);

            //Sets the status to No Status
            StatusText.Text = "No Status";

            //Resets the progress bar
            ProgressBar.Value = 0;
            ProgressBar.MarqueeAnimationSpeed = 0;

        }
    }
}
