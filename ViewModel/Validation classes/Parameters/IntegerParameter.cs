using Multicad.Wpf.ValidationRules;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collar_flange_configurator.ViewModel.Validation_classes.Parameters
{
    class IntegerParameter : Parameter
    {
        protected IntegerValueValidationRule _rule;




        public override bool SecondaryValidation()
        {

            return _rule.Validate(Value,_cultureInfo).IsValid;
        }



        public void SetMax(int max)
        {
            _rule.MaxValue = max;
        }



        public void SetMax(double max)
        {
            _rule.MaxValue = Math.Floor(max);
        }




        public IntegerParameter(string ID,int min) : base(ID)
        {
            _rule = new IntegerValueValidationRule();
            _rule.MinValue = min;
        }
    }
}
