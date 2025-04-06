//using Teigha.Runtime;
using System.Globalization;
using System.Reflection.Metadata;
using HostMgd.ApplicationServices;
using System.Net.Http.Headers;
using HostMgd.EditorInput;
using System.Windows;
using System.IO;
using System.Data.SQLite;
using System.Reflection;
using Multicad.Runtime;
namespace Collar_flange_configurator
{
    internal class Command
    {
        public static readonly string AssembleLocation = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);

        [CommandMethod("Collar_flange", CommandFlags.NoCheck | CommandFlags.NoPrefix)]
        public void CreateMainDialog()
        {
            CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

            if (MainDialog.Dialog == null)
            {
                MainDialog main = new MainDialog();

                HostMgd.ApplicationServices.Application.ShowModelessWindow(main);

                return;
            }
            HostMgd.ApplicationServices.Document doc =
               HostMgd.ApplicationServices.Application.DocumentManager.MdiActiveDocument;

            HostMgd.EditorInput.Editor ed = doc.Editor;

            ed.WriteMessage("Приложение 'Мастер воротниковых фланцев' уже запущено!");
        }
    }
}
