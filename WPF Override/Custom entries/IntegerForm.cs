using Collar_flange_configurator.WPF_Override.TextBox;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Collar_flange_configurator.WPF_Override.Custom_entries
{
    public class IntegerForm : ElementForm
    {
       
      
        
        public IntegerForm()
        {
            textBox = new IntegerTextBox();
            textBox.Width = 100;
            textBox.Height = 15;

            ElementStackPanel.Children.Add(textBox);
        }

        public string IntegerValue
        {
            get
            {
                return (textBox as IntegerTextBox).Text;
            }
            set
            {
                (textBox as IntegerTextBox).Text = value;
            }
        }
    }
}
