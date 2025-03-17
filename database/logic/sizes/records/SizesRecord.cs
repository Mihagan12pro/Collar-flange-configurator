using Collar_flange_configurator.database.logic.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collar_flange_configurator.database.logic.sizes.records
{
    abstract class SizesRecord : AbstractRecord
    {
        public string Dm { get; protected set; }

        public string Dn { get; protected set; }

        public string d1 { get; protected set; }

        public string b { get; protected set; }

        public string H { get; protected set; }

        public string H1 { get; protected set; }

        public string D { get; protected set; }

        public string D1 { get; protected set; }

        public string d { get; protected set; }

        public string n { get; protected set; }





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


        public SizesRecord(AbstractTable table, int numberOfRecord) : base(table, numberOfRecord)
        {

        }
    }
}
