using Collar_flange_configurator.database.logic.Abstract;
using Collar_flange_configurator.database.logic.sizes.tables;
using System.Data.SQLite;

namespace Collar_flange_configurator.database.logic.sizes.records
{
    class GOSTSizesRecord : AbstractRecord
    {
        public string Dm { get; protected set; }
        
        public string Dn { get; protected set; }

        public string d1 { get;protected set; }

        public string b { get; protected set; }

        public string H { get; protected set; }

        public string H1 { get; protected set; }

        public string D { get; protected set; }

        public string D1 { get; protected set; }

        public string d { get; protected set; }

        public string n { get; protected set; }

        private GOSTSizesTable sizesTable;

        protected readonly int numberOfRecord;

        public GOSTSizesRecord(GOSTSizesTable table, int numberOfRecord): base(table,numberOfRecord)
        {
            sizesTable = table;
            this.numberOfRecord = numberOfRecord;

            if (table.CountOfRecords >= numberOfRecord || numberOfRecord >= 1)
            {
                GetInfofromRecord();
            }
            else
            {
                UndefinedRecordError();
            }
        }


        protected override void GetInfofromRecord()
        {
           using (SQLiteConnection connection = new SQLiteConnection(sizesTable.Database.DatabaseName))
           {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand($"Select * FROM {sizesTable.TableName} WHERE id = {numberOfRecord}"))
                {
                    command.Connection = connection;

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            if (IsRecordValid(reader.GetValue(0).ToString()) && IsRecordValid(reader.GetValue(1).ToString()) && IsRecordValid(reader.GetValue(2).ToString()) && IsRecordValid(reader.GetValue(3).ToString()) && IsRecordValid(reader.GetValue(4).ToString()) && IsRecordValid(reader.GetValue(5).ToString()) && IsRecordValid(reader.GetValue(6).ToString()) && IsRecordValid(reader.GetValue(7).ToString()) && IsRecordValid(reader.GetValue(8).ToString()) && IsRecordValid(reader.GetValue(8).ToString()))
                            {
                                Dm = reader.GetValue(0).ToString();
                                Dn = reader.GetValue(1).ToString();
                                d1 = reader.GetValue(2).ToString();
                                b = reader.GetValue(3).ToString();
                                H = reader.GetValue(4).ToString();
                                H1 = reader.GetValue(5).ToString();
                                D = reader.GetValue(6).ToString();
                                D1 = reader.GetValue(7).ToString();
                                d = reader.GetValue(8).ToString();
                                n = reader.GetValue(9).ToString();
                            }
                        }
                    }
                }

                connection.Close();
           }
        }


        protected override bool IsRecordValid(object value)
        {
            string str;

            try
            {
                str = Convert.ToString(value);

                if (!double.TryParse(str, out double real))
                {
                    return false;
                }
                return (real > 0);
            }
            catch
            {
                return false;
            }
        }
    }
}
