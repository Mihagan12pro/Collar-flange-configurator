using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collar_flange_configurator.ViewModel.Validation_classes
{
    class AngleValidator : ParamValidator<double>
    {
        public readonly double Max, Min;
        public override bool CheckValidation(object param)
        {
            if (!double.TryParse(Convert.ToString(param), out double d))
            {
                return false;
            }
            ValidedValue = d;

            if (!(ValidedValue < Max && ValidedValue > Min))
            {
                return false;
            }
            return true;
        }

        public AngleValidator(double min,double max)
        {
            Min = min;
            Max = max;
        }
    }
}
