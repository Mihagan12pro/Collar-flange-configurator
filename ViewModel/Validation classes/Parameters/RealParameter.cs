using Multicad.Wpf.ValidationRules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collar_flange_configurator.ViewModel.Validation_classes.Parameters
{
    abstract class RealParameter : Parameter
    {
        protected RealValueValidationRule _validationRule = new RealValueValidationRule()
        {
            MaxIsStrict = true,
            
            MinIsStrict = true,

            MinValue = 0
        };

        protected RealParameter(string ID) : base(ID)
        {
            
        }
    }

}
