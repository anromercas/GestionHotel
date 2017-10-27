using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GestionHotel
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FrmSplash sp = new FrmSplash();
            if (sp.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new Vista.Main());
            }
            
        }
    }
}
