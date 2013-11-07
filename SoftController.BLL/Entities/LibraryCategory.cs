using System;

namespace SoftController.BLL.Entities
{
    public class LibraryCategory
    {
        private Int64 _id;
        private Int64 _categoryID;
        private String _name;

        public Int64 ID
        {
            get { return _id; }
            set { _id = value; }
        }
        public Int64 CategoryID
        {
            get { return _categoryID; }
            set { _categoryID = value; }
        }
        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }
}
