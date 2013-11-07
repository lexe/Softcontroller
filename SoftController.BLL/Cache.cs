using System;
using System.Collections.Generic;
using SoftController.BLL.Components;
using SoftController.BLL.Entities;

namespace SoftController.BLL
{
    public static class Cache
    {
        public static void Initialize()
        {
            LibraryComp comp = new LibraryComp();
            Libraries = comp.Get();
        }

        private static List<Library> _libraries = new List<Library>();
        public static List<Library> Libraries
        {
            get { return Cache._libraries; }
            set { Cache._libraries = value; }
        }
    }
}
