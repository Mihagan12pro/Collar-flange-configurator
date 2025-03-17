using Collar_flange_configurator.database.logic.sizes.tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collar_flange_configurator.database.logic.sizes.records
{
    class StandartSizesRecord : SizesRecord
    {
        public StandartSizesRecord(StandartSizesTable table, int numberOfRecord) : base(table, numberOfRecord)
        {
            if (IsRecordExists)
                GetInfofromRecord();
            else
                UndefinedRecordError();

        }

        protected override void GetInfofromRecord()
        {
            throw new NotImplementedException();
        }
    }
}
