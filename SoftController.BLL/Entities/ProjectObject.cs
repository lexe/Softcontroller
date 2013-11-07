using System;
using System.Drawing;

                    //"ID INTEGER PRIMARY KEY NOT Null, " +
                    //"LibraryUID UNIQUEIDENTIFIER NOT Null, " +
                    //"ItemID INTEGER NOT Null, " +
                    //"MapID INTEGER NOT Null, " +
                    //"Name NVARCHAR(32), " +
                    //"X REAL NOT Null, " +
                    //"Y REAL NOT Null, " +
                    //"Angle REAL NOT Null" +

namespace SoftController.BLL.Entities
{
    public class ProjectObject
    {
        private Int32 _id;
        private Guid _libraryUID;
        private Int32 _itemID;
        private Int32 _mapID;
        private String _name;
        private PointF _position;
        private Single _angle;

        public Int32 ID
        {
            get { return _id; }
            set { _id = value; }
        }
        public Guid LibraryUID
        {
            get { return _libraryUID; }
            set { _libraryUID = value; }
        }
        public Int32 ItemID
        {
            get { return _itemID; }
            set { _itemID = value; }
        }
        public Int32 MapID
        {
            get { return _mapID; }
            set { _mapID = value; }
        }
        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public PointF Position
        {
            get { return _position; }
            set { _position = value; }
        }
        public Single Angle
        {
            get { return _angle; }
            set { _angle = value; }
        }
    }
}
