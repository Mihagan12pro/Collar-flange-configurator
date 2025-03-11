using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collar_flange_configurator.ViewModel.Validation_classes
{
    class HeightsValidator : ParamValidator
    {
        public string b { get; set; }
        public string H { get; set; }
        public string H1 { get; set; }
        public string l1 { get; set; }

        public override bool CheckValidation()
        {
            if (H1 == null || H == null || l1 == null || b == null)
                return false;

            if (H1.Length == 0 || H.Length == 0 || l1.Length == 0 || b.Length == 0)
                return false;
            if (double.TryParse(b,out double _b) && double.TryParse(H, out double _H) && double.TryParse(H1,out double _H1) &&double.TryParse(l1,out double _l1))
            {
                if (new double[4]{ _b,_H,_H1,_l1}.Max() != _H)
                {
                    return false;
                }
                if (_b <= _l1)
                {
                    return false;
                }
                if (_H - (_b+_H1)  <= 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
