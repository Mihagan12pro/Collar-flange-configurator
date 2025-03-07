using Collar_flange_configurator.ViewModel.Validation_classes;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace Collar_flange_configurator.ViewModel
{
    internal class CollarFlangeViewModel : INotifyPropertyChanged
    {
        private readonly DoubleValidator Dm = new DoubleValidator();
        private readonly DoubleValidator Dn = new DoubleValidator();
        private readonly DoubleValidator d = new DoubleValidator();
        private readonly DoubleValidator b = new DoubleValidator();
        private readonly DoubleValidator l1 = new DoubleValidator();
        private readonly AngleValidator f = new AngleValidator(0,90);
        private readonly DoubleValidator d1 = new DoubleValidator();
        private readonly DoubleValidator D = new DoubleValidator();
        private readonly DoubleValidator D1 = new DoubleValidator();
        private readonly DoubleValidator D2 = new DoubleValidator();
        private readonly DoubleValidator R1 = new DoubleValidator();
        private readonly DoubleValidator H = new DoubleValidator();
        private readonly DoubleValidator H1 = new DoubleValidator();


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
                OnValidationPropertyChanged();
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
                OnValidationPropertyChanged();
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
                OnValidationPropertyChanged();
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
                OnValidationPropertyChanged();
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
                OnValidationPropertyChanged();
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
                OnValidationPropertyChanged();
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
                OnValidationPropertyChanged();
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
                OnValidationPropertyChanged();
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
                OnValidationPropertyChanged();
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
                OnValidationPropertyChanged();
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
                OnValidationPropertyChanged();
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
                OnValidationPropertyChanged();
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
                OnValidationPropertyChanged();
            }
        }

        private bool isH2Valid;
        public bool IsH2Valid
        {
            get
            {
                return isH2Valid;
            }
            set
            {
                isH2Valid = value;
                OnValidationPropertyChanged();
            }
        }








        private string valueOfDmSize;
        public string ValueOfDmSize
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


        private string valueOfDnSize;
        public string ValueOfDnSize
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


        private string valueOfd1Size;
        public string ValueOfd1Size
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


        private string valueOfbSize;
        public string ValueOfbSize
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


        private string valueOfHSize;
        public string ValueOfHSize
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


        private string valueOfH1Size;
        public string ValueOfH1Size
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


        private string valueOfDSize;
        public string ValueOfDSize
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


        private string valueOfD1Size;
        public string ValueOfD1Size
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


        private string valueOfdSize;
        public string ValueOfdSize
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


        private string valueOfnSize;
        public string ValueOfnSize
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


        private string valueOfl1Size;
        public string ValueOfl1Size
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


        private string valueOfR1Size;
        public string ValueOfR1Size
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


        private string valueOffSize;
        public string ValueOffSize
        {
            get
            {
                return valueOffSize;
            }
            set
            {
                valueOffSize = value;
                IsfValid = f.CheckValidation(valueOffSize);
                OnPropertyChanged();
            }
        }
        //IsH2Valid


        private string valueOfH2Size;
        public string ValueOfH2Size
        {
            get
            {
                return valueOfH2Size;
            }
            set
            {
                valueOfH2Size = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        public event PropertyChangedEventHandler ValidationPropertyChanged;
        protected void OnValidationPropertyChanged([CallerMemberName] string paramName = null)
        {
            ValidationPropertyChanged?.Invoke(this, new PropertyChangedEventArgs(paramName));

            IsOkEnabled =
            (
                IsDmValid
                            &&
                IsDnValid
                            &&
                Isd1Valid
                            &&
                IsbValid
                            &&
                IsHValid
                            &&
                IsH1Valid
                            &&
                IsDValid
                            &&
                IsD1Valid
                            &&
                IsdValid
                            &&
                IsnValid
                            &&
                Isl1Valid
                            &&
                IsR1Valid
                            &&
                IsfValid
                            &&
                IsH2Valid
            );
        }


        public CollarFlangeViewModel()
        {
            IsConfig3DModel = true;

            IsDmValid = true;

            IsDnValid = true;

            Isd1Valid = true;

            IsbValid = true;

            IsHValid = true;

            IsH1Valid = true;

            IsDValid = true;

            IsD1Valid = true;

            IsdValid = true;

            IsnValid = true;

            Isl1Valid = true;

            IsR1Valid = true;

            IsfValid = true;

            IsH2Valid = false;



            //Dm.DominantsList = new List<DoubleValidator>{D,D1 };
            //Dm.OppressedList = new List<DoubleValidator> {d1,d };

            //Dn.DominantsList = new List<DoubleValidator> { Dm,D1,D};
            //Dn.OppressedList = new List<DoubleValidator> { d1,d};

            //d1.DominantsList = new List<DoubleValidator> { Dn};

        }
    }
}
