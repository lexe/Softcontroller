using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SoftController.BLL;
using SoftController.BLL.Components;
using SoftController.BLL.Entities;
using SoftController.Forms;

namespace SoftController.Controls
{
    public partial class LibraryTree : UserControl
    {
        private Guid _preselectLibraryUID;
        private Guid _preselectCategoryLibraryUID;
        private Int64 _preselectCategoryID;
        private Guid _preselectItemLibraryUID;
        private Int64 _preselectItemID;
        private Boolean _expandPreselectedNode;

        public delegate void AfterItemSelectEventHandler();
        public event AfterItemSelectEventHandler AfterItemSelect;

        public LibraryTree()
        {
            InitializeComponent();
        }

        public void UpdateTree()
        {
            tvwTree.Nodes.Clear();

            foreach (Library library in Cache.Libraries)
            {
                TreeNode nodeLib = new TreeNode(library.Name);
                nodeLib.Tag = library;
                nodeLib.ForeColor = Color.SteelBlue;
                tvwTree.Nodes.Add(nodeLib);

                FillParentNode(nodeLib, nodeLib);
                if (library.UID == _preselectLibraryUID)
                {
                    tvwTree.SelectedNode = nodeLib;
                    if (_expandPreselectedNode) nodeLib.Expand();
                }
            }
            
            // reset preselect ID's
            _preselectLibraryUID = Guid.Empty;
            _preselectCategoryLibraryUID = Guid.Empty;
            _preselectCategoryID = 0;
            _preselectItemLibraryUID = Guid.Empty;
            _preselectItemID = 0;
            _expandPreselectedNode = false;
        }
        private void FillParentNode(TreeNode nodeLib, TreeNode parentNode)
        {
            Library lib = (Library)nodeLib.Tag;
            if (parentNode.Tag is Library)
            {
                // add categories
                List<LibraryCategory> categories = lib.Categories.Where(c => c.CategoryID == 0).ToList();
                foreach (LibraryCategory category in categories)
                {
                    TreeNode nodeCat = new TreeNode(category.Name);
                    nodeCat.Tag = category;
                    nodeCat.ForeColor = Color.Green;
                    parentNode.Nodes.Add(nodeCat);

                    FillParentNode(nodeLib, nodeCat);
                    if (lib.UID == _preselectCategoryLibraryUID && category.ID == _preselectCategoryID)
                    {
                        tvwTree.SelectedNode = nodeCat;
                        if (_expandPreselectedNode) nodeCat.Expand();
                    }
                }
            }
            else if (parentNode.Tag is LibraryCategory)
            {
                // add categories
                List<LibraryCategory> categories = lib.Categories.Where(c => c.CategoryID == ((LibraryCategory)parentNode.Tag).ID).ToList();
                foreach (LibraryCategory category in categories)
                {
                    TreeNode nodeCat = new TreeNode(category.Name);
                    nodeCat.Tag = category;
                    nodeCat.ForeColor = Color.Green;
                    parentNode.Nodes.Add(nodeCat);

                    FillParentNode(nodeLib, nodeCat);
                    if (lib.UID == _preselectCategoryLibraryUID && category.ID == _preselectCategoryID)
                    {
                        tvwTree.SelectedNode = nodeCat;
                        if (_expandPreselectedNode) nodeCat.Expand();
                    }
                }

                // add items
                List<LibraryItem> items = lib.Items.Where(i => i.CategoryID == ((LibraryCategory)parentNode.Tag).ID).ToList();
                foreach (LibraryItem item in items)
                {
                    TreeNode nodeItem = new TreeNode(item.Name);
                    nodeItem.Tag = item;
                    parentNode.Nodes.Add(nodeItem);

                    if (lib.UID == _preselectItemLibraryUID && item.ID == _preselectItemID)
                    {
                        tvwTree.SelectedNode = nodeItem;
                    }
                }
            }
        }
        private Library GetLibrary(TreeNode node)
        {
            TreeNode nodeLib = node;
            while (nodeLib.Parent != null) { nodeLib = nodeLib.Parent; }

            return (Library)nodeLib.Tag;
        }

