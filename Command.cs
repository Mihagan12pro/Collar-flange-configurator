//using Multicad.AplicationServices;
//using Multicad.CustomObjectBase;
//using Multicad.DatabaseServices.StandardObjects;
//using Multicad.Geometry;
//using Multicad.Runtime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Multicad.Constants.ObjectOverlays;
using Teigha.Runtime;
using Teigha.Geometry;
using HostMgd.Runtime;
using HostMgd.ApplicationServices;
using HostMgd.EditorInput;
using HostMgd.Windows;
//using Multicad.AplicationServices;
//using Multicad.CustomObjectBase;
//using Multicad.DatabaseServices.StandardObjects;
//using Multicad.Geometry;
//using Multicad.Runtime;
//using Imapimgd;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using static Multicad.Constants.ObjectOverlays;
namespace Collar_flange_configurator
{
    internal class Command
    {
        PaletteSet paletteSet;

        [CommandMethod("Collar_flange")]
        public void CreateMainDialog()
        {



            paletteSet = new PaletteSet("Collar flange");
            paletteSet.Size = new System.Drawing.Size(600, 600);
            paletteSet.MinimumSize = new System.Drawing.Size(300, 300);

            CollarFlangeMaster master = new CollarFlangeMaster();

            paletteSet.AddVisual("", master);

            paletteSet.Visible = true;

            
        }
    }
}
