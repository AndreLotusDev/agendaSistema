using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TESTE_PARA_DESENVOLVEDOR.Context;

namespace TESTE_PARA_DESENVOLVEDOR
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            AgendaContext _context = new AgendaContext();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new EntryPoint());
        }
    }
}
