using Collar_flange_configurator.database.logic.Abstract;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collar_flange_configurator.database.logic.sizes.records
{
    abstract class AbstractSizesRecord : AbstractRecord
    {
        protected AbstractSizesRecord(AbstractTable table, int numberOfRecord) : base(table, numberOfRecord)
        {

        }

        protected override bool IsRecordValid(object value)
        {
            using (SQLiteConnection conn = new SQLiteConnection())


            return true;
        }
    }
}
