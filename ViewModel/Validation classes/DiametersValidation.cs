using Collar_flange_configurator.Extensions;
using Collar_flange_configurator.ViewModel.Validation_classes.Parameters;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collar_flange_configurator.ViewModel.Validation_classes
{
    class DiametersValidation : ParameterValidator
    {
        public string SizeD { get; set; }

        public string SizeD1 { get; set; }

        public string SizeD2 { get; set; }

        public string Sized1 { get; set; }

        public string SizeDm { get; set; }

        public string SizeDn { get; set; }

        public string SizeR1 { get; set; }

        public string CountOfn { get; set; }

        public string Sized { get; set; }



        public IntegerParameter Parameter_n = new IntegerParameter("n",2);

        public MajorLinearParameter ParmeterD = new MajorLinearParameter("D");

        public LinearParameter ParameterD1 = new LinearParameter("D1");

        public LinearParameter ParameterD2 = new LinearParameter("D2");

        public LinearParameter Parameter_d1 = new LinearParameter("d1");

        public LinearParameter ParameterDm = new LinearParameter("Dm");

        public LinearParameter ParameterDn = new LinearParameter("Dn");

        public LinearParameter ParameterR1 = new LinearParameter("R1");

        public LinearParameter Parameter_d = new LinearParameter("d");


        public override bool CheckValidation()
        {
            //try
            //{

            //    double D = Convert.ToDouble(SizeD);

            //    double D1 = Convert.ToDouble(SizeD1);

            //    double D2 = Convert.ToDouble(SizeD2);

            //    double d1 = Convert.ToDouble(Sized1);

            //    double Dm = Convert.ToDouble(SizeDm);

            //    double Dn = Convert.ToDouble(SizeDn);

            //    double R1 = Convert.ToDouble(SizeR1);

            //    int n = Convert.ToInt32(CountOfn);

            //    double d = Convert.ToDouble(Sized);


            //    bool IsDBiggest = (new double[] { D, D1, D2, d1, Dm, Dn, R1, d }.Max() == D);

            //    bool IsD2Valid = (0.5 * (D1 - d) >= 0.5 * D2 && 0.5 * D2 > d1 * 0.5);

            //    bool IsDmDnAnddValid =
            //    (
            //            new double[3] { Dm, Dn, d1 }.Max() == Dm
            //            &&
            //            new double[3] { Dm, Dn, d1 }.Min() == d1
            //            &&
            //            Dm > Dn
            //    );

            //    bool AreCountOfHolesOptimal = (n <= Math.Floor(Math.PI * D2 / d));

            //    bool AreAllBiggerThanZero = (D > 0 && D1 > 0 && D2 > 0 && d1 > 0 && Dm > 0 && Dn > 0 && R1 > 0 && n > 0 && d > 0);

            //    bool IsR1Valid = (R1 <= Dm * 0.5);


            //    return (IsDBiggest && IsD2Valid && IsDmDnAnddValid && AreCountOfHolesOptimal && AreAllBiggerThanZero && IsR1Valid);
            //}
            //catch
            //{
            //    return false;
            //}


            if(Parameter_n.PrimaryValidation())
            {
                Parameter_n.SetMax(Math.PI * Convert.ToDouble(ParameterR1.Value) / Convert.ToDouble(ParameterDm.Value) * 0.5);


                return Parameter_n.SecondaryValidation();
            }
            return false;
        }
    }
}