        public void AddLibrary()
        {
            InputString dialog = new InputString("Create new library", "Name:");
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Library library = new Library();
                    library.Name = dialog.TextBox.Text;
                    library.Save();

                    // update tree
                    _preselectLibraryUID = library.UID;
                    UpdateTree();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message, "Warning"); }
            }
        }

        #region ContextMenu
        private void ctxtMenu_Opening(object sender, System.ComponentModel.CancelEventArgs e)
        {
            // init
            mniAddLibrary.Visible = false;
            mniDeleteLibrary.Visible = false;
            mniSep1.Visible = false;
            mniAddCategory.Visible = false;
            mniDeleteCategory.Visible = false;
            mniSep2.Visible = false;
            mniAddItem.Visible = false;
            mniDeleteItem.Visible = false;

            // select item at cursor
            tvwTree.SelectedNode = tvwTree.GetNodeAt(this.PointToClient(MousePosition));

            // set visible items
            if (tvwTree.SelectedNode == null)
            {
                mniAddLibrary.Visible = true;
            }
            else if (tvwTree.SelectedNode.Tag is Library)
            {
                mniDeleteLibrary.Visible = true;
                mniSep1.Visible = true;
                mniAddCategory.Visible = true;
            }
            else if (tvwTree.SelectedNode.Tag is LibraryCategory)
            {
                mniAddCategory.Visible = true;
                mniDeleteCategory.Visible = true;
                mniSep2.Visible = true;
                mniAddItem.Visible = true;
            }
            else if (tvwTree.SelectedNode.Tag is LibraryItem)
            {
                mniDeleteItem.Visible = true;
            }         
        }

        private void mniAddLibrary_Click(object sender, EventArgs e)
        {
            AddLibrary();
        }
        private void mniDeleteLibrary_Click(object sender, EventArgs e)
        {

        }

        private void mniAddCategory_Click(object sender, EventArgs e)
        {
            InputString dialog = new InputString("Add category", "Name:");
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Library library = GetLibrary(tvwTree.SelectedNode);
                LibraryCategory category = new LibraryCategory();
                if (!(tvwTree.SelectedNode.Tag is LibraryCategory)) category.CategoryID = 0;
                else category.CategoryID = ((LibraryCategory)tvwTree.SelectedNode.Tag).ID;
                category.Name = dialog.TextBox.Text;

                LibraryComp comp = new LibraryComp();
                comp.AddCategory(library, category);

                // update tree
                _preselectCategoryLibraryUID = library.UID;
                _preselectCategoryID = category.ID;
                UpdateTree();
            }
        }
        private void mniDeleteCategory_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Delete category", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Library library = GetLibrary(tvwTree.SelectedNode);
                LibraryComp comp = new LibraryComp();
                comp.DeleteCategory(library, (LibraryCategory)tvwTree.SelectedNode.Tag);

                // update tree
                if (tvwTree.SelectedNode.Parent.Tag is Library) _preselectLibraryUID = library.UID;
                else
                {
                    _preselectCategoryLibraryUID = library.UID;
                    _preselectCategoryID = ((LibraryCategory)tvwTree.SelectedNode.Parent.Tag).ID;
                }
                _expandPreselectedNode = true;
                UpdateTree();
            }
        }

        private void mniAddItem_Click(object sender, EventArgs e)
        {
            InputString dialog = new InputString("Add item", "Name:");
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Library library = GetLibrary(tvwTree.SelectedNode);
                LibraryItem item = new LibraryItem();
                item.CategoryID = ((LibraryCategory)tvwTree.SelectedNode.Tag).ID;
                item.Name = dialog.TextBox.Text;

                LibraryComp comp = new LibraryComp();
                comp.AddItem(library, item);

                // update tree
                _preselectItemLibraryUID = library.UID;
                _preselectItemID = item.ID;
                UpdateTree();
            }
        }
        private void mniDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure?", "Delete item", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Library library = GetLibrary(tvwTree.SelectedNode);
                LibraryComp comp = new LibraryComp();
                comp.DeleteItem(library, (LibraryItem)tvwTree.SelectedNode.Tag);

                // update tree
                if (tvwTree.SelectedNode.Parent.Tag is Library) _preselectLibraryUID = library.UID;
                else
                {
                    _preselectCategoryLibraryUID = library.UID;
                    _preselectCategoryID = ((LibraryCategory)tvwTree.SelectedNode.Parent.Tag).ID;
                }
                _expandPreselectedNode = true;
                UpdateTree();
            }
        }
        #endregion

        private void tvwTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (AfterItemSelect != null) AfterItemSelect();
        }

        public Library SelectedLibrary
        {
            get
            {
                if (tvwTree.SelectedNode == null) return null;
                else return GetLibrary(tvwTree.SelectedNode);
            }
        }
        public LibraryItem SelectedItem
        {
            get
            {
                if (tvwTree.SelectedNode == null) return null;
                else if (tvwTree.SelectedNode.Tag is LibraryItem) return (LibraryItem)tvwTree.SelectedNode.Tag;
                else return null;
            }
        }
    }
}
