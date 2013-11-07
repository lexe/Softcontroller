namespace SoftController
{
    partial class Main
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
            this.mnMain = new System.Windows.Forms.MenuStrip();
            this.mniFile = new System.Windows.Forms.ToolStripMenuItem();
            this.mniFileProjectManager = new System.Windows.Forms.ToolStripMenuItem();
            this.mniFileOpenRecent = new System.Windows.Forms.ToolStripMenuItem();
            this.mniFileSep1 = new System.Windows.Forms.ToolStripSeparator();
            this.mniFileQuit = new System.Windows.Forms.ToolStripMenuItem();
            this.mniLibrary = new System.Windows.Forms.ToolStripMenuItem();
            this.mniLibraryEditor = new System.Windows.Forms.ToolStripMenuItem();
            this.mniTools = new System.Windows.Forms.ToolStripMenuItem();
            this.mniPreferences = new System.Windows.Forms.ToolStripMenuItem();
            this.mniWindows = new System.Windows.Forms.ToolStripMenuItem();
            this.mnMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnMain
            // 
            this.mnMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniFile,
            this.mniLibrary,
            this.mniTools,
            this.mniWindows});
            this.mnMain.Location = new System.Drawing.Point(0, 0);
            this.mnMain.MdiWindowListItem = this.mniWindows;
            this.mnMain.Name = "mnMain";
            this.mnMain.Size = new System.Drawing.Size(1264, 24);
            this.mnMain.TabIndex = 4;
            this.mnMain.Text = "Main menu";
            // 
            // mniFile
            // 
            this.mniFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniFileProjectManager,
            this.mniFileOpenRecent,
            this.mniFileSep1,
            this.mniFileQuit});
            this.mniFile.Name = "mniFile";
            this.mniFile.Size = new System.Drawing.Size(37, 20);
            this.mniFile.Text = "File";
            // 
            // mniFileProjectManager
            // 
            this.mniFileProjectManager.Name = "mniFileProjectManager";
            this.mniFileProjectManager.Size = new System.Drawing.Size(161, 22);
            this.mniFileProjectManager.Text = "Project manager";
            this.mniFileProjectManager.Click += new System.EventHandler(this.mniFileProjectManager_Click);
            // 
            // mniFileOpenRecent
            // 
            this.mniFileOpenRecent.Name = "mniFileOpenRecent";
            this.mniFileOpenRecent.Size = new System.Drawing.Size(161, 22);
            this.mniFileOpenRecent.Text = "Open recent";
            // 
            // mniFileSep1
            // 
            this.mniFileSep1.Name = "mniFileSep1";
            this.mniFileSep1.Size = new System.Drawing.Size(158, 6);
            // 
            // mniFileQuit
            // 
            this.mniFileQuit.Name = "mniFileQuit";
            this.mniFileQuit.Size = new System.Drawing.Size(161, 22);
            this.mniFileQuit.Text = "Quit";
            this.mniFileQuit.Click += new System.EventHandler(this.mniFileQuit_Click);
            // 
            // mniLibrary
            // 
            this.mniLibrary.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniLibraryEditor});
            this.mniLibrary.Name = "mniLibrary";
            this.mniLibrary.Size = new System.Drawing.Size(55, 20);
            this.mniLibrary.Text = "Library";
            // 
            // mniLibraryEditor
            // 
            this.mniLibraryEditor.Name = "mniLibraryEditor";
            this.mniLibraryEditor.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.mniLibraryEditor.Size = new System.Drawing.Size(145, 22);
            this.mniLibraryEditor.Text = "Editor";
            this.mniLibraryEditor.Click += new System.EventHandler(this.mniLibraryEditor_Click);
            // 
            // mniTools
            // 
            this.mniTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniPreferences});
            this.mniTools.Name = "mniTools";
            this.mniTools.Size = new System.Drawing.Size(48, 20);
            this.mniTools.Text = "Tools";
            // 
            // mniPreferences
            // 
            this.mniPreferences.Name = "mniPreferences";
            this.mniPreferences.Size = new System.Drawing.Size(135, 22);
            this.mniPreferences.Text = "Preferences";
            this.mniPreferences.Click += new System.EventHandler(this.mniToolsPreferences_Click);
            // 
            // mniWindows
            // 
            this.mniWindows.Name = "mniWindows";
            this.mniWindows.Size = new System.Drawing.Size(68, 20);
            this.mniWindows.Text = "Windows";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 762);
            this.Controls.Add(this.mnMain);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnMain;
            this.Name = "Main";
            this.Text = "Soft Controller";
            this.Shown += new System.EventHandler(this.Main_Shown);
            this.mnMain.ResumeLayout(false);
            this.mnMain.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnMain;
        private System.Windows.Forms.ToolStripMenuItem mniFile;
        private System.Windows.Forms.ToolStripMenuItem mniFileProjectManager;
        private System.Windows.Forms.ToolStripMenuItem mniFileOpenRecent;
        private System.Windows.Forms.ToolStripSeparator mniFileSep1;
        private System.Windows.Forms.ToolStripMenuItem mniFileQuit;
        private System.Windows.Forms.ToolStripMenuItem mniLibrary;
        private System.Windows.Forms.ToolStripMenuItem mniWindows;
        private System.Windows.Forms.ToolStripMenuItem mniTools;
        private System.Windows.Forms.ToolStripMenuItem mniPreferences;
        private System.Windows.Forms.ToolStripMenuItem mniLibraryEditor;

    }
}

