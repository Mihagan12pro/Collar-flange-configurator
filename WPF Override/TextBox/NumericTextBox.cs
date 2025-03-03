using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
namespace Collar_flange_configurator.WPF_Override
{
    public abstract class NumericTextBox : System.Windows.Controls.TextBox
    {
        public static DependencyProperty IsTextValidProperty;
        public bool IsTextValid
        {
            get
            {
                return (bool)GetValue(HeightProperty); ;
            }
            set
            {
                if (value)
                {
                    Foreground = Brushes.Black;
                }
                else
                {
                    Foreground = Brushes.Red;
                }
                SetValue(IsTextValidProperty,value);
            }
        }

        static NumericTextBox()
        {
            IsTextValidProperty = DependencyProperty.Register
            (
                "IsTextValid",
                typeof(bool),
                typeof(NumericTextBox)
            );
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
