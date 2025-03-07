using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collar_flange_configurator.ViewModel.Validation_classes
{
    public class DoubleValidator : ParamValidator<double>
    {
        public List<DoubleValidator> DominantsList = new List<DoubleValidator>();
        public List<DoubleValidator> OppressedList = new List<DoubleValidator>();

        
        public override bool CheckValidation(object param)
        {
            if (!double.TryParse(Convert.ToString(param), out double d))
            {
                return false;
            }
            Value = d;

            if (DominantsList.Count > 0)
            { 
                foreach (DoubleValidator dominant in DominantsList)
                {
                    if (dominant.Value <= Value)
                    {
                        return false;
                    }
                }
            }

            if (OppressedList.Count > 0)
            {
                foreach (DoubleValidator oppressed in OppressedList)
                {
                    if (oppressed.Value >= Value)
                    {
                        return false;
                    }
                }
            }

            return true;
        }
    }
}
