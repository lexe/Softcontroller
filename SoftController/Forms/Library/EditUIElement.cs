using System;
using System.Windows.Forms;
using SoftController.BLL.Entities;
using SoftController.BLL.Components;

namespace SoftController.Forms.Library
{
    public partial class EditUIElement : Form
    {
        private LibraryUIElement _element;

        public delegate void PropertyChangedEventHandler();
        public event PropertyChangedEventHandler PropertyChanged;

        public EditUIElement(LibraryUIElement element)
        {
            InitializeComponent();

            _element = element;
        }
        private void EditUIElement_Shown(object sender, EventArgs e)
        {
            if (_element is UILine) this.Controls.Add(new EditLine((UILine)_element));
        }

        public void RaisePropertyChanged()
        {
            if (PropertyChanged != null) PropertyChanged();
        }
    }
}
