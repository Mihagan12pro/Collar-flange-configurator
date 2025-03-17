using Collar_flange_configurator.database.logic.Abstract;
using Collar_flange_configurator.database.logic.sizes.records;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.SQLite;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Teigha.GraphicsInterface;

namespace Collar_flange_configurator.database.logic.sizes.tables
{
    class GOSTSizesTable : AbstractTable
    {
        public readonly SizesDatabase Database;
        

        public readonly ObservableCollection<GOSTSizesRecord> GOSTSizesRecords;


        public GOSTSizesTable(SizesDatabase database) : base(database)
        {
           Database = database;

           GOSTSizesRecords = new ObservableCollection<GOSTSizesRecord>();

           TableName = "gost_33259_2015";

           using (SQLiteConnection connection = new SQLiteConnection(Database.DatabaseName))
           {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand())
                {
                    command.CommandText = $"SELECT COUNT(*) FROM {TableName}";
                    command.Connection = connection;

                    //CountOfRecords = command.ExecuteNonQuery();
                    //var a = CountOfRecords;


                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            CountOfRecords = Convert.ToInt32( reader.GetValue(0));
                        }
                    }
                }

                connection.Clone();
           }

           for(int i = 0; i < CountOfRecords; i++)
           {
                GOSTSizesRecords.Add(new GOSTSizesRecord(this,i + 1));    
           }
        }
    }
}
