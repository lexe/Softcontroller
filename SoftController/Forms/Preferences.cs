using System;
using System.Windows.Forms;
using SoftController.BLL.Components;

namespace SoftController.Forms
{
    public partial class Preferences : Form
    {
        private SettingsComp _comp = new SettingsComp();

        public Preferences()
        {
            InitializeComponent();
        }

        private void Initialize()
        {
            txtLibraryDir.Text = _comp.LibraryDir;
            txtProjectDir.Text = _comp.ProjectDir;
            txtDataDir.Text = _comp.DataDir;
        }

        private void Preferences_Shown(object sender, EventArgs e)
        {
            Initialize();
        }

        private void btnLibraryDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK) txtLibraryDir.Text = dialog.SelectedPath;
        }
        private void btnProjectDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK) txtProjectDir.Text = dialog.SelectedPath;
        }
        private void btnDataDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK) txtDataDir.Text = dialog.SelectedPath;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            try
            {
                _comp.LibraryDir = txtLibraryDir.Text;
                _comp.ProjectDir = txtProjectDir.Text;
                _comp.DataDir = txtDataDir.Text;

                this.DialogResult = DialogResult.OK;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message, "Warning"); }
        }
    }
}
