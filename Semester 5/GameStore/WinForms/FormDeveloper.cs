using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GameStore.Classes;
using GameStore.WinForms;

namespace GameStore
{
    public partial class FormDeveloper : Form
    {
        Store store;
        Developer developer;
        public FormDeveloper()
        {
            InitializeComponent();
        }
        public FormDeveloper(Store store)
        {
            this.store = store;
            this.developer = (Developer)store.LoggedInUser;
            InitializeComponent();

            panelManagement.Hide();
            panelCenter.Controls.Clear();
            UserControlStore ucs = new UserControlStore(store, this.panelCenter);
            ucs.Dock = DockStyle.Top;
            panelCenter.Controls.Add(ucs);
        }
        
        private void buttonGameManagement_Click(object sender, EventArgs e)
        {
            
        }


        private void buttonPublishGames_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonPublishNews_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            panelManagement.Hide();
            panelCenter.Controls.Clear();
            UserControlStore ucs = new UserControlStore(store, this.panelCenter);
            ucs.Dock = DockStyle.Top;
            panelCenter.Controls.Add(ucs);
        }

        private void buttonDashboard_Click(object sender, EventArgs e)
        {
            panelManagement.Show();
            panelCenter.Controls.Clear();
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            panelManagement.Hide();
            panelCenter.Controls.Clear();

            int numOfRows = Convert.ToInt32(Math.Ceiling(store.Games.Count / 6.0)), index = 0;
            List<UserControlLibrary> rows = new List<UserControlLibrary>();
            rows.Add(new UserControlLibrary());

            foreach (Game g in store.Games)
            {
                if (rows[index].Add(store, panelCenter, g) == false)
                {

                    panelCenter.Controls.Add(rows[index]);
                    rows[index].Dock = DockStyle.Bottom;
                    index++;
                    rows.Add(new UserControlLibrary());
                    rows[index].Add(store, panelCenter, g);
                }
            }
            if (index < numOfRows)
            {
                panelCenter.Controls.Add(rows[index]);
                rows[index].Dock = DockStyle.Bottom;
            }
        }

        private void buttonNews_Click(object sender, EventArgs e)
        {
            panelManagement.Hide();
            panelCenter.Controls.Clear();

            int numOfRows = Convert.ToInt32(Math.Ceiling(store.News.Count / 4.0)), index = 0;
            List<UserControlNews> rows = new List<UserControlNews>();
            rows.Add(new UserControlNews(panelCenter));

            foreach (News n in store.News)
            {
                if (rows[index].Add(n) == false)
                {
                    panelCenter.Controls.Add(rows[index]);
                    rows[index].Dock = DockStyle.Bottom;
                    index++;
                    rows.Add(new UserControlNews(panelCenter));
                    rows[index].Add(n);
                }
            }
            if (index < numOfRows)
            {
                panelCenter.Controls.Add(rows[index]);
                rows[index].Dock = DockStyle.Top;
            }
        }

        private void buttonMyProfile_Click(object sender, EventArgs e)
        {
            panelManagement.Hide();
            panelCenter.Controls.Clear();
            panelCenter.Controls.Add(new UserControlProfile(store));
        }

        private void buttonSignOut_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Logged Out");
            LogIn login = new LogIn(store);
            login.Show();
            this.Hide();
        }

        private void buttonGameManagement_Click_1(object sender, EventArgs e)
        {
            panelCenter.Controls.Clear();
            UserControlgameManageMentcs game = new UserControlgameManageMentcs(store);
            panelCenter.Controls.Add(game);
            game.Dock = DockStyle.Top;
        }

        private void buttonPublishGames_Click_1(object sender, EventArgs e)
        {
            panelCenter.Controls.Clear();
            UserControlPublishGame pubcgames = new UserControlPublishGame(store);
            panelCenter.Controls.Add(pubcgames);
            pubcgames.Dock = DockStyle.Top;
        }

        private void buttonPublishNews_Click_1(object sender, EventArgs e)
        {
            panelCenter.Controls.Clear();
            UserControlPublishNews publishnew = new UserControlPublishNews(store);
            panelCenter.Controls.Add(publishnew);
            publishnew.Dock = DockStyle.Top;
        }
    }
}
