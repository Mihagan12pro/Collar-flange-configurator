using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Collar_flange_configurator.ViewModel.Validation_classes
{
    public abstract class ParamValidator<T>
    {
        public abstract bool CheckValidation(object param);
        public T Value { get; protected set; }
    }
}
