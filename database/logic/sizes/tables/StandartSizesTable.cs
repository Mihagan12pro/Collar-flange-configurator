using Collar_flange_configurator.database.logic.Abstract;
using Collar_flange_configurator.database.logic.sizes.records;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collar_flange_configurator.database.logic.sizes.tables
{
    class StandartSizesTable : AbstractTable
    {
        public readonly SizesDatabase Database;


        public StandartSizesRecord DefaultSizesRecord { get; private set; }


        public StandartSizesTable(SizesDatabase database) : base(database)
        {
            TableName = "standart_sizes";

            Database = database;

            DefaultSizesRecord = new StandartSizesRecord(this, 0);
        }
    }
}
