using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace Collar_flange_configurator.ViewModel
{
    internal class CollarFlangeViewModel : INotifyPropertyChanged
    {


        private bool textVal;
        public bool TextValid
        {
            get
            {
                return textVal;
            }
            set
            {
                textVal = value;
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




        private bool isDmValid;
        public bool IsDmValid
        {
            get
            {
                return isDmValid;
            }
            set
            {
                isDmValid = value;
                OnPropertyChanged();
            }
        }


        private bool isDnValid;
        public bool IsDnValid
        {
            get
            {
                return isDnValid;
            }
            set
            {
                isDnValid = value;
                OnPropertyChanged();
            }
        }


        private bool isd1Valid;
        public bool Isd1Valid
        {
            get
            {
                return isd1Valid;
            }
            set
            {
                isd1Valid = value;
                OnPropertyChanged();
            }
        }


        private bool isbValid;
        public bool IsbValid
        {
            get
            {
                return isbValid;
            }
            set
            {
                isbValid = value;
                OnPropertyChanged();
            }
        }


        private bool isHValid;
        public bool IsHValid
        {
            get
            {
                return isHValid;
            }
            set
            {
                isHValid = value;
                OnPropertyChanged();
            }
        }


        private bool isH1Valid;
        public bool IsH1Valid
        {
            get
            {
                return isH1Valid;
            }
           set
            {
                isH1Valid = value;
                OnPropertyChanged();
            }
        }


        private bool isDValid;
        public bool IsDValid
        {
            get
            {
                return isDValid;
            }
             set
            {
                isDValid = value;
                OnPropertyChanged();
            }
        }


        private bool isD1Valid;
        public bool IsD1Valid
        {
            get
            {
                return isD1Valid;
            }
           set
            {
                isD1Valid = value;
                OnPropertyChanged();
            }
        }


        private bool isdValid;
        public bool IsdValid
        {
            get
            {
                return isdValid;
            }
            set
            {
                isdValid = value;
                OnPropertyChanged();
            }
        }


        private bool isnValid;
        public bool IsnValid
        {
            get
            {
                return isnValid;
            }
            set
            {
                isnValid = value;
                OnPropertyChanged();
            }
        }


        private bool isl1Valid;
        public bool Isl1Valid
        {
            get
            {
                return isl1Valid;
            }
           set
            {
                isl1Valid = value;
                OnPropertyChanged();
            }
        }


        private bool isR1Valid;
        public bool IsR1Valid
        {
            get
            {
                return isR1Valid;
            }
            set
            {
                isR1Valid = value;
                OnPropertyChanged();
            }
        }


        private bool isfValid;
        public bool IsfValid
        {
            get
            {
                return isfValid;
            }
            set
            {
                isfValid = value;
                OnPropertyChanged();
            }
        }




        private double valueOfDmSize;
        public double ValueOfDmSize
        {
            get
            {
                return valueOfDmSize;
            }
            set
            {
                valueOfDmSize = value;
                OnPropertyChanged();
            }
        }


        private double valueOfDnSize;
        public double ValueOfDnSize
        {
            get
            {
                return valueOfDnSize;
            }
            set
            {
                valueOfDnSize = value;
                OnPropertyChanged();
            }
        }


        private double valueOfd1Size;
        public double ValueOfd1Size
        {
            get
            {
                return valueOfd1Size;
            }
            set
            {
                valueOfd1Size = value;
                OnPropertyChanged();
            }
        }


        private double valueOfbSize;
        public double ValueOfbSize
        {
            get
            {
                return valueOfbSize;
            }
            set
            {
                valueOfbSize = value;
                OnPropertyChanged();
            }
        }


        private double valueOfHSize;
        public double ValueOfHSize
        {
            get
            {
                return valueOfHSize;
            }
            set
            {
                valueOfHSize = value;
                OnPropertyChanged();
            }
        }


        private double valueOfH1Size;
        public double ValueOfH1Size
        {
            get
            {
                return valueOfH1Size;
            }
            set
            {
                valueOfH1Size = value;
                OnPropertyChanged();
            }
        }


        private double valueOfDSize;
        public double ValueOfDSize
        {
            get
            {
                return valueOfDSize;
            }
            set
            {
                valueOfDSize = value;
                OnPropertyChanged();
            }
        }


        private double valueOfD1Size;
        public double ValueOfD1Size
        {
            get
            {
                return valueOfD1Size;
            }
            set
            {
                valueOfD1Size = value;
                OnPropertyChanged();
            }
        }


        private double valueOfdSize;
        public double ValueOfdSize
        {
            get
            {
                return valueOfdSize;
            }
            set
            {
                valueOfdSize = value;
                OnPropertyChanged();
            }
        }


        private double valueOfnSize;
        public double ValueOfnSize
        {
            get
            {
                return valueOfnSize;
            }
            set
            {
                valueOfnSize = value;
                OnPropertyChanged();
            }
        }


        private double valueOfl1Size;
        public double ValueOfl1Size
        {
            get
            {
                return valueOfl1Size;
            }
            set
            {
                valueOfl1Size = value;
                OnPropertyChanged();
            }
        }


        private double valueOfR1Size;
        public double ValueOfR1Size
        {
            get
            {
                return valueOfR1Size;
            }
            set
            {
                valueOfR1Size = value;
                OnPropertyChanged();
            }
        }


        private double valueOffSize;
        public double ValueOffSize
        {
            get
            {
                return valueOffSize;
            }
            set
            {
                valueOffSize = value;
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

            IsR1Valid = true;
        }
    }
}
