using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collar_flange_configurator.database.logic.sizes
{
    class SizesDatabase : AbstractDatabase
    {
        private string standartSizesTable = "standart_sizes";
        public string[] SelectFromStandartSizes()
        {
            string[] standartSizesArray = new string[14];
            using (connection = new System.Data.SQLite.SQLiteConnection(databaseName))
            {
                commandText = $"SELECT * FROM {standartSizesTable}";

                connection.Open();

                using (command = new System.Data.SQLite.SQLiteCommand(commandText,connection))
                {
                    using (reader = command.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            standartSizesArray[0] = Convert.ToString(reader.GetValue(0));
                            standartSizesArray[1] = Convert.ToString(reader.GetValue(1));
                            standartSizesArray[2] = Convert.ToString(reader.GetValue(2));
                            standartSizesArray[3] = Convert.ToString(reader.GetValue(3));
                            standartSizesArray[4] = Convert.ToString(reader.GetValue(4));
                            standartSizesArray[5] = Convert.ToString(reader.GetValue(5));
                            standartSizesArray[6] = Convert.ToString(reader.GetValue(6));
                            standartSizesArray[7] = Convert.ToString(reader.GetValue(7));
                            standartSizesArray[8] = Convert.ToString(reader.GetValue(8));
                            standartSizesArray[9] = Convert.ToString(reader.GetValue(9));
                            standartSizesArray[10] = Convert.ToString(reader.GetValue(10));
                            standartSizesArray[11] = Convert.ToString(reader.GetValue(11));
                            standartSizesArray[12] = Convert.ToString(reader.GetValue(12));
                            standartSizesArray[13] = Convert.ToString(reader.GetValue(13));
                        }
                    }
                }

                connection.Close();
            }

            return standartSizesArray;
        }



        public SizesDatabase()
        {
            databaseName = "Data Source=..\\..\\..\\..\\database\\files\\sizes.db";
        }
    }
}
