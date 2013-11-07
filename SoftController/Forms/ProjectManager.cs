using System;
using System.Windows.Forms;
using SoftController.BLL.Entities;
using SoftController.BLL.Components;

namespace SoftController.Forms
{
    public partial class ProjectManager : Form
    {
        public ProjectManager()
        {
            InitializeComponent();
        }

        private void Initialize()
        {
            lsvProjects_SizeChanged(null, null);

            UpdateList();
        }

        private void UpdateList()
        {
            lsvProjects.BeginUpdate();
            lsvProjects.Items.Clear();

            ProjectComp comp = new ProjectComp();
            foreach (Project project in comp.Get())
            {
                ListViewItem item = new ListViewItem(new string[2]);
                item.Tag = project;
                lsvProjects.Items.Add(item);

                UpdateItem(item);
            }

            lsvProjects.EndUpdate();
        }
        private void UpdateItem(ListViewItem item)
        {
            Project project = (Project)item.Tag;
            item.SubItems[0].Text = project.Name;
            item.SubItems[1].Text = project.Modified.ToString();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            InputString dialog = new InputString("Create new project", "Name:");
            dialog.TextBox.MaxLength = 32;
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Project project = new Project();
                    project.Name = dialog.TextBox.Text;
                    project.Save();

                    UpdateList();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message, "Warning"); }
            }
        }

        private void ProjectManager_Shown(object sender, EventArgs e)
        {
            Initialize();
        }

        private void lsvProjects_SizeChanged(object sender, EventArgs e)
        {
            lsvProjects.Columns[1].Width = 120;
            lsvProjects.Columns[0].Width =
                lsvProjects.Width - 21 -
                lsvProjects.Columns[1].Width;
        }
    }
}
