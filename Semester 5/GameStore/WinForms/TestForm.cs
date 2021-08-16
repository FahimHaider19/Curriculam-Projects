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
            //Gamebox
            //GameBox g = new GameBox("Red Dead Redemption 2");
            //g.BackColor = Color.Purple;
            //flowLayoutPanel1.Controls.Add(g);

            //flowLayoutPanel1.Controls.Add(new NewsBox());
            //flowLayoutPanel1.Controls.Add(new NewsBox());
            //flowLayoutPanel1.Controls.Add(new NewsBox());
            //tableLayoutPanel1.Controls.Add(new NewsBox());
            //tableLayoutPanel1.Controls.Add(new NewsBox());
            //tableLayoutPanel1.Controls.Add(new NewsBox());
            
            NewsBox n = new NewsBox();
            NewsBox n2 = new NewsBox();
            NewsBox n3 = new NewsBox();
            //panel1.Controls.Add(new Button());
            //n.Dock = DockStyle.Fill;


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
