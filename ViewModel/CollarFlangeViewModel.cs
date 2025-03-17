using Collar_flange_configurator.database.logic.sizes;
using Collar_flange_configurator.database.logic.sizes.records;
using Collar_flange_configurator.database.logic.sizes.tables;
using Collar_flange_configurator.ViewModel.Validation_classes;
using Collar_flange_configurator.WPF_override.Command;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace Collar_flange_configurator.ViewModel
{
    internal unsafe class CollarFlangeViewModel : INotifyPropertyChanged
    {
        private readonly AngleValidator fAngleValidation = new AngleValidator(0,90);

        private readonly HeightsValidator heightsValidation = new HeightsValidator();

        private readonly DiametersValidation diametersValidation = new DiametersValidation();



        public readonly SizesDatabase SizesDB = new SizesDatabase();



        private ObservableCollection<GOSTSizesRecord> gostTableLines;
        public ObservableCollection<GOSTSizesRecord> GOSTSizesRecords
        {
            get
            {
                return gostTableLines;
            }
            set
            {
                gostTableLines = value;
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








        private bool areFlangeDiametersValid;
        public bool AreFlangeDiametersValid
        {
            get
            {
                return areFlangeDiametersValid;
            }
            set
            {
                areFlangeDiametersValid = value;
                OnPropertyChanged();
            }
        }


        private bool areFlangeHeightsValid;
        public bool AreFlangeHeightsValid
        {
            get
            {
                return areFlangeHeightsValid;
            }
            set
            {
                areFlangeHeightsValid = value;
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

                diametersValidation.SizeDm = value;
                AreFlangeDiametersValid =  diametersValidation.CheckValidation();

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

                diametersValidation.SizeDn = value;
                AreFlangeDiametersValid = diametersValidation.CheckValidation();

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

                diametersValidation.Sized1 = value;
                AreFlangeDiametersValid = diametersValidation.CheckValidation();

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

                heightsValidation.Sizeb = value;
                AreFlangeHeightsValid = heightsValidation.CheckValidation();

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

                heightsValidation.SizeH = value;
                AreFlangeHeightsValid =  heightsValidation.CheckValidation();

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

                heightsValidation.SizeH1 = value;
                AreFlangeHeightsValid = heightsValidation.CheckValidation();

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

                diametersValidation.SizeD = value;
                AreFlangeDiametersValid = diametersValidation.CheckValidation();

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

                diametersValidation.SizeD1 = value;
                AreFlangeDiametersValid = diametersValidation.CheckValidation();

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

                diametersValidation.Sized = value;
                AreFlangeDiametersValid = diametersValidation.CheckValidation();

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

                diametersValidation.CountOfn = value;
                AreFlangeDiametersValid = diametersValidation.CheckValidation();

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

                heightsValidation.Sizel1 = value;
                AreFlangeHeightsValid = heightsValidation.CheckValidation();

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

                diametersValidation.SizeR1 = value;
                AreFlangeDiametersValid = diametersValidation.CheckValidation();

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

                fAngleValidation.Angle = value;
                IsfValid = fAngleValidation.CheckValidation();

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

                diametersValidation.SizeD2 = value;
                AreFlangeDiametersValid = diametersValidation.CheckValidation();

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
                   IsfValid && AreFlangeDiametersValid && AreFlangeHeightsValid
               );
            }
        }





        public WpfCommand StandartSizesCommand
        {
            get
            {
                return new WpfCommand((obj) =>
                {
                    ValueOfDmSize = SizesDB.StandartTable.GetStandartSizesRecord.Dm;

                    ValueOfDnSize = SizesDB.StandartTable.GetStandartSizesRecord.Dn;

                    ValueOfd1Size = SizesDB.StandartTable.GetStandartSizesRecord.d1;

                    ValueOfbSize = SizesDB.StandartTable.GetStandartSizesRecord.b;

                    ValueOfHSize = SizesDB.StandartTable.GetStandartSizesRecord.H;

                    ValueOfH1Size = SizesDB.StandartTable.GetStandartSizesRecord.H1;

                    ValueOfDSize = SizesDB.StandartTable.GetStandartSizesRecord.D;

                    ValueOfD1Size = SizesDB.StandartTable.GetStandartSizesRecord.D1;

                    ValueOfdSize = SizesDB.StandartTable.GetStandartSizesRecord.d;

                    ValueOfnSize = SizesDB.StandartTable.GetStandartSizesRecord.n;

                    ValueOfl1Size = SizesDB.StandartTable.GetStandartSizesRecord.l1;

                    ValueOfR1Size = SizesDB.StandartTable.GetStandartSizesRecord.R1;

                    ValueOfD2Size = SizesDB.StandartTable.GetStandartSizesRecord.D2;

                    ValueOffSize = SizesDB.StandartTable.GetStandartSizesRecord.f;
                });
            }
        }





        



        public CollarFlangeViewModel()
        {
 

            //StandartSizesCommand.Execute(SetStandartSizes);

            IsConfig3DModel = true;

            GOSTSizesRecords = SizesDB.GOSTTable.GOSTSizesRecords;
        }
    }
}
