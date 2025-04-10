using Collar_flange_configurator.database.logic.sizes;
using Collar_flange_configurator.database.logic.sizes.records;
using Collar_flange_configurator.database.logic.sizes.tables;
using Collar_flange_configurator.Extensions;
using Collar_flange_configurator.Model;
using Collar_flange_configurator.ViewModel.Validation_classes;
using Collar_flange_configurator.WPF_override.Command;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace Collar_flange_configurator.ViewModel
{
    internal class CollarFlangeViewModel : INotifyPropertyChanged
    {
        private readonly AngleValidator fAngleValidation = new AngleValidator("f",0,90);

        private readonly HeightsValidator heightsValidation = new HeightsValidator();

        private readonly DiametersValidation diametersValidation = new DiametersValidation();



        public readonly SizesDatabase SizesDB = new SizesDatabase();




        private int selectedGOST_33259_2015;
        public int SelectedGOST_33259_2015
        {
            get
            {
                return selectedGOST_33259_2015;
            }
            set
            {
             
                selectedGOST_33259_2015 = value;

                if (value >= 0)
                {
                    ValueOfDmSize = GOSTSizesRecords[value].Dm;
                    ValueOfDnSize = GOSTSizesRecords[value].Dn;
                    ValueOfd1Size = GOSTSizesRecords[value].d1;
                    ValueOfbSize = GOSTSizesRecords[value].b;
                    ValueOfHSize = GOSTSizesRecords[value].H;
                    ValueOfH1Size = GOSTSizesRecords[value].H1;
                    ValueOfDSize = GOSTSizesRecords[value].D;
                    ValueOfD1Size = GOSTSizesRecords[value].D1;
                    ValueOfdSize = GOSTSizesRecords[value].d;
                    ValueOfnSize = GOSTSizesRecords[value].n;

                    if (!AreFlangeDiametersValid)
                    {
                        ValueOfD2Size = Math.Round((ValueOfD1Size.ToString().ToDouble() - ValueOfdSize.ToString().ToDouble())/ 1.09,3).ToString();
                        ValueOfR1Size = Math.Round(ValueOfDmSize.ToString().ToDouble() * 0.5, 3).ToString();
                    }
                }


                OnPropertyChanged();
                
            }
        }





        private ObservableCollection<GOSTSizesRecord> gostTableRecords;
        public ObservableCollection<GOSTSizesRecord> GOSTSizesRecords
        {
            get
            {
                return gostTableRecords;
            }
            set
            {
                gostTableRecords = value;

                

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

                
                AssembleVisibility = Visibility.Hidden;

                if (!value)
                {
                    LostSelectedIndexOfDataGrid.Execute("");
                    //SelectedGOST_33259_2015 = -1;
                    AssembleVisibility = Visibility.Visible;
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

               // diametersValidation.SizeDm = value;
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

                //diametersValidation.SizeDn = value;
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

               // diametersValidation.Sized1 = value;
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

                heightsValidation.Parameter_b.Value = value;
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

                heightsValidation.ParameterH.Value = value;
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

                heightsValidation.ParameterH1.Value = value;
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

                //diametersValidation.SizeD = value;
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

                //diametersValidation.SizeD1 = value;
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

               //diametersValidation.Sized = value;
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

                //diametersValidation.CountOfn = value;
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

                heightsValidation.Parameter_l1.Value = value;
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

                fAngleValidation.AngleParameter.Value = valueOffSize;
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
                     //IsfValid && AreFlangeDiametersValid && AreFlangeHeightsValid 
                     IsfValid && AreFlangeHeightsValid
               );
            }
        }


        public WpfCommand OkCommand
        {
            get
            {
                return new WpfCommand
                (
                   (obj) =>
                   {
                      if (IsConfig3DModel)
                      {
                           CollarFlangeConfig3D config3D = new CollarFlangeConfig3D
                           (
                               ValueOfDmSize,
                               valueOfDnSize,
                               ValueOfd1Size,
                               ValueOfbSize,
                               ValueOfHSize,
                               ValueOfH1Size,
                               ValueOfDSize,
                               ValueOfD1Size,
                               ValueOfdSize,
                               ValueOfnSize,
                               ValueOfl1Size,
                               ValueOfR1Size,
                               ValueOffSize,
                               ValueOfD2Size
                           );

                           config3D.Build();
                       }
                   }
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




        public WpfCommand LostSelectedIndexOfDataGrid
        {
            get
            {
                return new WpfCommand((obj) =>
                {
                    SelectedGOST_33259_2015 = -1;
                });
            }
        }

        



        public CollarFlangeViewModel()
        {
            IsConfig3DModel = true;

            GOSTSizesRecords = SizesDB.GOSTTable.GOSTSizesRecords;


           
            

            

            //heightsValidation.Parameter_l1.Value = ValueOfl1Size;
            //heightsValidation.ParameterH1.Value = ValueOfH1Size;
            //heightsValidation.Parameter_b.Value = ValueOfbSize;
            //heightsValidation.ParameterH.Value = ValueOfHSize;

           

            LostSelectedIndexOfDataGrid.Execute("");
        }
    }
}
