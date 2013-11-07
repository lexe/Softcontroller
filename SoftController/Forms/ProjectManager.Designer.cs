namespace SoftController.Forms
{
    partial class ProjectManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectManager));
            this.tlsTools = new System.Windows.Forms.ToolStrip();
            this.btnNew = new System.Windows.Forms.ToolStripButton();
            this.lsvProjects = new System.Windows.Forms.ListView();
            this.clmnName = new System.Windows.Forms.ColumnHeader();
            this.clmnModified = new System.Windows.Forms.ColumnHeader();
            this.tlsTools.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlsTools
            // 
            this.tlsTools.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tlsTools.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNew});
            this.tlsTools.Location = new System.Drawing.Point(0, 0);
            this.tlsTools.Name = "tlsTools";
            this.tlsTools.Size = new System.Drawing.Size(474, 25);
            this.tlsTools.TabIndex = 0;
            this.tlsTools.Text = "Tools";
            // 
            // btnNew
            // 
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(51, 22);
            this.btnNew.Text = "New";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // lsvProjects
            // 
            this.lsvProjects.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmnName,
            this.clmnModified});
            this.lsvProjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsvProjects.FullRowSelect = true;
            this.lsvProjects.GridLines = true;
            this.lsvProjects.Location = new System.Drawing.Point(0, 25);
            this.lsvProjects.Name = "lsvProjects";
            this.lsvProjects.Size = new System.Drawing.Size(474, 267);
            this.lsvProjects.TabIndex = 1;
            this.lsvProjects.UseCompatibleStateImageBehavior = false;
            this.lsvProjects.View = System.Windows.Forms.View.Details;
            this.lsvProjects.SizeChanged += new System.EventHandler(this.lsvProjects_SizeChanged);
            // 
            // clmnName
            // 
            this.clmnName.Text = "Name";
            // 
            // clmnModified
            // 
            this.clmnModified.Text = "Modified";
            // 
            // ProjectManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(474, 292);
            this.Controls.Add(this.lsvProjects);
            this.Controls.Add(this.tlsTools);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProjectManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Project Manager";
            this.Shown += new System.EventHandler(this.ProjectManager_Shown);
            this.tlsTools.ResumeLayout(false);
            this.tlsTools.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tlsTools;
        private System.Windows.Forms.ToolStripButton btnNew;
        private System.Windows.Forms.ListView lsvProjects;
        private System.Windows.Forms.ColumnHeader clmnName;
        private System.Windows.Forms.ColumnHeader clmnModified;
    }
}