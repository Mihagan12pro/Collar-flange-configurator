using Multicad.Geometry;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collar_flange_configurator.Extensions
{
    internal static class Polyline3DExtensions
    {
        public static void MakeChamferAtVertex(this Polyline3d polyline3D, int idx, double distance2,double angleInDegrees)
        {
            double angleInRadians = angleInDegrees.DegreesToRadians();

            double distance1 = Math.Tan(angleInRadians) * distance2;

            polyline3D.Vertices.MakeChamferAtVertex(idx, distance1, distance2);
        }
    }
}
