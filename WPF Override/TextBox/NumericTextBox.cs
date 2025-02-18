using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace Collar_flange_configurator.WPF_Override
{
    internal abstract class NumericTextBox : TextBox
    {

        public NumericTextBox()
        {
            KeyDown += CustomTextBox_KeyDown;
            LostFocus += CustomTextBox_LostFocus;
        }

        private void CustomTextBox_LostFocus(object sender, System.Windows.RoutedEventArgs e)
        {
            if (Text.Length == 0)
            {
                Text += "0";
            }
        }

        private void CustomTextBox_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
           if (!IsValideKeyDown(e.Key))
           {
                e.Handled = true;
           }
        }

        protected virtual bool IsValideKeyDown(System.Windows.Input.Key key)
        {
            if (key < Key.D0 || key > Key.D9)
            {
                return false;
            }
            return true;
        }
    }
}
