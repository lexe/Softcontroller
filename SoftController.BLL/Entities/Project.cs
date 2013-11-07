using System;
using System.IO;
using SoftController.BLL.Components;
using SoftController.DAL;

namespace SoftController.BLL.Entities
{
    public class Project
    {
        private DateTime _modified;
        private String _name;
        private ProjectMaps _maps;

        public Project()
        {
        }
        public Project(String filePath)
        {
            Name = Path.GetFileNameWithoutExtension(filePath);
            Modified = File.GetLastWriteTime(filePath);

            Load();
        }

        public void Save()
        {
            // checks
            if (Name == null || Name.Length == 0) throw new Exception("Project name not specified");

            // save
            ProjectComp comp = new ProjectComp();
            comp.Save(this);
        }
        public void Load()
        {
            ProjectComp comp = new ProjectComp();

        }

        internal String FileName
        {
            get { return string.Format("{0:0}.{1:0}", Name, ProjectDA.FileExtension); }
            set
            {
                Name = Path.GetFileNameWithoutExtension(value);
            }
        }

        public DateTime Modified
        {
            get { return _modified; }
            set { _modified = value; }
        }
        public String Name
        {
            get { return _name; }
            set { _name = value.Trim(); }
        }
        public ProjectMaps Maps
        {
            get { return _maps; }
            set { _maps = value; }
        }
    }
}
