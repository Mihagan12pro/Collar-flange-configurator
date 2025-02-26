using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows.Media;
namespace Collar_flange_configurator.WPF_Override
{
    internal abstract class NumericTextBox : System.Windows.Controls.TextBox
    {
        protected Key[] numberKeys;
        public NumericTextBox()
        {
            TextChanged += NumericTextBox_TextChanged;
        }

        private void NumericTextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (IsValidText())
            {
                Foreground = Brushes.Black;
            }
            else
            {
                Foreground = Brushes.Red;
            }
        }
        protected abstract bool IsValidText();
    }
}
