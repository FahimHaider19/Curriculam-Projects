using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameStore.WinForms;
using GameStore.Classes;
using GameStore.DataAccess;

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
            Store store = new Store();
            UsersDataAccess uda = new UsersDataAccess(store);
            store.Uda = uda;
            uda.GetUsers();
            uda.GetProducts();
            //uda.getNews();
            //uda.getProductRecord(store.Gamers[0]);
            //uda.getReceipt(store.Gamers[0]);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new LogIn(store));
            //Application.Run(new Register());
            //Application.Run(new FormGamer(store));
            //Application.Run(new TestForm(store));
            //Application.Run(new FormAdmin(store));
            //Application.Run(new FormDeveloper(store));
            
        }
    }
}
