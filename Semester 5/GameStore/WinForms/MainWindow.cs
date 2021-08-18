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

namespace GameStore
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            //panelStoreDropdown.Hide();
            //UserControlCart tu = new UserControlCart();
            //panelCenter.Controls.Add(tu);


            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void store_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panelStoreDropdown_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonStore_Click(object sender, EventArgs e)
        {
            UserControllStore ucs = new UserControllStore();
            ucs.Dock = DockStyle.Top;
            panelCenter.Controls.Add(ucs);
        }

        private void buttonDropDown_Click(object sender, EventArgs e)
        {
            if (panelStoreDropdown.Visible == true)
                panelStoreDropdown.Hide();
            else panelStoreDropdown.Show();
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            UserControlBrowse ucb = new UserControlBrowse();
            panelCenter.Controls.Add(ucb);
            ucb.Dock = DockStyle.Top;

        }

        private void buttonLibrary_Click(object sender, EventArgs e)
        {
            //UserControlLibrary ucl = new UserControlLibrary();
            //ucl.Dock = DockStyle.Top;
            //UserControlLibrary ucl2 = new UserControlLibrary();
            //ucl2.Dock = DockStyle.Top;
            //GameBox g = new GameBox("Hellu");
            //ucl.GameBox1.LabelGameboxGameName.Text = "HI";

            //GameBox g2 = new GameBox();
            //ucl2.GameBox1.LabelGameboxGameName.Text = "Hellu";

            //panelCenter.Controls.Add();
            
            List<GameBox> gb = new List<GameBox>();
            for (int i = 0; i < 20; i++)
            {
                string str = "";
                str += i;
                gb.Add(new GameBox(str));
            }



            List<UserControlLibrary> rows = new List<UserControlLibrary>();
                
            for(int i = 0; i < Convert.ToInt32(Math.Ceiling(gb.Count / 6.0)); i++)
            {
                rows.Add(new UserControlLibrary());
                
                
                rows[i].GameBox1.LabelGameboxGameName.Text = "" +i;
                rows[i].GameBox2.LabelGameboxGameName.Text = "" +i+1;
                rows[i].GameBox3.LabelGameboxGameName.Text = "" +i+2;
                rows[i].GameBox4.LabelGameboxGameName.Text = "" +i+3;
                rows[i].GameBox5.LabelGameboxGameName.Text = "" +i+4;
                rows[i].GameBox6.LabelGameboxGameName.Text = "" +i+5; 
                panelCenter.Controls.Add(rows[i]);
                rows[i].Dock = DockStyle.Top;
            }
            
            /*
            UserControlLibrary l1 = new UserControlLibrary();
            panelCenter.Controls.Add(l1);
            l1.Dock = DockStyle.Top;
            UserControlLibrary l2 = new UserControlLibrary();
            panelCenter.Controls.Add(l2);
            l2.Dock = DockStyle.Top;*/



        }
    }
}
