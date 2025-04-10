using Mapinet.GUI.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace Collar_flange_configurator.WPF_override.TextBoxOverride
{
    abstract class NumericBox : TextBox
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

        //private void NumericBox_TextChanged(object sender, TextChangedEventArgs e)
        //{
        //     if (Text.Contains(','))
        //     {
        //        Text = Text.Replace(",",".");
        //        CaretIndex = Text.Length;
        //     }
        //}
        private void NumericBox_KeyDown(object sender, System.Windows.Input.KeyEventArgs e)
        {
           if (!IsKeyLegal(e.Key))
           {
                e.Handled = true;
           }
        }


        protected abstract bool IsKeyLegal(Key key);
        
        public NumericBox()
        {
            KeyDown += NumericBox_KeyDown;

            AllowDrop = false;

            ContextMenu = null;

            CommandBindings.Add(new CommandBinding(ApplicationCommands.Paste, (sender, e) => { }));
            CommandBindings.Add(new CommandBinding(ApplicationCommands.Redo,(sender, e) => { }));
            CommandBindings.Add(new CommandBinding(ApplicationCommands.Undo, (sender, e) => { }));
        }

       
    }
}
