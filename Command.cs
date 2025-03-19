using Teigha.Runtime;
using System.Globalization;
using System.Reflection.Metadata;
using HostMgd.ApplicationServices;
using System.Net.Http.Headers;
using HostMgd.EditorInput;
using System.Windows;
using System.IO;
using System.Data.SQLite;
using System.Reflection;
namespace Collar_flange_configurator
{
    internal class Command
    {
        public static readonly string AssembleLocation = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

        [CommandMethod("Collar_flange")]
        public void CreateMainDialog()
        {

            CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

            MainDialog main = new MainDialog();

            HostMgd.ApplicationServices.Application.ShowModelessWindow(main);
        }
    }
}
