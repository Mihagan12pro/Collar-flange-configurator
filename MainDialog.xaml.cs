using System.Windows;
using Collar_flange_configurator.ViewModel;
using System.Data.SQLite;
using System.Windows.Controls;
namespace Collar_flange_configurator
{
    /// <summary>
    /// Логика взаимодействия для MainDialog.xaml
    /// </summary>
    public partial class MainDialog : Window
    {
        public static MainDialog Dialog { get; private set; }
        public MainDialog()
        {
            DataContext = new CollarFlangeViewModel();

            InitializeComponent();

            Closing += MainDialog_Closing;


            Dialog = this;  
        }

        private void MainDialog_Closing(object? sender, System.ComponentModel.CancelEventArgs e)
        {
            Dialog = null;
        }

        private void My_Event(object sender, RoutedEventArgs e)
        {
         

            
            MessageBox.Show("Сообщение");
        }

    }
}
