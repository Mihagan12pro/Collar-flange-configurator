using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Collar_flange_configurator.WPF_Override.TextBox
{
    internal class DoubleTextBox : NumericTextBox
    {
        public DoubleTextBox()
        {
            KeyDown += DoubleTextBox_KeyDown;
        }

        private void DoubleTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.OemComma)
            {
                e.Handled = true;

                Text += '.';

                CaretIndex = Text.Length;
            }
        }
        protected override bool TextValidation()
        {
            try
            {
                double a = Convert.ToDouble(Text);
            }
            catch
            {
                return false;
            }

            if (Convert.ToDouble(Text) <= 0)
            {
                return false;
            }

            if (Text.StartsWith('0') && Text.ToCharArray(0, Text.Length)[1] != '.')
            {
                return false;
            }

            return true;
        }
    }
}
