using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collar_flange_configurator.ViewModel.Validation_classes
{
    public abstract class IntegerValidator : ParamValidator<int>
    {
        public override bool CheckValidation(object param)
        {
            if (!int.TryParse(Convert.ToString(param),out int i))
            {
                return false;
            }
            return true;
        }
    }
}
