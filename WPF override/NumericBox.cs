using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Collar_flange_configurator.WPF_override
{
    class NumericBox : TextBox
    {
        public bool IsTextValid
        {
            get => (bool)GetValue(IsTextValidProperty);
            set
            {
                SetValue(IsTextValidProperty, value);
            }
        }

        private static void IsTextValidChanged(DependencyObject depObj, DependencyPropertyChangedEventArgs args)
        {
            NumericBox nt = (NumericBox)depObj;
            bool valid = (bool)args.NewValue;

            nt.Foreground = valid ? Brushes.Black : Brushes.Red;
        }

        public static readonly DependencyProperty IsTextValidProperty = DependencyProperty.Register
        (
                "IsTextValid",
                typeof(bool),
                typeof(NumericBox),
                new FrameworkPropertyMetadata(true, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault, new PropertyChangedCallback(IsTextValidChanged))
        );
    }
}
