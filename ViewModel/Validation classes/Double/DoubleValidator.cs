using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collar_flange_configurator.ViewModel.Validation_classes
{
    public class DoubleValidator : ParamValidator
    {
        public List<DoubleValidator> DominantsList = new List<DoubleValidator>();
        public List<DoubleValidator> OppressedList = new List<DoubleValidator>();

        public double Value{get; private set;}
        public override bool CheckValidation(object param)
        {
            if (!double.TryParse(Convert.ToString(param), out double d))
            {
                return false;
            }
            Value = d;

            foreach(DoubleValidator dominant in DominantsList)
            {
                if (dominant.Value <= Value)
                {
                    return false;
                }
            }

            foreach(DoubleValidator oppressed in OppressedList)
            {
                if (oppressed.Value >= Value)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
