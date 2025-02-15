using Multicad.AplicationServices;
using Multicad.CustomObjectBase;
using Multicad.DatabaseServices.StandardObjects;
using Multicad.Geometry;
using Multicad.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Multicad.Constants.ObjectOverlays;
namespace Collar_flange_configurator
{
    internal class Command
    {
        [CommandMethod("Collar_flange", CommandFlags.NoCheck | CommandFlags.NoPrefix)]
        public void CreateMainDialog()
        {

        }
    }
}
