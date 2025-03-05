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
        private bool isSizeDmValid, isSizeDnValid, isSized1Valid, isSizebValid, isSizeHValid, isSizeH1Valid, isSizeDValid;
        private bool isSizeD1Valid, isSizedValid, isSizeR1Valid, isSizel1Valid, isSizefValid,isCountnValid;




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




        private SolidColorBrush fontColorOfDm;
        public SolidColorBrush FontColorOfDm
        {
            get
            {
                return fontColorOfDm;
            }
            private set
            {
                fontColorOfDm = value;
                OnPropertyChanged();
            }
        }


        private SolidColorBrush fontColorOfDn;
        public SolidColorBrush FontColorOfDn
        {
            get
            {
                return fontColorOfDn;
            }
            private set
            {
                fontColorOfDn = value;
                OnPropertyChanged();
            }
        }


        private SolidColorBrush fontColorOfd1;
        public SolidColorBrush FontColorOfd1
        {
            get
            {
                return fontColorOfd1;
            }
            private set
            {
                fontColorOfd1 = value;
                OnPropertyChanged();
            }
        }


        private SolidColorBrush fontColorOfb;
        public SolidColorBrush FontColorOfb
        {
            get
            {
                return fontColorOfb;
            }
            private set
            {
                fontColorOfb = value;
                OnPropertyChanged();
            }
        }


        private SolidColorBrush fontColorOfH;
        public SolidColorBrush FontColorOfH
        {
            get
            {
                return fontColorOfH;
            }
            private set
            {
                fontColorOfH = value;
                OnPropertyChanged();
            }
        }


        private SolidColorBrush fontColorOfH1;
        public SolidColorBrush FontColorOfH1
        {
            get
            {
                return fontColorOfH1;
            }
            private set
            {
                fontColorOfH1 = value;
                OnPropertyChanged();
            }
        }


        private SolidColorBrush fontColorOfD;
        public SolidColorBrush FontColorOfD
        {
            get
            {
                return fontColorOfD;
            }
            private set
            {
                fontColorOfD = value;
                OnPropertyChanged();
            }
        }


        private SolidColorBrush fontColorOfD1;
        public SolidColorBrush FontColorOfD1
        {
            get
            {
                return fontColorOfD1;
            }
            private set
            {
                fontColorOfD1 = value;
                OnPropertyChanged();
            }
        }


        private SolidColorBrush fontColorOfd;
        public SolidColorBrush FontColorOfd
        {
            get
            {
                return fontColorOfd;
            }
            private set
            {
                fontColorOfd = value;
                OnPropertyChanged();
            }
        }


        private SolidColorBrush fontColorOfn;
        public SolidColorBrush FontColorOfn
        {
            get
            {
                return fontColorOfn;
            }
            private set
            {
                fontColorOfn = value;
                OnPropertyChanged();
            }
        }


        private SolidColorBrush fontColorOfl1;
        public SolidColorBrush FontColorOfl1
        {
            get
            {
                return fontColorOfl1;
            }
            private set
            {
                fontColorOfl1 = value;
                OnPropertyChanged();
            }
        }


        private SolidColorBrush fontColorOfR1;
        public SolidColorBrush FontColorOfR1
        {
            get
            {
                return fontColorOfR1;
            }
            private set
            {
                fontColorOfR1 = value;
                OnPropertyChanged();
            }
        }


        private SolidColorBrush fontColorOff;
        public SolidColorBrush FontColorOff
        {
            get
            {
                return fontColorOff;
            }
            private set
            {
                fontColorOff = value;
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


            FontColorOfDm = Brushes.Red;
        }
    }
}
