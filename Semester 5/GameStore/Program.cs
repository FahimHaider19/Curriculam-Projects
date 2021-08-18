using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameStore.WinForms;

namespace GameStore
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new LogIn());
            //Application.Run(new Register());
            Application.Run(new MainWindow());
            //Application.Run(new TestForm());
            
            
        }
    }
}
