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

        protected override bool IsValidText()
        {
            try
            {
                int a = Convert.ToInt32(Text);
            }
            catch
            {
                return false;
            }

            if (Text.StartsWith('0') || Convert.ToInt32(Text) <= 0)
            {
                return false;
            }

            return true;
        }
    }
}
