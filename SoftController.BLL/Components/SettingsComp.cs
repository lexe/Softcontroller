using System;
using System.IO;
using SoftController.DAL;

namespace SoftController.BLL.Components
{
    public class SettingsComp
    {
        private SettingsDA _da = new SettingsDA();

        public String LibraryDir
        {
            get { return _da.LibraryDir; }
            set
            {
                if (value == string.Empty) throw new Exception("LibraryDir not specified");
                if (!Directory.Exists(value)) throw new Exception("LibraryDir does not exist");

                _da.LibraryDir = value;
            }
        }
        public String ProjectDir
        {
            get { return _da.ProjectDir; }
            set
            {
                if (value == string.Empty) throw new Exception("ProjectDir not specified");
                if (!Directory.Exists(value)) throw new Exception("ProjectDir does not exist");

                _da.ProjectDir = value;
            }
        }
        public String DataDir
        {
            get { return _da.DataDir; }
            set
            {
                if (value == string.Empty) throw new Exception("DataDir not specified");
                if (!Directory.Exists(value)) throw new Exception("DataDir does not exist");

                _da.DataDir = value;
            }
        }
    }
}
