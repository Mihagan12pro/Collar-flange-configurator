using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collar_flange_configurator.ViewModel.Validation_classes.Parameters
{
    class MajorLinearParameter : LinearParameter
    {
        public HashSet<LinearParameter> OppressedParameters = new HashSet<LinearParameter>();
        public override bool SecondaryValidation()
        {
            foreach (LinearParameter oppressedItem in OppressedParameters)
            {
                _validationRule.MinValue = oppressedItem.Value;

                if (_validationRule.Validate(Value, _cultureInfo).IsValid == false)
                {
                    return false;
                }
            }
            return true;
        }



        public MajorLinearParameter(string ID) : base(ID)
        {
            _validationRule.MaxIsStrict = false;
            _validationRule.MaxValue = Value;
        }
    }
}
