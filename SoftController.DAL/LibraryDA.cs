using System;
using System.IO;
using System.Data;
using System.Data.SQLite;

namespace SoftController.DAL
{
    public class LibraryDA : SQLiteDA
    {
        public LibraryDA(String fileName)
        {
            SQLiteFilePath = string.Format(@"{0:0}\{1:0}", Properties.Settings.Default.LibraryDir, fileName);
        }

        public static String[] Get()
        {
            return Directory.GetFiles(Properties.Settings.Default.LibraryDir, "*." + FileExtension, SearchOption.TopDirectoryOnly);
        }
        public static Boolean LibraryExists(String fileName)
        {
            return File.Exists(string.Format(@"{0:0}\{1:0}", Properties.Settings.Default.LibraryDir, fileName));
        }
        public static String FileExtension { get { return "scl"; } }

        public String GetParameter(String parName)
        {
            SQLiteParameter[] parameters = new SQLiteParameter[1];
            parameters[0] = new SQLiteParameter("@Name", parName);
            DataTable data = ExecuteReader("SELECT Value FROM Parameters WHERE Name=@Name", parameters);

            return (String)data.Rows[0][0];
        }
        public void AddParameter(String parName, Object parValue)
        {
            SQLiteParameter[] parameters = new SQLiteParameter[2];
            parameters[0] = new SQLiteParameter("@Name", parName);
            parameters[1] = new SQLiteParameter("@Value", parValue);
            DataTable data = ExecuteReader("INSERT INTO Parameters (Name, Value) VALUES (@Name, @Value)", parameters);
        }
        public void UpdateParameter(String parName, Object parValue)
        {
            SQLiteParameter[] parameters = new SQLiteParameter[2];
            parameters[0] = new SQLiteParameter("@Name", parName);
            parameters[1] = new SQLiteParameter("@Value", parValue);
            DataTable data = ExecuteReader("UPDATE Parameters SET Value=@Value WHERE Name=@Name", parameters);
        }

        public void Add()
        {
            // create DB
            CreateFile();
            String query;

            #region CreateTables
            query = "CREATE TABLE Parameters " +
                "(" + 
                    "Name NVARCHAR(32) PRIMARY KEY NOT Null, " +
                    "Value NVARCHAR(32) NOT Null" +
                ")";
            ExecuteNonQuery(query);
            query = "CREATE TABLE Categories " +
                "(" +
                    "ID INTEGER PRIMARY KEY NOT Null, " +
                    "CategoryID INTEGER NOT Null, " +
                    "Name NVARCHAR(32) NOT Null" +
                ")";
            ExecuteNonQuery(query);
            query = "CREATE TABLE Items " +
                "(" +
                    "ID INTEGER PRIMARY KEY NOT Null, " +
                    "CategoryID INTEGER NOT Null, " +
                    "Name NVARCHAR(32) NOT Null" +
                ")";
            ExecuteNonQuery(query);
            query = "CREATE TABLE UIElements " +
                "(" +
                    "ID INTEGER PRIMARY KEY NOT Null, " +
                    "ItemID INTEGER NOT Null, " +
                    "Definition NVARCHAR(64) NOT Null" +
                ")";
            ExecuteNonQuery(query);
            #endregion
        }

        public DataTable GetCategories()
        {
            return ExecuteReader("SELECT * FROM Categories ORDER BY Name");
        }
        public Int64 AddCategory(object o)
        {
            DataTable data = ExecuteReader("INSERT INTO Categories (CategoryID, Name) VALUES (@CategoryID, @Name); SELECT last_insert_rowid();", o);
            return Convert.ToInt64(data.Rows[0][0]);
        }
        public void DeleteCategory(object o)
        {
            ExecuteNonQuery("DELETE FROM Categories WHERE ID=@ID", o);
        }

        public DataTable GetItems()
        {
            return ExecuteReader("SELECT * FROM Items ORDER BY Name");
        }
        public Int64 AddItem(object o)
        {
            DataTable data = ExecuteReader("INSERT INTO Items (CategoryID, Name) VALUES (@CategoryID, @Name); SELECT last_insert_rowid();", o);
            return Convert.ToInt64(data.Rows[0][0]);
        }
        public void DeleteItem(object o)
        {
            ExecuteNonQuery("DELETE FROM Items WHERE ID=@ID", o);
        }

        public DataTable GetUIElements(Int64 itemID)
        {
            SQLiteParameter[] parameters =new SQLiteParameter[1];
            parameters[0] = new SQLiteParameter("@ItemID", itemID);

            return ExecuteReader("SELECT * FROM UIElements WHERE ItemID=@ItemID", parameters);
        }
        public void AddUIElement(object o)
        {
            ExecuteNonQuery("INSERT INTO UIElements (ItemID, Definition) VALUES (@ItemID, @Definition)", o);
        }
        public void UpdateUIElement(object o)
        {
            ExecuteNonQuery("UPDATE UIElements SET Definition=@Definition WHERE ID=@ID", o);
        }
        public void DeleteUIElement(object o)
        {
            ExecuteNonQuery("DELETE FROM UIElements WHERE ID=@ID", o);
        }
    }
}
