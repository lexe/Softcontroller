using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SoftController.BLL.Entities
{
    public class ProjectMap
    {
        private Int32 _id;
        private String _name;
        private List<ProjectObject> _objects;

        public Int32 ID
        {
            get { return _id; }
            set { _id = value; }
        }
        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public List<ProjectObject> Objects
        {
            get { return _objects; }
            set { _objects = value; }
        }
    }
    public class ProjectMaps : KeyedCollection<Int32, ProjectMap>
    {
        public ProjectMaps() : base() { }

        protected override int GetKeyForItem(ProjectMap item)
        {
            return item.ID;
        }
    }
}
