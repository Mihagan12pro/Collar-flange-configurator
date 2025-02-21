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
namespace Collar_flange_configurator
{
    internal class Command
    {
        [CommandMethod("Collar_flange")]
        public void CreateMainDialog()
        {
            MainDialog main = new MainDialog();

            HostMgd.ApplicationServices.Application.ShowModelessWindow(main);
        }
    }
}
