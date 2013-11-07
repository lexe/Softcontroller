using System;
using System.Windows.Forms;
using SoftController.BLL;
using SoftController.Forms;

namespace SoftController
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Shown(object sender, EventArgs e)
        {
            Cache.Initialize();
        }

        #region MainMenu
        private void mniFileProjectManager_Click(object sender, EventArgs e)
        {
            ProjectManager dialog = new ProjectManager();
            dialog.ShowDialog();
        }
        private void mniFileQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mniLibraryEditor_Click(object sender, EventArgs e)
        {
            LibraryEditor form = new LibraryEditor();
            form.MdiParent = this;
            form.Show();
        }

        private void mniToolsPreferences_Click(object sender, EventArgs e)
        {
            Preferences dialog = new Preferences();
            dialog.ShowDialog();
        }
        #endregion
    }
}
