using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using Estructura_Basica_Grafica.presentacion;
namespace Estructura_Basica_Grafica
{
    static class Program
    {
       
        [STAThread]
        static void Main()
        {
            //Game game = new Game(900, 700, "Basic Structure");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Presentation());
        }
    }
}
