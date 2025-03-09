using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collar_flange_configurator.ViewModel.Validation_classes
{
    public class DoubleValidator : ParamValidator<double>
    {
        public readonly DoubleValidator[] Dominants;
        public readonly DoubleValidator[] Oppressed;

        
        public override bool CheckValidation(object param)
        {
            if (!double.TryParse(Convert.ToString(param), out double d))
            {
                return false;
            }
            Value = d;

            if (Value <= 0)
            {
                return false;
            }

            if (Dominants.Length > 0)
            { 
                foreach (DoubleValidator dominant in Dominants)
                {
                    if (dominant != null)
                    {
                        if (dominant.Value <= Value)
                        {
                            return false;
                        }
                    }
                }
            }

            if (Oppressed.Length > 0)
            {
                foreach (DoubleValidator oppressed in Oppressed)
                {
                    if (oppressed != null)
                    {
                        if (oppressed.Value >= Value)
                        {
                            return false;
                        }
                    }
                    
                }
            }
            return true;
        }

       


        public DoubleValidator(int dominatsCount,int oppressedCount)
        {
            Dominants = new DoubleValidator[dominatsCount];
            Oppressed = new DoubleValidator[oppressedCount];
        }
    }
}
