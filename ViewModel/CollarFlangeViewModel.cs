using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media.Imaging;

namespace Collar_flange_configurator.ViewModel
{
    internal class CollarFlangeViewModel : INotifyPropertyChanged
    {
        private bool isConfig3DModel;
        public bool IsConfig3DModel
        {
            get
            {
                return isConfig3DModel;
            }
            set
            {
                isConfig3DModel = value;

                AssembleVisibility = Visibility.Visible;
                TableVisibility = Visibility.Collapsed;

                if (value)
                {
                    AssembleVisibility = Visibility.Hidden;
                    TableVisibility = Visibility.Visible;
                }
                OnPropertyChanged();
            }
        }

        private Visibility assembleVisibility;
        public Visibility AssembleVisibility
        {
            get
            {
                return assembleVisibility;
            }
            private set
            {
                assembleVisibility = value;
                OnPropertyChanged();
            }
        }

        private Visibility tableVisibility;
        public Visibility TableVisibility
        {
            get
            {
                return tableVisibility;
            }
            private set
            {
                tableVisibility = value;
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
            IsConfig3DModel = true;
        }
    }
}
