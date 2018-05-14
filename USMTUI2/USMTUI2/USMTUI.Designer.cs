namespace USMTUI2
{
    partial class USMTUIForm
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
            this.BackupNow = new System.Windows.Forms.Button();
            this.ServerName = new System.Windows.Forms.TextBox();
            this.StepOneGroup = new System.Windows.Forms.GroupBox();
            this.ShareFolderBrowser = new System.Windows.Forms.Button();
            this.ShareAddressLabel = new System.Windows.Forms.Label();
            this.StepTwoGroup = new System.Windows.Forms.GroupBox();
            this.RestoreNow = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.BottomToolStripSpacer = new System.Windows.Forms.ToolStripStatusLabel();
            this.ProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.StepOneGroup.SuspendLayout();
            this.StepTwoGroup.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackupNow
            // 
            this.BackupNow.Location = new System.Drawing.Point(6, 30);
            this.BackupNow.Name = "BackupNow";
            this.BackupNow.Size = new System.Drawing.Size(135, 46);
            this.BackupNow.TabIndex = 0;
            this.BackupNow.Text = "Backup";
            this.BackupNow.UseVisualStyleBackColor = true;
            this.BackupNow.Click += new System.EventHandler(this.BackupNow_Click);
            // 
            // ServerName
            // 
            this.ServerName.Location = new System.Drawing.Point(11, 53);
            this.ServerName.Name = "ServerName";
            this.ServerName.Size = new System.Drawing.Size(216, 30);
            this.ServerName.TabIndex = 1;
            // 
            // StepOneGroup
            // 
            this.StepOneGroup.Controls.Add(this.ShareFolderBrowser);
            this.StepOneGroup.Controls.Add(this.ShareAddressLabel);
            this.StepOneGroup.Controls.Add(this.ServerName);
            this.StepOneGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StepOneGroup.Location = new System.Drawing.Point(12, 12);
            this.StepOneGroup.Name = "StepOneGroup";
            this.StepOneGroup.Size = new System.Drawing.Size(288, 172);
            this.StepOneGroup.TabIndex = 2;
            this.StepOneGroup.TabStop = false;
            this.StepOneGroup.Text = "Step 1";
            // 
            // ShareFolderBrowser
            // 
            this.ShareFolderBrowser.BackColor = System.Drawing.Color.Transparent;
            this.ShareFolderBrowser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ShareFolderBrowser.FlatAppearance.BorderSize = 0;
            this.ShareFolderBrowser.Image = global::USMTUI2.Properties.Resources.FolderOpen_32xMD;
            this.ShareFolderBrowser.Location = new System.Drawing.Point(234, 53);
            this.ShareFolderBrowser.Name = "ShareFolderBrowser";
            this.ShareFolderBrowser.Size = new System.Drawing.Size(32, 30);
            this.ShareFolderBrowser.TabIndex = 2;
            this.ShareFolderBrowser.UseVisualStyleBackColor = false;
            this.ShareFolderBrowser.Click += new System.EventHandler(this.ShareFolderBrowser_Click);
            // 
            // ShareAddressLabel
            // 
            this.ShareAddressLabel.AutoSize = true;
            this.ShareAddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShareAddressLabel.Location = new System.Drawing.Point(7, 30);
            this.ShareAddressLabel.Name = "ShareAddressLabel";
            this.ShareAddressLabel.Size = new System.Drawing.Size(115, 20);
            this.ShareAddressLabel.TabIndex = 0;
            this.ShareAddressLabel.Text = "Share Address";
            // 
            // StepTwoGroup
            // 
            this.StepTwoGroup.Controls.Add(this.RestoreNow);
            this.StepTwoGroup.Controls.Add(this.BackupNow);
            this.StepTwoGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StepTwoGroup.Location = new System.Drawing.Point(306, 12);
            this.StepTwoGroup.Name = "StepTwoGroup";
            this.StepTwoGroup.Size = new System.Drawing.Size(307, 172);
            this.StepTwoGroup.TabIndex = 3;
            this.StepTwoGroup.TabStop = false;
            this.StepTwoGroup.Text = "Step 2";
            // 
            // RestoreNow
            // 
            this.RestoreNow.Location = new System.Drawing.Point(7, 83);
            this.RestoreNow.Name = "RestoreNow";
            this.RestoreNow.Size = new System.Drawing.Size(134, 45);
            this.RestoreNow.TabIndex = 1;
            this.RestoreNow.Text = "Restore";
            this.RestoreNow.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel,
            this.BottomToolStripSpacer,
            this.ProgressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 242);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(641, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = false;
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(118, 17);
            this.StatusLabel.Text = "Status";
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // BottomToolStripSpacer
            // 
            this.BottomToolStripSpacer.Name = "BottomToolStripSpacer";
            this.BottomToolStripSpacer.Size = new System.Drawing.Size(306, 17);
            this.BottomToolStripSpacer.Spring = true;
            // 
            // ProgressBar
            // 
            this.ProgressBar.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.ProgressBar.AutoSize = false;
            this.ProgressBar.Name = "ProgressBar";
            this.ProgressBar.Size = new System.Drawing.Size(200, 16);
            this.ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // USMTUIForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 264);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.StepTwoGroup);
            this.Controls.Add(this.StepOneGroup);
            this.Name = "USMTUIForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.USMTUIForm_Load);
            this.StepOneGroup.ResumeLayout(false);
            this.StepOneGroup.PerformLayout();
            this.StepTwoGroup.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BackupNow;
        private System.Windows.Forms.TextBox ServerName;
        private System.Windows.Forms.GroupBox StepOneGroup;
        private System.Windows.Forms.GroupBox StepTwoGroup;
        private System.Windows.Forms.Label ShareAddressLabel;
        private System.Windows.Forms.Button RestoreNow;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel BottomToolStripSpacer;
        private System.Windows.Forms.ToolStripProgressBar ProgressBar;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.Button ShareFolderBrowser;
    }
}

