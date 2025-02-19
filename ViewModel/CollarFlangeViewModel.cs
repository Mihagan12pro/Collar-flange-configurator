using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace Collar_flange_configurator.ViewModel
{
    internal class CollarFlangeViewModel : INotifyPropertyChanged
    {
        private BitmapImage mainTabPlaceholder;
        public BitmapImage MainTabPlaceholder
        {
            get
            {
                return mainTabPlaceholder;
            }
            private set
            {
                mainTabPlaceholder = value;
                OnPropertyChanged();
            }
        }


        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }


        public CollarFlangeViewModel()
        {
            MainTabPlaceholder = new BitmapImage(new Uri(new FileInfo(@"..\..\..\..\Images\Placeholders\MainTab Placeholder.bmp").FullName));
        }
    }
}
