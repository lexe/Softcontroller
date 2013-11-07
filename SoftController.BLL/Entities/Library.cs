using System;
using System.Collections.Generic;
using System.IO;
using SoftController.BLL.Components;
using SoftController.DAL;

namespace SoftController.BLL.Entities
{
    public class Library
    {
        private String _name;
        private DateTime _modified;
        private Guid _uid;
        private Int32 _build;
        private List<LibraryCategory> _categories = new List<LibraryCategory>();
        private LibraryItems _items = new LibraryItems();

        public Library()
        {
        }
        public Library(String filePath)
        {
            FileName = Path.GetFileName(filePath);
            Modified = File.GetLastWriteTime(filePath);

            Load();
        }

        public void Save()
        {
            // checks
            if (Name == null || Name.Length == 0) throw new Exception("Library name not specified");

            // save
            LibraryComp comp = new LibraryComp();
            comp.Save(this);
        }
        public void Load()
        {
            LibraryComp comp = new LibraryComp();
            comp.Load(this);
        }

        internal String FileName
        {
            get { return string.Format("{0:0}.{1:0}", Name, LibraryDA.FileExtension); }
            set
            {
                Name = Path.GetFileNameWithoutExtension(value);
            }
        }

        public String Name
        {
            get { return _name; }
            set { _name = value.Trim(); }
        }
        public DateTime Modified
        {
            get { return _modified; }
            set { _modified = value; }
        }
        public Guid UID
        {
            get { return _uid; }
            set { _uid = value; }
        }
        public Int32 Build
        {
            get { return _build; }
            set { _build = value; }
        }
        public List<LibraryCategory> Categories
        {
            get { return _categories; }
            set { _categories = value; }
        }
        public LibraryItems Items
        {
            get { return _items; }
            set { _items = value; }
        }
    }
}
