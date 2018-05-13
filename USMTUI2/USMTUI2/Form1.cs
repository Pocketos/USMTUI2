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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ClickHere_Click(object sender, EventArgs e)
        {
            Messages.ErrorMessage(ServerName.Text);
        }

        private void ServerName_Leave(object sender, EventArgs e)
        {
            Validation.ValidateServername(ServerName.Text);
        }
    }
}
