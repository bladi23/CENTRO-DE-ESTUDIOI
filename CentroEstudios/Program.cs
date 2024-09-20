using System;
using System.Windows.Forms;
using CentroEstudios.Views;

namespace CentroEstudios
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Abrir el formulario principal al inicio
            Application.Run(new FrmPrincipal());
        }
    }
}
