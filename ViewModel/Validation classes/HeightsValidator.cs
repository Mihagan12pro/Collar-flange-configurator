using Collar_flange_configurator.ViewModel.Validation_classes.Parameters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collar_flange_configurator.ViewModel.Validation_classes
{
    class HeightsValidator : ParameterValidator
    {
        public MajorLinearParameter ParameterH = new MajorLinearParameter("H",3);

        public LinearParameter Parameter_b = new LinearParameter("b");
        
        public LinearParameter ParameterH1 = new LinearParameter("H1");

        public LinearParameter Parameter_l1 = new LinearParameter("l1");




        public override bool CheckValidation()
        {
            if (Parameter_b.PrimaryValidation() && Parameter_l1.PrimaryValidation() && ParameterH.PrimaryValidation() && ParameterH1.PrimaryValidation())
            {
                //ParameterH.OppressedParameters = new HashSet<LinearParameter>{ Parameter_b,Parameter_l1,ParameterH1};
                return ParameterH.SecondaryValidation() && 
                           Parameter_l1.SecondaryValidation() && 
                               Parameter_b.SecondaryValidation() &&
                                   ParameterH1.SecondaryValidation() &&
                                        (Convert.ToDouble(ParameterH.Value) - (Convert.ToDouble(Parameter_b.Value) + Convert.ToDouble(ParameterH1.Value)) > 0);
            }
            return false;
        }







        public HeightsValidator()
        {
            Parameter_b.Dominant = ParameterH;
            Parameter_b.Oppresed = Parameter_l1;

            Parameter_l1.Dominant = Parameter_b;
            ParameterH1.Dominant = ParameterH;

            ParameterH.OppressedParameters[0] = Parameter_b;
            ParameterH.OppressedParameters[1] = Parameter_l1;
            ParameterH.OppressedParameters[2] = ParameterH1;
        }
    }
}
