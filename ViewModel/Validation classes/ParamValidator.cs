using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Collar_flange_configurator.ViewModel.Validation_classes
{
    public unsafe abstract class ParamValidator<T>
    {
        public abstract bool CheckValidation(object param);
        public T ValidedValue { get; protected set; }

        public object UnValidedValue { get; protected set; }

        public bool *IsValid { protected get; set;}
        public void SetIsValid(bool* isValid)
        {
            IsValid = isValid;
        }

        public ParamValidator()
        {
           
        }
    }
}
