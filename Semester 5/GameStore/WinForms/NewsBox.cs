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

namespace GameStore
{
    public partial class NewsBox : UserControl
    {
        News news;
        Panel panel;
        public NewsBox()
        {
            InitializeComponent();
        }
        public NewsBox(News news, Panel panel)
        {
            this.news = news;
            this.panel = panel;
            InitializeComponent();
        }
        public Panel Panel
        {
            set { this.panel = value; }
            get { return panel; }
        }
        public Label LabelNewsTitle
        {
            set { this.labelNewsTitle = value; }
            get { return labelNewsTitle; }
        }
        public PictureBox PictureBox
        {
            set { this.picturebox = value; }
            get { return picturebox; }
        }
        public News News
        {
            set { this.news = value; }
            get { return news; }
        }

        private void picturebox_MouseClick(object sender, MouseEventArgs e)
        {
            panel.Controls.Clear();
            panel.Controls.Add(new UserControlReadNews(news));
        }
    }
}
