using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Collar_flange_configurator.WPF_Override.TextBox
{
    internal class DoubleTextBox : IntegerTextBox
    {
        protected override bool IsValideKeyDown(Key key)
        {
            if (base.IsValideKeyDown(key) || key == Key.OemComma)
            {
                if (key == Key.OemComma)
                {
                    if (Text.Contains(','))
                    {
                        return false;
                    }
                }
                return true;
                //else
                //{
                //    if (StartsWithZero() && (!Text.Contains(',') && key != Key.OemComma) && CaretIndex != 0)
                //    {
                //        return false;
                //    }
                //}
                //return true; 
            }
            return false;
        }
    }
}
