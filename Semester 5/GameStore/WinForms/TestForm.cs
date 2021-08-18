using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameStore.WinForms
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
            flowLayoutPanel1.Controls.Add(new UserControlCart());
            /*
            UserControlWishlist ucw = new UserControlWishlist();
            UserControlWishlist ucw1 = new UserControlWishlist();
            flowLayoutPanel1.Controls.Add(ucw);
            flowLayoutPanel1.Controls.Add(ucw1);
            ucw.Dock = DockStyle.Top;
            ucw.Dock = DockStyle.Top;*/

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TestForm_Load(object sender, EventArgs e)
        {

        }

        private void gameBox1_Load(object sender, EventArgs e)
        {

        }
    }
}
