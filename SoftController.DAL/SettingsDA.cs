using System;

namespace SoftController.DAL
{
    public class SettingsDA
    {
        public String LibraryDir
        {
            get { return Properties.Settings.Default.LibraryDir; }
            set { Properties.Settings.Default.LibraryDir = value; Properties.Settings.Default.Save(); }
        }
        public String ProjectDir
        {
            get { return Properties.Settings.Default.ProjectDir; }
            set { Properties.Settings.Default.ProjectDir = value; Properties.Settings.Default.Save(); }
        }
        public String DataDir
        {
            get { return Properties.Settings.Default.DataDir; }
            set { Properties.Settings.Default.DataDir = value; Properties.Settings.Default.Save(); }
        }
    }
}
