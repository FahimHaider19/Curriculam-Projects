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
    public partial class UserControlNews : UserControl
    {
        Panel Panel;
        public UserControlNews(Panel panel)
        {
            this.Panel = panel;
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
        public bool Add(News news)
        {
            if (NewsBox1.LabelNewsTitle.Text == "")
            {
                newsBox1.Panel = Panel;
                newsBox1.News = news;
                NewsBox1.LabelNewsTitle.Text = news.Title;
                //NewsBox1.PictureBox = news.Image;
                return true;
            }
            else if (NewsBox2.LabelNewsTitle.Text == "")
            {
                newsBox2.Panel = Panel;
                newsBox2.News = news;
                NewsBox2.LabelNewsTitle.Text = news.Title;
                //NewsBox1.PictureBox = news.Image;
                return true;
            }
            else if (NewsBox3.LabelNewsTitle.Text == "")
            {
                newsBox3.Panel = Panel;
                newsBox3.News = news;
                NewsBox3.LabelNewsTitle.Text = news.Title;
                //NewsBox1.PictureBox = news.Image;
                return true;
            }
            else if (NewsBox4.LabelNewsTitle.Text == "")
            {
                newsBox4.Panel = Panel;
                newsBox4.News = news;
                NewsBox4.LabelNewsTitle.Text = news.Title;
                //NewsBox1.PictureBox = news.Image;
                return true;
            }
            else
                return false;
        }
    }
    
}
