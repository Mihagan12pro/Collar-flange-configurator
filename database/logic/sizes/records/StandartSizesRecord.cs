using Collar_flange_configurator.database.logic.sizes.tables;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collar_flange_configurator.database.logic.sizes.records
{
    class StandartSizesRecord : SizesRecord
    {
        private StandartSizesTable table;

        public string l1 { get; private set; }

        public string R1 { get; private set; }

        public string f { get; private set; }

        public string D2 { get; private set; }

        private const int DmId = 1;
        private const int DnId = 2;
        private const int d1Id = 3;
        private const int bId = 4;
        private const int HId = 5;
        private const int H1Id = 6;
        private const int DId = 7;
        private const int D1Id = 8;
        private const int dId = 9;
        private const int nId = 10;
        private const int l1Id = 11;
        private const int R1Id = 12;
        private const int fId = 13;
        private const int D2Id = 14;


        protected override void GetInfofromRecord()
        {
            using (SQLiteConnection connection = new SQLiteConnection(table.Database.DatabaseName))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand($"Select * FROM {table.TableName}",connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (IsRecordValid(reader.GetValue(DmId).ToString()) && IsRecordValid(reader.GetValue(DnId).ToString()) && IsRecordValid(reader.GetValue(d1Id).ToString()) && IsRecordValid(reader.GetValue(bId).ToString()) && IsRecordValid(reader.GetValue(HId).ToString()) && IsRecordValid(reader.GetValue(H1Id).ToString()) && IsRecordValid(reader.GetValue(DId).ToString()) && IsRecordValid(reader.GetValue(D1Id).ToString()) && IsRecordValid(reader.GetValue(dId).ToString()) && IsRecordValid(reader.GetValue(nId).ToString()))
                            {

                                Dm = reader.GetValue(DmId).ToString();
                                Dn = reader.GetValue(DnId).ToString();
                                d1 = reader.GetValue(d1Id).ToString();
                                b = reader.GetValue(bId).ToString();
                                H = reader.GetValue(HId).ToString();
                                H1 = reader.GetValue(H1Id).ToString();
                                D = reader.GetValue(DId).ToString();
                                D1 = reader.GetValue(D1Id).ToString();
                                d = reader.GetValue(dId).ToString();
                                n = reader.GetValue(nId).ToString();

                                l1 = reader.GetValue(l1Id).ToString();
                                R1 = reader.GetValue(R1Id).ToString();
                                f = reader.GetValue(fId).ToString();
                                D2 = reader.GetValue(D2Id).ToString();
                            }
                            else
                            {
                                CurruptedRecordError();
                            }
                        }
                    }
                }

                connection.Close();
            }
        }


        public StandartSizesRecord(StandartSizesTable table, int numberOfRecord) : base(table, numberOfRecord)
        {

            this.table = table;

            if (IsRecordExists)
                GetInfofromRecord();
            else
                UndefinedRecordError();

        }
    }
}
