using Collar_flange_configurator.database.logic.sizes.tables;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace Collar_flange_configurator.database.logic.sizes
{
    class SizesDatabase : AbstractDatabase
    {
        public readonly GOSTSizesTable GOSTTable;

        public readonly StandartSizesTable StandartTable;
    
        public SizesDatabase()
        {
            DatabaseName = $"Data Source={Path.Combine(Command.AssembleLocation,"database", "files", "sizes.db")}";

            GOSTTable = new GOSTSizesTable(this);


            StandartTable = new StandartSizesTable(this);
        }
    }
}
