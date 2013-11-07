using System;
using System.IO;

namespace SoftController.DAL
{
    public class ProjectDA : SQLiteDA
    {
        public ProjectDA(String fileName)
        {
            SQLiteFilePath = string.Format(@"{0:0}\{1:0}", Properties.Settings.Default.LibraryDir, fileName);
        }

        public static String[] Get()
        {
            return Directory.GetFiles(Properties.Settings.Default.ProjectDir, "*." + FileExtension, SearchOption.TopDirectoryOnly);
        }
        public static Boolean ProjectExists(String fileName)
        {
            return File.Exists(string.Format(@"{0:0}\{1:0}", Properties.Settings.Default.ProjectDir, fileName));
        }
        public static String FileExtension { get { return "scp"; } }

        public void Add(String name)
        {
            // create DB
            CreateFile();
            String query;

            #region CreateTables
            query = "CREATE TABLE Maps " +
                "(" +
                    "ID INTEGER PRIMARY KEY NOT Null, " +
                    "Name NVARCHAR(32) NOT Null" +
                ")";
            ExecuteNonQuery(query);
            query = "CREATE TABLE Objects " +
                "(" +
                    "ID INTEGER PRIMARY KEY NOT Null, " +
                    "LibraryUID UNIQUEIDENTIFIER NOT Null, " +
                    "ItemID INTEGER NOT Null, " +
                    "MapID INTEGER NOT Null, " +
                    "Name NVARCHAR(32), " +
                    "X REAL NOT Null, " +
                    "Y REAL NOT Null, " +
                    "Angle REAL NOT Null" +
                ")";
            ExecuteNonQuery(query);
            #endregion

            #region InitialValues
            query = "INSERT INTO Maps " +
                "(Name) VALUES " +
                "('Main')";
            ExecuteNonQuery(query);
            #endregion
        }
    }
}
