using System.Windows;
using Collar_flange_configurator.ViewModel;

using System.Data.SQLite;
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
            InitializeComponent();

            Closing += MainDialog_Closing;

            
            Dialog = this; 
            DataContext = new CollarFlangeViewModel();
            
        }

        private void MainDialog_Closing(object? sender, System.ComponentModel.CancelEventArgs e)
        {
            Dialog = null;
        }
    }
}
