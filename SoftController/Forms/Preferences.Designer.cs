namespace SoftController.Forms
{
    partial class Preferences
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
            this.lblLibraryDir = new System.Windows.Forms.Label();
            this.txtLibraryDir = new System.Windows.Forms.TextBox();
            this.btnLibraryDir = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnProjectDir = new System.Windows.Forms.Button();
            this.txtProjectDir = new System.Windows.Forms.TextBox();
            this.lblProjectDir = new System.Windows.Forms.Label();
            this.btnDataDir = new System.Windows.Forms.Button();
            this.txtDataDir = new System.Windows.Forms.TextBox();
            this.lblDataDir = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLibraryDir
            // 
            this.lblLibraryDir.AutoSize = true;
            this.lblLibraryDir.Location = new System.Drawing.Point(12, 17);
            this.lblLibraryDir.Name = "lblLibraryDir";
            this.lblLibraryDir.Size = new System.Drawing.Size(54, 13);
            this.lblLibraryDir.TabIndex = 0;
            this.lblLibraryDir.Text = "LibraryDir:";
            // 
            // txtLibraryDir
            // 
            this.txtLibraryDir.Enabled = false;
            this.txtLibraryDir.Location = new System.Drawing.Point(100, 14);
            this.txtLibraryDir.Name = "txtLibraryDir";
            this.txtLibraryDir.Size = new System.Drawing.Size(281, 20);
            this.txtLibraryDir.TabIndex = 1;
            // 
            // btnLibraryDir
            // 
            this.btnLibraryDir.Location = new System.Drawing.Point(387, 12);
            this.btnLibraryDir.Name = "btnLibraryDir";
            this.btnLibraryDir.Size = new System.Drawing.Size(75, 23);
            this.btnLibraryDir.TabIndex = 2;
            this.btnLibraryDir.Text = "Browse";
            this.btnLibraryDir.UseVisualStyleBackColor = true;
            this.btnLibraryDir.Click += new System.EventHandler(this.btnLibraryDir_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.Location = new System.Drawing.Point(177, 159);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(120, 32);
            this.btnAccept.TabIndex = 3;
            this.btnAccept.Text = "Accept";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnProjectDir
            // 
            this.btnProjectDir.Location = new System.Drawing.Point(387, 38);
            this.btnProjectDir.Name = "btnProjectDir";
            this.btnProjectDir.Size = new System.Drawing.Size(75, 23);
            this.btnProjectDir.TabIndex = 6;
            this.btnProjectDir.Text = "Browse";
            this.btnProjectDir.UseVisualStyleBackColor = true;
            this.btnProjectDir.Click += new System.EventHandler(this.btnProjectDir_Click);
            // 
            // txtProjectDir
            // 
            this.txtProjectDir.Enabled = false;
            this.txtProjectDir.Location = new System.Drawing.Point(100, 40);
            this.txtProjectDir.Name = "txtProjectDir";
            this.txtProjectDir.Size = new System.Drawing.Size(281, 20);
            this.txtProjectDir.TabIndex = 5;
            // 
            // lblProjectDir
            // 
            this.lblProjectDir.AutoSize = true;
            this.lblProjectDir.Location = new System.Drawing.Point(12, 43);
            this.lblProjectDir.Name = "lblProjectDir";
            this.lblProjectDir.Size = new System.Drawing.Size(56, 13);
            this.lblProjectDir.TabIndex = 4;
            this.lblProjectDir.Text = "ProjectDir:";
            // 
            // btnDataDir
            // 
            this.btnDataDir.Location = new System.Drawing.Point(387, 64);
            this.btnDataDir.Name = "btnDataDir";
            this.btnDataDir.Size = new System.Drawing.Size(75, 23);
            this.btnDataDir.TabIndex = 9;
            this.btnDataDir.Text = "Browse";
            this.btnDataDir.UseVisualStyleBackColor = true;
            this.btnDataDir.Click += new System.EventHandler(this.btnDataDir_Click);
            // 
            // txtDataDir
            // 
            this.txtDataDir.Enabled = false;
            this.txtDataDir.Location = new System.Drawing.Point(100, 66);
            this.txtDataDir.Name = "txtDataDir";
            this.txtDataDir.Size = new System.Drawing.Size(281, 20);
            this.txtDataDir.TabIndex = 8;
            // 
            // lblDataDir
            // 
            this.lblDataDir.AutoSize = true;
            this.lblDataDir.Location = new System.Drawing.Point(12, 69);
            this.lblDataDir.Name = "lblDataDir";
            this.lblDataDir.Size = new System.Drawing.Size(46, 13);
            this.lblDataDir.TabIndex = 7;
            this.lblDataDir.Text = "DataDir:";
            // 
            // Preferences
            // 
            this.AcceptButton = this.btnAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 212);
            this.Controls.Add(this.btnDataDir);
            this.Controls.Add(this.txtDataDir);
            this.Controls.Add(this.lblDataDir);
            this.Controls.Add(this.btnProjectDir);
            this.Controls.Add(this.txtProjectDir);
            this.Controls.Add(this.lblProjectDir);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.btnLibraryDir);
            this.Controls.Add(this.txtLibraryDir);
            this.Controls.Add(this.lblLibraryDir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Preferences";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Preferences";
            this.Shown += new System.EventHandler(this.Preferences_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblLibraryDir;
        private System.Windows.Forms.TextBox txtLibraryDir;
        private System.Windows.Forms.Button btnLibraryDir;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnProjectDir;
        private System.Windows.Forms.TextBox txtProjectDir;
        private System.Windows.Forms.Label lblProjectDir;
        private System.Windows.Forms.Button btnDataDir;
        private System.Windows.Forms.TextBox txtDataDir;
        private System.Windows.Forms.Label lblDataDir;
    }
}