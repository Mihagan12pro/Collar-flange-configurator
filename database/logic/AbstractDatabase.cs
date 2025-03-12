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
        protected string databaseName;

        protected SQLiteConnection connection;

        protected SQLiteCommand command;
        
        protected SQLiteDataReader reader;

        protected string commandText;

        public AbstractDatabase()
        {
                
        }
    }
}
