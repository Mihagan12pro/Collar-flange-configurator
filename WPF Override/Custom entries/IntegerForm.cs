using Collar_flange_configurator.WPF_Override.TextBox;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Collar_flange_configurator.WPF_Override.Custom_entries
{
    public class IntegerForm : ElementForm
    {
        private IntegerTextBox textBox;
        public IntegerForm()
        {
            textBox = new IntegerTextBox();
            textBox.FontFamily = new System.Windows.Media.FontFamily("GOST Type B");
            textBox.Width = 100;
            textBox.Height = 15;

            ElementStackPanel.Children.Add(textBox);
        }

        public string IntegerValue
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
    }
}
