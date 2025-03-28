using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collar_flange_configurator.Model
{
    interface ICollarFlangeModel
    {
        double Dm { get; set; }

        double Dn { get; set; }

        double d1 { get; set; }

        double b { get; set; }

        double H { get; set; }

        double H1 { get; set; }

        double D { get; set; }

        double D1 { get; set; }

        double d { get; set; }

        int n { get; set; }

        double l1 { get; set; }
        double R1 { get; set; }

        double f { get; set; }

        double D2 { get; set; }
    }
}
