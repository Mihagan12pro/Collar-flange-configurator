using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Multicad.Wpf.ValidationRules;
namespace Collar_flange_configurator.ViewModel.Validation_classes.Parameters
{
    abstract class Parameter
    {
        public static HashSet<string> IDs = new HashSet<string>();

        public object Value { get; set; }

        public readonly string ID;

        protected readonly CultureInfo _cultureInfo = new CultureInfo("en-US");




        public abstract bool SecondaryValidation();




        public bool PrimaryValidation()
        {
            try
            {
                double realValue = Convert.ToDouble(Value);

                return realValue > 0;
            }
            catch
            {
                return false;
            }
        }




        public Parameter(string ID)
        {
            this.ID = ID;

            IDs.Add(ID);
        }
    }
}
