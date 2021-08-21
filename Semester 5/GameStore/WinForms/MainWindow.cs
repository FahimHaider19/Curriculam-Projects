using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameStore.WinForms;
using GameStore.Classes;

namespace GameStore
{
    public partial class MainWindow : Form
    {
        Store store;
        Gamer gamer;
        public MainWindow()
        {
            InitializeComponent();
            //panelStoreDropdown.Hide();
            //UserControlCart tu = new UserControlCart();
            //panelCenter.Controls.Add(tu);

        }

        public MainWindow(Store store)
        {
            this.store = store;
            gamer = (Gamer)store.LoggedInUser;
            InitializeComponent();

            panelCenter.Controls.Clear();
            UserControllStore ucs = new UserControllStore();
            ucs.Dock = DockStyle.Top;
            panelCenter.Controls.Add(ucs);

        }

        private void buttonStore_Click(object sender, EventArgs e)
        {
            panelCenter.Controls.Clear();
            UserControllStore ucs = new UserControllStore();
            ucs.Dock = DockStyle.Top;
            panelCenter.Controls.Add(ucs);
        }

        private void buttonDropDown_Click(object sender, EventArgs e)
        {
            //panelCenter.Controls.Clear();
            if (panelStoreDropdown.Visible == true)
                panelStoreDropdown.Hide();
            else panelStoreDropdown.Show();
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            panelCenter.Controls.Clear();
            /*
            List<Game> games = new List<Game>();
            for (int i = 0; i < 50; i++)
            {
                string str = "Game-";
                str += i;
                games.Add(new Game(str));
            }
            */
            int numOfRows = Convert.ToInt32(Math.Ceiling(store.Games.Count / 6.0)), index = 0;
            List<UserControlLibrary> rows = new List<UserControlLibrary>();
            rows.Add(new UserControlLibrary());

            foreach (Game g in store.Games)
            {
                if (rows[index].Add(g) == false)
                {

                    panelCenter.Controls.Add(rows[index]);
                    rows[index].Dock = DockStyle.Bottom;
                    index++;
                    rows.Add(new UserControlLibrary());
                    rows[index].Add(g);
                }
            }
            if (index < numOfRows)
            {
                panelCenter.Controls.Add(rows[index]);
                rows[index].Dock = DockStyle.Bottom;
            }
        }

        private void buttonLibrary_Click(object sender, EventArgs e)
        {
            panelCenter.Controls.Clear();
            /*
            List<Game> games = new List<Game>();
            for (int i = 0; i < 20; i++)
            {
                string str = "Game-";
                str += i;
                games.Add(new Game(str));
            }
            */
            int numOfRows = Convert.ToInt32(Math.Ceiling(gamer.PurchasedGames.Count / 6.0)), index = 0;
            List<UserControlLibrary> rows = new List<UserControlLibrary>();
            rows.Add(new UserControlLibrary());

            foreach (Game g in gamer.PurchasedGames)
            {
                if (rows[index].Add(g) == false)
                {
                    panelCenter.Controls.Add(rows[index]);
                    rows[index].Dock = DockStyle.Bottom;
                    index++;
                    rows.Add(new UserControlLibrary());
                    rows[index].Add(g);
                }
            }
            if (index < numOfRows)
            {
                panelCenter.Controls.Add(rows[index]);
                rows[index].Dock = DockStyle.Bottom;
            }
        }

        private void buttonWishlist_Click(object sender, EventArgs e)
        {
            panelCenter.Controls.Clear();
            //Gamer gamer = (Gamer)store.LoggedInUser;
            foreach (Game g in gamer.Wishlist)
            {
                UserControlWishlist ucw = new UserControlWishlist();
                ucw.LabelTitle.Text = g.Name;
                ucw.TextBoxPriority.Text = "0";
                panelCenter.Controls.Add(ucw);
                ucw.Dock = DockStyle.Bottom;
            }
        }

        private void buttonCart_Click(object sender, EventArgs e)
        {
            panelCenter.Controls.Clear();
            //Gamer gamer = (Gamer)store.LoggedInUser;
            foreach (Game g in gamer.Cart)
            {
                //cart
            }
        }

        private void buttonNews_Click(object sender, EventArgs e)
        {

        }

        private void buttonSignOut_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logged Out");
            LogIn login = new LogIn(store);
            login.Show();
            this.Hide();
        }
    }
}
