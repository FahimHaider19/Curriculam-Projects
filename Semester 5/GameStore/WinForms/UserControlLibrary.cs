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
    public partial class UserControlLibrary : UserControl
    {
        public UserControlLibrary()
        {
            InitializeComponent();
        }
        public GameBox GameBox1
        {
            get { return gameBox1; }
            set { this.gameBox1 = value; }
        }
        public GameBox GameBox2
        {
            get { return gameBox2; }
            set { this.gameBox2 = value; }
        }
        public GameBox GameBox3
        {
            get { return gameBox3; }
            set { this.gameBox3 = value; }
        }
        public GameBox GameBox4
        {
            get { return gameBox4; }
            set { this.gameBox4 = value; }
        }
        public GameBox GameBox5
        {
            get { return gameBox5; }
            set { this.gameBox5 = value; }
        }
        public GameBox GameBox6
        {
            get { return gameBox6; }
            set { this.gameBox6 = value; }
        }

    }
}
