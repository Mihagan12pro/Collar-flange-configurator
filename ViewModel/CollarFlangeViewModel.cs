using Collar_flange_configurator.ViewModel.Validation_classes;
using Collar_flange_configurator.ViewModel.Validation_classes.Double;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace Collar_flange_configurator.ViewModel
{
    internal class CollarFlangeViewModel : INotifyPropertyChanged
    {
        private readonly DoubleValidator Dm = new DoubleValidator(1,1);
        private readonly DoubleValidator Dn = new DoubleValidator(1,0);
        private readonly DoubleValidator d = new DoubleValidator(1,0);
        private readonly DoubleValidator b = new DoubleValidator(1,1);
        private readonly DoubleValidator l1 = new DoubleValidator(1,0);
        private readonly AngleValidator f = new AngleValidator(0,90);
        private readonly DoubleValidator d1 = new DoubleValidator(1,0);
        private readonly DoubleValidator D = new DoubleValidator(0,1);
        private readonly DoubleValidator D1 = new DoubleValidator(1,1);
        private readonly DoubleValidator D2 = new DoubleValidator(1,1);
        private readonly DoubleValidator R1 = new DoubleValidator(1,0);
        private readonly MajorDoubleValidator H = new MajorDoubleValidator(0,2,2);
        private readonly DoubleValidator H1 = new DoubleValidator(1,0);


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

        private bool isD2Valid;
        public bool IsD2Valid
        {
            get
            {
                return isD2Valid;
            }
            set
            {
                isD2Valid = value;
                OnPropertyChanged();
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
                IsbValid = b.CheckValidation(value);
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
                IsHValid = H.CheckValidation(value);
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

                IsH1Valid = H1.CheckValidation(value);

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
                Isl1Valid = l1.CheckValidation(value);
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
        


        private string valueOfD2Size;
        public string ValueOfD2Size
        {
            get
            {
                return valueOfD2Size;
            }
            set
            {
                valueOfD2Size = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));


            if (nameof(IsOkEnabled) != propertyName)
            {
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
                   IsD2Valid
               );
            }
        }





        public CollarFlangeViewModel()
        {
            H.Children[0] = H1;
            H.Children[1] = b;

            H.Oppressed[0] = H1;
            H.Oppressed[1] = b;

            H1.Dominants[0] = H;

            b.Dominants[0] = H;
            b.Oppressed[0] = l1;

            l1.Dominants[0] = b;

            ValueOfDmSize = "660";
            ValueOfDnSize = "636";
            ValueOfd1Size = "602";
            ValueOfD1Size = "770";
            ValueOfDSize = "840";
            ValueOfHSize = "90";
            ValueOfH1Size = "14";
            ValueOfbSize = "41";
            ValueOfdSize = "20";
            ValueOfnSize = "20";
            ValueOfR1Size = "5";
            ValueOffSize = "45";
            ValueOfl1Size = "5";
            ValueOfD2Size = "690";



        }
    }
}
