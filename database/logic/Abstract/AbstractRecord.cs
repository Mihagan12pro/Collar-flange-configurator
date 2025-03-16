using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Collar_flange_configurator.database.logic.Abstract
{
    abstract class AbstractRecord
    {
        protected AbstractTable table;
        public AbstractRecord(AbstractTable table,int numberOfRecord)
        {

            

        }


        protected abstract void GetInfofromRecord();


        protected abstract bool IsRecordValid(object value);


        public static void UndefinedRecordError()
        {
            MessageBox.Show("Запись не найдена!","Ошибка",MessageBoxButton.OK,MessageBoxImage.Error);
        }


        public static void CurruptedRecordError()
        {
            MessageBox.Show("Битая запись!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }
}
