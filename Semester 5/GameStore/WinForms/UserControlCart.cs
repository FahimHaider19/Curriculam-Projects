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
    public partial class UserControlCart : UserControl
    {
        public UserControlCart()
        {
            InitializeComponent();
            UserControlWishlist ucw = new UserControlWishlist();
            UserControlWishlist ucw1 = new UserControlWishlist();
            flowLayoutPanel1.Controls.Add(ucw);
            flowLayoutPanel1.Controls.Add(ucw1);
            flowLayoutPanel1.Controls.Add(new UserControlWishlist());


        }

        private void testUC_Load(object sender, EventArgs e)
        {

        }

        private void gameBox5_Load(object sender, EventArgs e)
        {

        }

        private void gameBox2_Load(object sender, EventArgs e)
        {

        }

        private void gameBox3_Load(object sender, EventArgs e)
        {

        }

        private void gameBox4_Load(object sender, EventArgs e)
        {

        }

        private void gameBox1_Load(object sender, EventArgs e)
        {

        }

        private void gameBox6_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanelProducts_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
