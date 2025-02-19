using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Collar_flange_configurator.WPF_Override.TextBox
{
    internal class IntegerTextBox : NumericTextBox
    {
        public IntegerTextBox()
        {
         
        }
        protected override bool IsValideKeyDown(Key key)
        {
            if ((key >= Key.D0 && key <= Key.D9) || (key >= Key.NumPad0 && key <= Key.NumPad9))
            {
                return true;
            }
            return false;
        }
    }
}
