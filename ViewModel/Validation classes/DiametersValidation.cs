using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collar_flange_configurator.ViewModel.Validation_classes
{
    class DiametersValidation : ParamValidator
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

        public override bool CheckValidation()
        {
            if (SizeD == null || SizeD1 == null || SizeD2 == null || Sized1 == null || SizeDm == null || SizeDn == null || SizeR1 == null || CountOfn == null || Sized == null)
            {
                return false;
            }
            if (SizeD.Length == 0  || SizeD1.Length == 0 || SizeD2.Length == 0 || Sized1.Length == 0 && SizeDm.Length == 0 || SizeDn.Length == 0 || SizeR1.Length == 0 || CountOfn.Length == 0  || Sized.Length == 0)
            {
                return false;
            }
                double D = Convert.ToDouble(SizeD);

                double D1 = Convert.ToDouble(SizeD1);

                double D2 = Convert.ToDouble(SizeD2);

                double d1 = Convert.ToDouble(Sized1);

                double Dm = Convert.ToDouble(SizeDm);

                double Dn = Convert.ToDouble(SizeDn);

                double R1 = Convert.ToDouble(SizeR1);

                int n = Convert.ToInt32(CountOfn);

                double d = Convert.ToDouble(Sized);


                double []parametres = new double[8] { D, D1, D2, d1, Dm, Dn, R1, d };
                Array.Sort(parametres);


                if ((parametres.Reverse().ToArray())[0] != D || 0.5*(D1 - d)<0.5*D2)
                {
                    return false;
                }


                bool IsDBiggest = ((parametres.Reverse().ToArray())[0] == D);
            
                bool IsD2Valid = (0.5 * (D1 - d) >= 0.5 * D2 && 0.5*D2 > d1*0.5);

                bool IsDmDnAnddValid = 
                (
                        new double[3] {Dm,Dn,d1}.Max() == Dm 
                        &&
                        new double[3] { Dm, Dn, d1 }.Min() == d1
                        &&
                        Dm > Dn
                );

                bool AreCountOfHolesOptimal = (n <= Math.Floor(Math.PI * D2 / d));

                bool AreAllBiggerThanZero = (D > 0 && D1 > 0 && D2 > 0 && d1 > 0 && Dm > 0 && Dn > 0 && R1 > 0 && n > 0 && d > 0);

                bool IsR1Valid = (R1 <= Dm*0.5);


                return (IsDBiggest && IsD2Valid && IsDmDnAnddValid && AreCountOfHolesOptimal && AreAllBiggerThanZero && IsR1Valid);
            
            return false;
        }
    }
}
