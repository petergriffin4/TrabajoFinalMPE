using OTRAappPanaderia2.InicioSes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OTRAappPanaderia2
{
    internal static class Program
    {
       
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());

            PresentaFORM presentaFORM = new PresentaFORM();
            presentaFORM.ShowDialog();

            Application.Run(new Form1());

        }
    }
}
