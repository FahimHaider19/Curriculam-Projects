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

namespace GameStore
{
    public partial class UserControlUserManagement : UserControl
    {
        Store store;
        
        public UserControlUserManagement()
        {
            InitializeComponent();
        }
        public UserControlUserManagement(Store store)
        {

            this.store = store;
            InitializeComponent();
            reload();
           
        }
        public void reload()
        {
            listViewBanUsers.Items.Clear();
            List<ListViewItem> rows = new List<ListViewItem>();
            foreach (Gamer g in store.Gamers)
            {
                ListViewItem l = new ListViewItem();
                l.Text = g.UserId.ToString();
                l.SubItems.Add(g.Email);
                l.SubItems.Add(g.UserName);
                l.SubItems.Add(g.BanStatus.ToString());
                rows.Add(l);

            }
            foreach (ListViewItem items in rows)
            {
                listViewBanUsers.Items.Add(items);
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void buttonViewUsers_Click(object sender, EventArgs e)
        {

        }

        private void panelButton_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listViewBanUsers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonBan_Click(object sender, EventArgs e)
        {
           long id=long.Parse(listViewBanUsers.SelectedItems[0].Text);
            store.getGamer(id).BanStatus = true;
            string sql = "Update Users Set banstatus = '" +true +"' Where userId = '" + id + "'";
            store.Uda.ExecuteQuery(sql);
            reload();
        }

        private void buttonUnbanUser_Click(object sender, EventArgs e)
        {
            long id = long.Parse(listViewBanUsers.SelectedItems[0].Text);
            store.getGamer(id).BanStatus = false;
            string sql = "update Users set banstatus ='" + false + "' where userid='"+id+"'";
            store.Uda.ExecuteQuery(sql);
            reload();

        }

        private void listViewBanUsers_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
