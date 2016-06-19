using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThePragueTest
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Aici se incarca interfata grafica
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            //II spunem sa porneasca cu afisarea clasei FirstPage
            Application.Run(new FirstPage());
        }
    }
}
