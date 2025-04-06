using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collar_flange_configurator.Extensions
{
    internal static class DoubleExtensions
    {
        public static double DegreesToRadians(this double angleInDegrees)
        {
            double angleInRadians = angleInDegrees * (Math.PI / 180);

            return angleInRadians;
        }
    }
}
