using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collar_flange_configurator.ViewModel.Validation_classes
{
    class AngleValidator : ParamValidator
    {
        public readonly double Max, Min;

        public object Angle { get; set; }

        public override bool CheckValidation()
        {
            try
            {
                double angle = Convert.ToDouble(Angle);

                return (angle < Max && angle > Min);
            }

            catch
            {
                return false;
            }
        }

        public AngleValidator(double min,double max)
        {
            Min = min;
            Max = max;
        }
    }
}
