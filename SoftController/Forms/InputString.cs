using System;
using System.Windows.Forms;

namespace SoftController.Forms
{
    public partial class InputString : Form
    {
        public InputString(String title, String question)
        {
            InitializeComponent();

            this.Text = title;
            lblQuestion.Text = question;
        }
        public InputString(String title, String question, String defaultValue)
        {
            InitializeComponent();

            this.Text = title;
            lblQuestion.Text = question;
            txtEntry.Text = defaultValue;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        public TextBox TextBox { get { return txtEntry; } set { txtEntry = value; } }
    }
}
