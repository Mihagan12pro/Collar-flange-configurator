using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collar_flange_configurator.Model
{
    abstract class AbstractCollarFlangeModel
    {
        public double Dm { get; protected set; }

        public double Dn { get; protected set; }

        public double d1 { get; protected set; }

        public double b { get; protected set; }

        public double H { get; protected set; }

        public double H1 { get; protected set; }

        public double D { get; protected set; }

        public double D1 { get; protected set; }

        public double d { get; protected set; }

        public int n { get; protected set; }

        public double l1 { get; protected set; }
        public double R1 { get; protected set; }

        public double f { get; protected set; }

        public double D2 { get; protected set; }
    }
}
