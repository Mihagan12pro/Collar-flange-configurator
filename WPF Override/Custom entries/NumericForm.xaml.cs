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

    public partial class ElementForm: UserControl,INotifyPropertyChanged
    {
        public static DependencyProperty IsTextValidProperty;

        protected NumericTextBox textBox;

        private bool isTextValid;
        public bool IsTextValid
        {
            get { return (bool)base.GetValue(IsTextValidProperty); }
            set { base.SetValue(IsTextValidProperty, value); }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

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

        static ElementForm()
        {
            IsTextValidProperty = DependencyProperty.Register
            (
                "IsTextValid",
                typeof(bool),
                typeof(ElementForm)
            );
        }

        public ElementForm()
        {
            InitializeComponent();

            IsTextValid = true;
        }
    }
}
