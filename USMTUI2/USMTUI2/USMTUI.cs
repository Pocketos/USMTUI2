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

            Messages.ErrorMessage(Convert.ToString(arch));
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
                StatusLabel.Text = Convert.ToString(Validation.ValidateServername(ServerName.Text));
            }
        }
    }
}
