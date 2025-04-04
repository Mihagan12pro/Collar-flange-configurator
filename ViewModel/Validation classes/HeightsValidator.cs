using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collar_flange_configurator.ViewModel.Validation_classes
{
    class HeightsValidator : ParamValidator
    {
        public string Sizeb { get; set; }
        public string SizeH { get; set; }
        public string SizeH1 { get; set; }
        public string Sizel1 { get; set; }

        public override bool CheckValidation()
        {
            try
            {


                double b = Convert.ToDouble(Sizeb);
                double H = Convert.ToDouble(SizeH);
                double H1 = Convert.ToDouble(SizeH1);
                double l1 = Convert.ToDouble(Sizel1);


                bool IsHDominant = ((new double[] { b, H, H1, l1 }.Max() == H) && (H - (b + H1) > 0));
                bool IsbBiggerThenl1 = (b > l1);
                


                return (IsHDominant && IsbBiggerThenl1);
            }
            catch
            {
                return false;
            }
        }
    }
}
