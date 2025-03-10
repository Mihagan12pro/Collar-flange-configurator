using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Collar_flange_configurator.WPF_override.TextBoxOverride
{
    class IntegerBox : NumericBox
    {
        protected override bool IsKeyLegal(Key key)
        {
            return ((key >= Key.D0 && key <= Key.D9) ||(key >= Key.NumPad0 && key <= Key.NumPad9));
        }
    }
}
