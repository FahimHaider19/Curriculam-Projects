using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameStore
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            panelStoreDropdown.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        

        private void store_Click(object sender, EventArgs e)
        {
            if (panelStoreDropdown.Visible == true)
                panelStoreDropdown.Hide();
            else panelStoreDropdown.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panelStoreDropdown_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
