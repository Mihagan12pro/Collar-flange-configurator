using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Collar_flange_configurator.WPF_Override
{
    internal abstract class CustomTextBox : TextBox
    {
        public CustomTextBox()
        {
            KeyDown += CustomTextBox_KeyDown;
        }
        private void CustomTextBox_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
            NumberValidation(sender,e);
        }
        protected abstract void NumberValidation(object sender, System.Windows.Input.KeyEventArgs e);
    }
}
