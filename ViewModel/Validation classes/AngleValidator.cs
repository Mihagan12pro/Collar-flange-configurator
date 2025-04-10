using Collar_flange_configurator.ViewModel.Validation_classes.Parameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collar_flange_configurator.ViewModel.Validation_classes
{
    class AngleValidator : ParameterValidator
    {
        public AngleParameter AngleParameter;





        public override bool CheckValidation()
        {
            if (AngleParameter.PrimaryValidation())
            {
                return AngleParameter.SecondaryValidation();
            }
            return false;
        }




        public AngleValidator(string ID,double min,double max)
        {
            AngleParameter = new AngleParameter(ID,min,max);
        }
    }
}
