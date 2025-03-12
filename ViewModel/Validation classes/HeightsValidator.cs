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
            if (SizeH1 == null || SizeH == null || Sizel1 == null || Sizeb == null)
                return false;

            if (SizeH1.Length == 0 || SizeH.Length == 0 || Sizel1.Length == 0 || Sizeb.Length == 0)
                return false;


            double b = Convert.ToDouble(Sizeb);
            double H = Convert.ToDouble(SizeH);
            double H1 = Convert.ToDouble(SizeH1);
            double l1 = Convert.ToDouble(Sizel1);


            if (new double[4]{ b,H,H1,l1}.Max() != H)
            {
               return false;
            }

            if (b <= l1)
            {
               return false;
            }

            if (H - (b+H1)  <= 0)
            {
                return false;
            }
            return true;
        }
    }
}
