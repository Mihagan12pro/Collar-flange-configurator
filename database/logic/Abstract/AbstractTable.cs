using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.SQLite;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Collar_flange_configurator.database.logic.Abstract
{
    class AbstractTable
    {
        protected readonly string textOfQuery;


        //public event PropertyChangedEventHandler? PropertyChanged;
        //protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        //{
        //    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        //}


        public string TableName { get; protected set; }


        public int CountOfRecords { get; protected set; }


    

       
        public AbstractTable(AbstractDatabase database)
        {
            textOfQuery = database.DatabaseName;
        }
    }
}
