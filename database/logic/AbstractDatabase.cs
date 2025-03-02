using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Data.SQLite;
using System.Collections.ObjectModel;
namespace Collar_flange_configurator.database.logic
{
    abstract class AbstractDatabase
    {
        protected string databaseName;
        public AbstractDatabase()
        {
            
        }

        //protected virtual ObservableCollection<string> Select(string table, string message)
        //{
        //    ObservableCollection<string> data = new ObservableCollection<string>();
        //    using (SQLiteConnection connection = new SQLiteConnection(databaseName))
        //    {
        //        using (SQLiteCommand select = new SQLiteCommand("SELECT "+message+" FROM " + table,connection))
        //        {
        //             using (SQLiteDataReader reader = select.ExecuteReader())
        //             {
        //                data.Add(reader.GetString(0));
        //             }
        //        }
        //        connection.Close();
        //    }
        //    return data;
        //}
    }
}
