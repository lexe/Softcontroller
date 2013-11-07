using System;
using System.Collections.Generic;
using System.Data;
using SoftController.BLL.Entities;
using SoftController.DAL;

namespace SoftController.BLL.Components
{
    public class LibraryComp
    {
        public List<Library> Get()
        {
            List<Library> retVal = new List<Library>();

            foreach (string libraryFile in LibraryDA.Get())
            {
                Library library = new Library(libraryFile);
                retVal.Add(library);
            }

            return retVal;
        }
        public void Add(Library library)
        {
            library.UID = Guid.NewGuid();
            library.Build = 1;

            LibraryDA da = new LibraryDA(library.FileName);
            da.Add();
            da.AddParameter("UID", Guid.NewGuid().ToString());
            da.AddParameter("Build", 1);

            // update cache
            Cache.Libraries.Add(library);
        }
        public void Update(Library library)
        {
            LibraryDA da = new LibraryDA(library.FileName);
            da.UpdateParameter("Build", library.Build);

            // update cache
            library.Build++;
        }

        public void Save(Library library)
        {
            if (!LibraryDA.LibraryExists(library.FileName)) Add(library);
            else Update(library);
        }
        public void Load(Library library)
        {
            LibraryDA da = new LibraryDA(library.FileName);

            // parameters
            library.UID = new Guid(da.GetParameter("UID"));
            library.Build = Convert.ToInt32(da.GetParameter("Build"));

            // data
            library.Categories = new List<LibraryCategory>();
            foreach (DataRow row in da.GetCategories().Rows) library.Categories.Add((LibraryCategory)Comp.CreateInstance(row, typeof(LibraryCategory)));
            library.Items = new LibraryItems();
            foreach (DataRow row in da.GetItems().Rows)
            {
                LibraryItem item = (LibraryItem)Comp.CreateInstance(row, typeof(LibraryItem));
                library.Items.Add(item);
                foreach (DataRow rowElement in da.GetUIElements(item.ID).Rows)
                {
                    string def = Convert.ToString(rowElement["Definition"]);
                    if (def.StartsWith("L;"))
                    {
                        item.UIElements.Add((UILine)Comp.CreateInstance(rowElement, typeof(UILine)));
                    }
                }
            }
        }

        public void AddCategory(Library library, LibraryCategory category)
        {
            LibraryDA da = new LibraryDA(library.FileName);
            category.ID = da.AddCategory(category);

            // update cache
            library.Categories.Add(category);
        }
        public void DeleteCategory(Library library, LibraryCategory category)
        {
            LibraryDA da = new LibraryDA(library.FileName);
            da.DeleteCategory(category);

            // update cache
            library.Categories.Remove(category);
        }

        public void AddItem(Library library, LibraryItem item)
        {
            LibraryDA da = new LibraryDA(library.FileName);
            item.ID = da.AddItem(item);

            // update cache
            library.Items.Add(item);
        }
        public void UpdateItem(Library library, LibraryItem item)
        {
            LibraryDA da = new LibraryDA(library.FileName);

            foreach (LibraryUIElement element in item.UIElements) da.UpdateUIElement(element);
        }
        public void DeleteItem(Library library, LibraryItem item)
        {
            LibraryDA da = new LibraryDA(library.FileName);
            da.DeleteItem(item);

            // update cache
            library.Items.Remove(item);
        }

        public void AddUIElement(Library library, LibraryUIElement element)
        {
            LibraryDA da = new LibraryDA(library.FileName);
            da.AddUIElement(element);

            // update cache
            library.Items[element.ItemID].UIElements.Add(element);
        }
        public void UpdateUIElement(Library library, LibraryUIElement element)
        {
            LibraryDA da = new LibraryDA(library.FileName);
            da.UpdateUIElement(element);
        }
        public void DeleteUIElement(Library library, LibraryUIElement element)
        {
            LibraryDA da = new LibraryDA(library.FileName);
            da.DeleteUIElement(element);

            // update cache
            library.Items[element.ItemID].UIElements.Remove(element);
        }
    }
}
