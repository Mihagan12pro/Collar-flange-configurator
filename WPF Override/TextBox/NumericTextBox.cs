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
        private bool isTextValid;
        public bool IsTextValid
        {
            get
            {
                return isTextValid;
            }
            set
            {
                isTextValid = value;

                if (value)
                {
                    Foreground = Brushes.Black;
                }
                else
                {
                    Foreground = Brushes.Red;
                }
            }
        }


        public NumericTextBox()
        {
            TextChanged += NumericTextBox_TextChanged;
            FontFamily = new FontFamily("Calibry");
        }
        private void NumericTextBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            IsTextValid = TextValidation();
        }
        protected abstract bool TextValidation();
    }
}
