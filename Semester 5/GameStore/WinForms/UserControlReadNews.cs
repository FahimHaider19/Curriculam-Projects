﻿using System;
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
    public partial class UserControlReadNews : UserControl
    {
        public UserControlReadNews()
        {
            InitializeComponent();
        }
        public Label LabelTitle
        {
            set { this.labelTitle = value; }
            get { return labelTitle; }
        }
        public Label LabelDescription
        {
            set { this.labelDescription = value; }
            get { return labelDescription; }
        }
        public PictureBox PictureBox
        {
            set { this.pictureBox = value; }
            get { return pictureBox; }
        }
        private void UserControlReadNews_Load(object sender, EventArgs e)
        {

        }

        private void UserControlReadNews_Resize(object sender, EventArgs e)
        {
            //labelTitle.MaximumSize = new Size(this.Width, 0);
            //label1.MaximumSize = new Size(this.Width, 0);
        }
    }
}
