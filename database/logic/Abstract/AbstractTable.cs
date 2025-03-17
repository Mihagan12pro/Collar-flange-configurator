using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.SQLite;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Teigha.DatabaseServices;

namespace Collar_flange_configurator.database.logic.Abstract
{
    class AbstractTable
    {

        public string TableName { get; protected set; }


        public int CountOfRecords { get; protected set; }


        public AbstractDatabase Database;


        protected void GetCountOfRecords()
        {
            using (SQLiteConnection connection = new SQLiteConnection(Database.DatabaseName))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand())
                {
                    command.CommandText = $"SELECT COUNT(*) FROM {TableName}";
                    command.Connection = connection;

                    

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            CountOfRecords = Convert.ToInt32(reader.GetValue(0));
                        }
                    }
                }

                connection.Clone();
            }
        }


        public AbstractTable(AbstractDatabase database)
        {
           
        }
    }
}
