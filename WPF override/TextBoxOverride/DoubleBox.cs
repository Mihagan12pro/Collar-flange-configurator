using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Collar_flange_configurator.WPF_override.TextBoxOverride
{
    class DoubleBox : IntegerBox
    {
        protected override bool IsKeyLegal(Key key)
        {
            if (key == Key.OemComma || key == Key.OemPeriod)
            {
      
                return true;
            }


            return base.IsKeyLegal(key);
        }

        private void DoubleBox_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            int indexOfComma = Text.IndexOf(',');

            if (indexOfComma > -1)
            {
                Text = Text.Replace(',','.');

                CaretIndex = indexOfComma;
            }
        }
        public DoubleBox()
        {
            TextChanged += DoubleBox_TextChanged;
        }

       
    }
}
