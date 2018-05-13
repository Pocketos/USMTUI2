namespace USMTUI2
{
    partial class Form1
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
            this.ClickHere = new System.Windows.Forms.Button();
            this.ServerName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ClickHere
            // 
            this.ClickHere.Location = new System.Drawing.Point(199, 129);
            this.ClickHere.Name = "ClickHere";
            this.ClickHere.Size = new System.Drawing.Size(75, 23);
            this.ClickHere.TabIndex = 0;
            this.ClickHere.Text = "ClickHere";
            this.ClickHere.UseVisualStyleBackColor = true;
            this.ClickHere.Click += new System.EventHandler(this.ClickHere_Click);
            // 
            // ServerName
            // 
            this.ServerName.Location = new System.Drawing.Point(412, 148);
            this.ServerName.Name = "ServerName";
            this.ServerName.Size = new System.Drawing.Size(100, 20);
            this.ServerName.TabIndex = 1;
            this.ServerName.Leave += new System.EventHandler(this.ServerName_Leave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ServerName);
            this.Controls.Add(this.ClickHere);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ClickHere;
        private System.Windows.Forms.TextBox ServerName;
    }
}

