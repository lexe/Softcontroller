using System;
using System.Data;
using System.Data.SQLite;
using System.Reflection;

namespace SoftController.DAL
{
    public class SQLiteDA
    {
        private SQLiteConnection _con = new SQLiteConnection();
        private String _filePath;

        internal void CreateFile()
        {
            SQLiteConnection.CreateFile(SQLiteFilePath);
        }

        #region Queries
        public void ExecuteNonQuery(String query)
        {
            ExecuteNonQuery(query, null);
        }
        public void ExecuteNonQuery(String query, Object o)
        {
            ExecuteNonQuery(query, GetParameters(query, o));
        }
        public void ExecuteNonQuery(String query, SQLiteParameter[] parameters)
        {
            _con.Open();
            SQLiteCommand cmd = new SQLiteCommand(query, _con);
            if (parameters != null) cmd.Parameters.AddRange(parameters);
            cmd.ExecuteNonQuery();
            _con.Close();
        }

        public DataTable ExecuteReader(String query)
        {
            return ExecuteReader(query, null);
        }
        public DataTable ExecuteReader(String query, Object o)
        {
            return ExecuteReader(query, GetParameters(query, o));
        }
        public DataTable ExecuteReader(String query, SQLiteParameter[] parameters)
        {
            DataTable retVal = new DataTable();

            _con.Open();
            SQLiteCommand cmd = new SQLiteCommand(query, _con);
            if (parameters != null) cmd.Parameters.AddRange(parameters);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
            adapter.Fill(retVal);
            _con.Close();

            return retVal;
        }
        #endregion

        #region ParameterMapping
        private SQLiteParameter[] GetParameters(string query, object o)
        {
            SQLiteParameter[] retVal = new SQLiteParameter[0];

            PropertyInfo[] properties = o.GetType().GetProperties();
            for (int i = 0; i < properties.Length; i++)
            {
                if (query.Contains("@" + properties[i].Name))
                {
                    AddParameter(ref retVal, properties[i].Name, properties[i].GetValue(o, null));
                }
            }

            return retVal;
        }
        private void AddParameter(ref SQLiteParameter[] parameterCollection, String parameterName, Object value)
        {
            Array.Resize(ref parameterCollection, parameterCollection.Length + 1);

            if (value == null) value = DBNull.Value;
            parameterCollection[parameterCollection.Length - 1] = new SQLiteParameter("@" + parameterName, value);
        }
        #endregion

        public String SQLiteFilePath
        {
            get { return _filePath; }
            set { _filePath = value; _con.ConnectionString = String.Format("Data Source={0:0}; Version=3;", SQLiteFilePath); }
        }
    }
}
