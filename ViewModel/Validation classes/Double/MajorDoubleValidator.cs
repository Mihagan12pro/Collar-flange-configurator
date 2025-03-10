using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collar_flange_configurator.ViewModel.Validation_classes.Double
{
    unsafe class MajorDoubleValidator : DoubleValidator
    {
        public DoubleValidator[] Children;
        public MajorDoubleValidator(int dominatsCount, int oppressedCount,int childrenCount) : base(dominatsCount, oppressedCount)
        {
            Children = new DoubleValidator[childrenCount];
        }
        public override bool CheckValidation(object param)
        {
            if (!base.CheckValidation(param))
            {
                return false;
            }

            double value2 = ValidedValue;

            foreach(var child in Children)
            {
                value2 -= child.ValidedValue;
            }

         

            return value2 > 0;
        }
    }
}
