using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Collections.ObjectModel;
namespace Collar_flange_configurator.database.logic
{
    abstract class AbstractDatabase
    {
        public string DatabaseName { get; protected set; }
        public AbstractDatabase()
        {
                
        }
    }
}
