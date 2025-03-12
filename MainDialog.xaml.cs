using System.Windows;
using Collar_flange_configurator.ViewModel;
namespace Collar_flange_configurator
{
    /// <summary>
    /// Логика взаимодействия для MainDialog.xaml
    /// </summary>
    public partial class MainDialog : Window
    {
        public MainDialog()
        {
            InitializeComponent();

           
            DataContext = new CollarFlangeViewModel();
        }

       
    }
}
