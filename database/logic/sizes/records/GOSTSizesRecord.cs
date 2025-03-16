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

        private GOSTSizesTable gostSizesTable;

        protected readonly int numberOfRecord;




        private const int DmId = 0;
        private const int DnId = 1;
        private const int d1Id = 2;
        private const int bId = 3;
        private const int HId = 4;
        private const int H1Id = 5;
        private const int DId = 6;
        private const int D1Id = 7;
        private const int dId = 8;
        private const int nId = 9;
        private string SelectJoinFromGost(int size,object executedValue)
        {
            string tableName = "";

            if (executedValue == null)
                return null;

            string foreignKeyInGOST = executedValue.ToString();

            switch (size)
            {

                case DmId:
                    tableName = "DmSizes";
                    foreignKeyInGOST = "Dm_id";
                
                    break;
                
                case DnId:
                    tableName = "DnSizes";
                    foreignKeyInGOST = "Dn_id";

                    break;
                
                case d1Id:
                    tableName = "d1Sizes";
                    foreignKeyInGOST = "d1_id";

                    break;
                
                case bId:
                    tableName = "bSizes";
                    foreignKeyInGOST = "b_id";

                    break;
                
                case HId:
                    tableName = "HSizes";
                    foreignKeyInGOST = "H_id";

                    break;
                
                case H1Id:
                    tableName = "H1Sizes";
                    foreignKeyInGOST = "H1_id";

                    break;
                    
                case DId:
                    tableName = "DSizes";
                    foreignKeyInGOST = "D_id";

                    break;
                    
                case D1Id:
                    tableName = "_D1Sizes";
                    foreignKeyInGOST = "_D1_id";

                    break;

                case dId:
                    tableName = "_dSizes";
                    foreignKeyInGOST = "_d_id";

                    break;

                case nId:
                    tableName = "nSizes";
                    foreignKeyInGOST = "n_id";

                    break;

            }

            string query = $"SELECT value FROM {tableName} JOIN {gostSizesTable.TableName} ON {gostSizesTable.TableName}.{foreignKeyInGOST} = {tableName}.id WHERE {gostSizesTable.TableName}.id = {numberOfRecord.ToString()}";

            string result = "";

            using (SQLiteConnection connection = new SQLiteConnection(gostSizesTable.Database.DatabaseName))
            {
                connection.Open();

                using (SQLiteCommand command = new SQLiteCommand())
                {
                    command.CommandText = query;
                    command.Connection = connection;


                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            result = reader.GetValue(0).ToString();
                        }
                    }
                }

                connection.Close();
            }

            if (IsRecordValid(result))
                return result;

            return null;
        }


        protected override void GetInfofromRecord()
        {
            using (SQLiteConnection connection = new SQLiteConnection(gostSizesTable.Database.DatabaseName))
            {
                connection.Open();
                using (SQLiteCommand command = new SQLiteCommand($"Select * FROM {gostSizesTable.TableName} WHERE id = {numberOfRecord}"))
                {
                    command.Connection = connection;

                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            if (IsRecordValid(reader.GetValue(DmId).ToString()) && IsRecordValid(reader.GetValue(DnId).ToString()) && IsRecordValid(reader.GetValue(d1Id).ToString()) && IsRecordValid(reader.GetValue(bId).ToString()) && IsRecordValid(reader.GetValue(HId).ToString()) && IsRecordValid(reader.GetValue(H1Id).ToString()) && IsRecordValid(reader.GetValue(DId).ToString()) && IsRecordValid(reader.GetValue(D1Id).ToString()) && IsRecordValid(reader.GetValue(dId).ToString()) && IsRecordValid(reader.GetValue(nId).ToString()))
                            {
                                if (SelectJoinFromGost(DmId, reader.GetValue(DmId)) == null || SelectJoinFromGost(DnId, reader.GetValue(DnId)) == null || SelectJoinFromGost(d1Id, reader.GetValue(d1Id)) == null || SelectJoinFromGost(bId, reader.GetValue(bId)) == null || SelectJoinFromGost(HId, reader.GetValue(HId)) == null || SelectJoinFromGost(H1Id, reader.GetValue(H1Id)) == null || SelectJoinFromGost(DId, reader.GetValue(DId)) == null || SelectJoinFromGost(D1Id, reader.GetValue(D1Id)) == null || SelectJoinFromGost(dId, reader.GetValue(dId)) == null || SelectJoinFromGost(nId, reader.GetValue(nId)) == null)
                                {
                                    CurruptedRecordError();
                                }
                                else
                                {
                                    Dm = SelectJoinFromGost(DmId, reader.GetValue(DmId));
                                    Dn = SelectJoinFromGost(DnId, reader.GetValue(DnId));
                                    d1 = SelectJoinFromGost(d1Id, reader.GetValue(d1Id));
                                    b = SelectJoinFromGost(bId, reader.GetValue(bId));
                                    H = SelectJoinFromGost(HId, reader.GetValue(HId));
                                    H1 = SelectJoinFromGost(H1Id, reader.GetValue(H1Id));
                                    D = SelectJoinFromGost(DId, reader.GetValue(DId));
                                    D1 = SelectJoinFromGost(D1Id, reader.GetValue(D1Id));
                                    d = SelectJoinFromGost(dId, reader.GetValue(dId));
                                    n = SelectJoinFromGost(nId, reader.GetValue(nId));
                                }
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




        public GOSTSizesRecord(GOSTSizesTable table, int numberOfRecord) : base(table, numberOfRecord)
        {
            gostSizesTable = table;
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
    }
}
