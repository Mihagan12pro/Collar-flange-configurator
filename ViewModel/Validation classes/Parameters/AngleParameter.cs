using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collar_flange_configurator.ViewModel.Validation_classes.Parameters
{
    class AngleParameter : RealParameter
    {
        public override bool SecondaryValidation()
        {
            return _validationRule.Validate(Value, _cultureInfo).IsValid;
        }



        public AngleParameter(string ID,double min, double max) : base(ID)
        {
            _validationRule.MinValue = min;
            _validationRule.MaxValue = max;
        }
    }
}
