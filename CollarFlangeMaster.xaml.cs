using Collar_flange_configurator.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
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

namespace Collar_flange_configurator
{
    /// <summary>
    /// Логика взаимодействия для CollarFlangeMaster.xaml
    /// </summary>
    public partial class CollarFlangeMaster : UserControl
    {
        public CollarFlangeMaster()
        {
            InitializeComponent();
        }

        private void Image_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            MainTabImage.Height = MainTabImage.Width;
        }
    }
}
