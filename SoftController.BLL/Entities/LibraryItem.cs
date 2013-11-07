using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using SoftController.BLL.Components;

namespace SoftController.BLL.Entities
{
    public class LibraryItem
    {
        private Int64 _id;
        private Int64 _categoryID;
        private String _name;

        private List<LibraryUIElement> _uiElements = new List<LibraryUIElement>();

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

        public List<LibraryUIElement> UIElements
        {
            get { return _uiElements; }
            set { _uiElements = value; }
        }
    }
    public class LibraryItems : KeyedCollection<Int64, LibraryItem>
    {
        public LibraryItems() : base() { }

        protected override long GetKeyForItem(LibraryItem item)
        {
            return item.ID;
        }
    }
}
