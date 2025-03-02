using Collar_flange_configurator.WPF_Override.TextBox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collar_flange_configurator.WPF_Override.Custom_entries
{
    public class DoubleForm: ElementForm
    {
        private DoubleTextBox textBox;
        public DoubleForm()
        {
            textBox = new DoubleTextBox();
            textBox.FontFamily = new System.Windows.Media.FontFamily("GOST Type B");
            textBox.Width = 100;
            textBox.Height = 15;
           

            ElementStackPanel.Children.Add(textBox);
        }

        public string DoubleValue
        {
            get
            {
                return textBox.Text;
            }
            set
            {
                textBox.Text = value;
            }
        }
        public bool IsTextValid
        {
            get
            {
                return textBox.IsTextValid;
            }
            set
            {
                textBox.IsTextValid = value;
            }
        }
    }
}
