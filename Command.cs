using Teigha.Runtime;
using System.Globalization;
namespace Collar_flange_configurator
{
    internal class Command
    {
        [CommandMethod("Collar_flange")]
        public void CreateMainDialog()
        { 
            CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

            MainDialog main = new MainDialog();

            HostMgd.ApplicationServices.Application.ShowModelessWindow(main);
        }
    }
}
