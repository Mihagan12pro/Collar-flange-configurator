using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Collar_flange_configurator.WPF_Override.Custom_entries
{
    /// <summary>
    /// Логика взаимодействия для IntegerForm.xaml
    /// </summary>
    public abstract partial class ElementForm: UserControl
    {
        public string LabelText
        {
            get
            {
                return (string)ElementLabel.Content;
            }
            set
            {
                ElementLabel.Content = value;
            }
        }

        public bool IsTextValid { get; }

        public ElementForm()
        {
            InitializeComponent();  
        }
    }
}
