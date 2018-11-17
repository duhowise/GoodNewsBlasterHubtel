using System;
using System.Data;

namespace GoodNewsBlaster.Sms
{
    public static class DataObjectExtensions
    {
        public static T ToDataObject<T>(this DataRow dataRow) where T : new()
        {
            var dataObject = Activator.CreateInstance<T>();
            var tpDataObject = dataObject.GetType();

            foreach (var property in tpDataObject.GetProperties())
            {
                var attributes = property.GetCustomAttributes(typeof(DataColumnAttribute), true);
                if (null != attributes && attributes.Length > 0)
                {
                    if (property.CanWrite)
                    {
                        DataColumn clm = dataRow.Table.Columns[property.Name];
                        if (null != clm)
                        {
                            object value = dataRow[clm];
                            property.SetValue(dataObject, value, null);
                        }
                    }
                }
            }

            return dataObject;
        }
    }
}