using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collar_flange_configurator.ViewModel.Validation_classes.Parameters
{
    class LinearParameter : RealParameter
    {
        public LinearParameter Oppresed;
        public LinearParameter Dominant;




        public override bool SecondaryValidation()
        {
            if (Oppresed != null)
            {
                _validationRule.MinValue = Oppresed.Value;
            }
            _validationRule.MaxValue = Dominant.Value;

            return _validationRule.Validate(Value, _cultureInfo).IsValid;
        }



        public LinearParameter(string ID) : base(ID)
        {
            _validationRule.MinValue = 0;
        }
    }
}
