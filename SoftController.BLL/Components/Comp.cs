using System;
using System.Data;
using System.Reflection;

namespace SoftController.BLL.Components
{
    public class Comp
    {
        internal static Object CreateInstance(DataRow dataRow, Type objectType)
        {
            object retVal = Activator.CreateInstance(objectType);

            PropertyInfo[] properties = retVal.GetType().GetProperties();
            foreach (PropertyInfo property in properties)
            {
                if (dataRow.Table.Columns.Contains(property.Name) &&
                    !DBNull.Value.Equals(dataRow[property.Name]))
                {
                    property.SetValue(retVal, dataRow[property.Name], null);
                }
            }

            return retVal;
        }
    }
}
