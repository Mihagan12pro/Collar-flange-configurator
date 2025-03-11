using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collar_flange_configurator.ViewModel.Validation_classes
{
    class DiametersValidation : ParamValidator
    {
        public string SizeD { get; set; }

        public string SizeD1 { get; set; }

        public string SizeD2 { get; set; }

        public string Sized1 { get; set; }

        public string SizeDm { get; set; }

        public string SizeDn { get; set; }

        public string SizeR1 { get; set; }

        public string Sizen { get; set; }

        public string Sized { get; set; }

        public override bool CheckValidation()
        {
            double D = Convert.ToDouble(SizeD);

            double D1 = Convert.ToDouble(SizeD1);

            double D2 = Convert.ToDouble(SizeD2);

            double d1 = Convert.ToDouble(Sized1);

            double Dm = Convert.ToDouble(SizeDm);

            double Dn = Convert.ToDouble(SizeDn);

            double R1 = Convert.ToDouble(SizeR1);

            int n = Convert.ToInt32(Sizen);

            double d = Convert.ToDouble(Sized); ;


            return true;
        }
    }
}
