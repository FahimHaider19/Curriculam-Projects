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
    public partial class UserControlNews : UserControl
    {
        public UserControlNews()
        {
            InitializeComponent();
        }

        public NewsBox NewsBox1
        {
            set { this.newsBox1 = value; }
            get { return this.newsBox1; }
        }
        public NewsBox NewsBox2
        {
            set { this.newsBox2 = value; }
            get { return this.newsBox2; }
        }
        public NewsBox NewsBox3
        {
            set { this.newsBox3 = value; }
            get { return this.newsBox3; }
        }
        public NewsBox NewsBox4
        {
            set { this.newsBox4 = value; }
            get { return this.newsBox4; }
        }
        
    }
}
