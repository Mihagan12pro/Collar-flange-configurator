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

        private bool isSizeDmValid, isSizeDnValid, isSized1Valid, isSizebValid, isSizeHValid, isSizeH1Valid, isSizeDValid;
        private bool isSizeD1Valid, isSizedValid, isSizeR1Valid, isSizel1Valid, isSizefValid,isCountnValid;

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
                if (value)
                {
                    AssembleVisibility = Visibility.Hidden;
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


        private bool isOkEnabled;
        public bool IsOkEnabled
        {
            get
            {
                return isOkEnabled;
            }
            private set
            {
                isOkEnabled = value;
                OnPropertyChanged();
            }
        }







       
 
        



        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        public CollarFlangeViewModel()
        {
            IsConfig3DModel = true;

            IsOkEnabled = true;
        }
    }
}
