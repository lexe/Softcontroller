namespace SoftController.Controls
{
    partial class LibraryTree
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tvwTree = new System.Windows.Forms.TreeView();
            this.ctxtMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mniAddLibrary = new System.Windows.Forms.ToolStripMenuItem();
            this.mniDeleteLibrary = new System.Windows.Forms.ToolStripMenuItem();
            this.mniSep1 = new System.Windows.Forms.ToolStripSeparator();
            this.mniAddCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.mniDeleteCategory = new System.Windows.Forms.ToolStripMenuItem();
            this.mniSep2 = new System.Windows.Forms.ToolStripSeparator();
            this.mniAddItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mniDeleteItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxtMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // tvwTree
            // 
            this.tvwTree.ContextMenuStrip = this.ctxtMenu;
            this.tvwTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tvwTree.HideSelection = false;
            this.tvwTree.Location = new System.Drawing.Point(0, 0);
            this.tvwTree.Name = "tvwTree";
            this.tvwTree.Size = new System.Drawing.Size(240, 320);
            this.tvwTree.TabIndex = 0;
            this.tvwTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvwTree_AfterSelect);
            // 
            // ctxtMenu
            // 
            this.ctxtMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniAddLibrary,
            this.mniDeleteLibrary,
            this.mniSep1,
            this.mniAddCategory,
            this.mniDeleteCategory,
            this.mniSep2,
            this.mniAddItem,
            this.mniDeleteItem});
            this.ctxtMenu.Name = "ctxtMenu";
            this.ctxtMenu.Size = new System.Drawing.Size(157, 148);
            this.ctxtMenu.Opening += new System.ComponentModel.CancelEventHandler(this.ctxtMenu_Opening);
            // 
            // mniAddLibrary
            // 
            this.mniAddLibrary.Name = "mniAddLibrary";
            this.mniAddLibrary.Size = new System.Drawing.Size(156, 22);
            this.mniAddLibrary.Text = "Add library";
            this.mniAddLibrary.Click += new System.EventHandler(this.mniAddLibrary_Click);
            // 
            // mniDeleteLibrary
            // 
            this.mniDeleteLibrary.Name = "mniDeleteLibrary";
            this.mniDeleteLibrary.Size = new System.Drawing.Size(156, 22);
            this.mniDeleteLibrary.Text = "Delete library";
            this.mniDeleteLibrary.Click += new System.EventHandler(this.mniDeleteLibrary_Click);
            // 
            // mniSep1
            // 
            this.mniSep1.Name = "mniSep1";
            this.mniSep1.Size = new System.Drawing.Size(153, 6);
            // 
            // mniAddCategory
            // 
            this.mniAddCategory.Name = "mniAddCategory";
            this.mniAddCategory.Size = new System.Drawing.Size(156, 22);
            this.mniAddCategory.Text = "Add category";
            this.mniAddCategory.Click += new System.EventHandler(this.mniAddCategory_Click);
            // 
            // mniDeleteCategory
            // 
            this.mniDeleteCategory.Name = "mniDeleteCategory";
            this.mniDeleteCategory.Size = new System.Drawing.Size(156, 22);
            this.mniDeleteCategory.Text = "Delete category";
            this.mniDeleteCategory.Click += new System.EventHandler(this.mniDeleteCategory_Click);
            // 
            // mniSep2
            // 
            this.mniSep2.Name = "mniSep2";
            this.mniSep2.Size = new System.Drawing.Size(153, 6);
            // 
            // mniAddItem
            // 
            this.mniAddItem.Name = "mniAddItem";
            this.mniAddItem.Size = new System.Drawing.Size(156, 22);
            this.mniAddItem.Text = "Add item";
            this.mniAddItem.Click += new System.EventHandler(this.mniAddItem_Click);
            // 
            // mniDeleteItem
            // 
            this.mniDeleteItem.Name = "mniDeleteItem";
            this.mniDeleteItem.Size = new System.Drawing.Size(156, 22);
            this.mniDeleteItem.Text = "Delete item";
            this.mniDeleteItem.Click += new System.EventHandler(this.mniDeleteItem_Click);
            // 
            // LibraryTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tvwTree);
            this.Name = "LibraryTree";
            this.Size = new System.Drawing.Size(240, 320);
            this.ctxtMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvwTree;
        private System.Windows.Forms.ContextMenuStrip ctxtMenu;
        private System.Windows.Forms.ToolStripMenuItem mniAddLibrary;
        private System.Windows.Forms.ToolStripMenuItem mniDeleteLibrary;
        private System.Windows.Forms.ToolStripSeparator mniSep1;
        private System.Windows.Forms.ToolStripMenuItem mniAddCategory;
        private System.Windows.Forms.ToolStripMenuItem mniDeleteCategory;
        private System.Windows.Forms.ToolStripSeparator mniSep2;
        private System.Windows.Forms.ToolStripMenuItem mniAddItem;
        private System.Windows.Forms.ToolStripMenuItem mniDeleteItem;
    }
}
