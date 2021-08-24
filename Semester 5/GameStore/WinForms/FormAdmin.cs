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

namespace GameStore.WinForms
{
    public partial class FormAdmin : Form
    {
        Store store;
        Admin admin;
        public FormAdmin()
        {
            InitializeComponent();
        }
        public FormAdmin(Store store)
        {
            this.store = store;
            this.admin = (Admin)store.LoggedInUser; ;
            InitializeComponent();

            panelManagementTab.Hide();
            panelCenter.Controls.Clear();
            UserControlStore ucs = new UserControlStore(store, this.panelCenter);
            ucs.Dock = DockStyle.Top;
            panelCenter.Controls.Add(ucs);
        }

        private void buttonUserManagement_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonDeveloperManagement_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonStoreManagement_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            panelManagementTab.Hide();
            panelCenter.Controls.Clear();
            UserControlStore ucs = new UserControlStore(store, this.panelCenter);
            ucs.Dock = DockStyle.Top;
            panelCenter.Controls.Add(ucs);
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            panelManagementTab.Hide();
            panelCenter.Controls.Clear();

            int numOfRows = Convert.ToInt32(Math.Ceiling(store.Games.Count / 6.0)), index = 0;
            List<UserControlLibrary> rows = new List<UserControlLibrary>();
            rows.Add(new UserControlLibrary());

            foreach (Game g in store.Games)
            {
                if (rows[index].Add(store, panelCenter,g) == false)
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
            panelManagementTab.Hide();
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
            panelManagementTab.Hide();
            panelCenter.Controls.Clear();
            panelCenter.Controls.Add(new UserControlProfile(store));
        }

        private void buttonDashboard_Click_1(object sender, EventArgs e)
        {
            panelCenter.Controls.Clear();
            panelManagementTab.Show();
        }

        private void buttonStoreManagement_Click_1(object sender, EventArgs e)
        {
            
        }

        private void buttonDeveloperManagement_Click_1(object sender, EventArgs e)
        {
            
        }

        private void buttonUserManagement_Click_1(object sender, EventArgs e)
        {
            
            
            //userManagement.Dock = DockStyle.Top;
            //panelManagementTab.Dock = DockStyle.Top;
        }

        private void buttonStoreManagement_Click_2(object sender, EventArgs e)
        {
            panelCenter.Controls.Clear();
            UserControlStoreManagement storeManagement = new UserControlStoreManagement(store);
            panelCenter.Controls.Add(storeManagement);
            storeManagement.Dock = DockStyle.Top;
        }

        private void buttonUserManagement_Click_2(object sender, EventArgs e)
        {
            panelCenter.Controls.Clear();
            UserControlUserManagement userManagement = new UserControlUserManagement(store);
            panelCenter.Controls.Add(userManagement);
        }

        private void buttonDeveloperManagement_Click_2(object sender, EventArgs e)
        {
            panelCenter.Controls.Clear();
            UserControlDeveloperManagement developermanagements = new UserControlDeveloperManagement(store);
            panelCenter.Controls.Add(developermanagements);
            //developermanagements.Dock = DockStyle.Bottom;
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
