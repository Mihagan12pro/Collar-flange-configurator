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






        private bool isSizeDmValid;
        public bool IsSizeDmValid
        {
            get
            {
                return isSizeDmValid;
            }
            set
            {
                isSizeDmValid = value;
                OnPropertyChanged();
            }
        }


        private bool isSizeDnValid;
        public bool IsSizeDnValid
        {
            get
            {
                return isSizeDnValid;
            }
            set
            {
                isSizeDnValid = value;
                OnPropertyChanged();
            }
        }


        private bool isSized1Valid;
        public bool IsSized1Valid
        {
            get
            {
                return isSized1Valid;
            }
            set
            {
                isSized1Valid = value;
                OnPropertyChanged();
            }
        }


        private bool isSizebValid;
        public bool IsSizebValid
        {
            get
            {
                return isSizebValid;
            }
            set
            {
                isSizebValid = value;
                OnPropertyChanged();
            }
        }


        private bool isSizeHValid;
        public bool IsSizeHValid
        {
            get
            {
                return isSizeHValid;
            }
            set
            {
                isSizeHValid = value;
                OnPropertyChanged( );
            }
        }


        private bool isSizeH1Valid;
        public bool IsSizeH1Valid
        {
            get
            {
                return isSizeH1Valid;
            }
            set
            {
                isSizeH1Valid = value;
                OnPropertyChanged();
            }
        }


        private bool isSizeDValid;
        public bool IsSizeDValid
        {
            get
            {
                return isSizeDValid;
            }
            set
            {
                isSizeDValid = value;
                OnPropertyChanged();
            }
        }


        private bool isSizeD1Valid;
        public bool IsSizeD1Valid
        {
            get
            {
                return isSizeD1Valid;
            }
            set
            {
                isSizeD1Valid = value;
                OnPropertyChanged();
            }
        }


        private bool isSizedValid;
        public bool IsSizedValid
        {
            get
            {
                return isSizedValid;
            }
            set
            {
                isSizedValid = value;
                OnPropertyChanged();
            }
        }


        private bool isSizeR1Valid;
        public bool IsSizeR1Valid
        {
            get
            {
                return isSizeR1Valid;
            }
            set
            {
                isSizeR1Valid = value;
                OnPropertyChanged();
            }
        }


        private bool isSizel1Valid;
        public bool IsSizel1Valid
        {
            get
            {
                return isSizel1Valid;
            }
            set
            {
                isSizel1Valid = value;
                OnPropertyChanged();
            }
        }


        private bool isSizefValid;
        public bool IsSizefValid
        {
            get
            {
                return isSizefValid;
            }
            set
            {
                isSizefValid = value;
                OnPropertyChanged();
            }
        }


        private bool isCountnValid;
        public bool IsCountnValid
        {
            get
            {
                return isCountnValid;
            }
            set
            {
                isCountnValid = value;
                OnPropertyChanged();
            }
        }



        private double valueDmSize;
        public double ValueDmSize
        {
            get
            {
                return valueDmSize;
            }
            set
            {
                valueDmSize = value;
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

            IsSizeDmValid = true;
        }
    }
}
