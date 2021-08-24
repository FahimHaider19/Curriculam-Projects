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


namespace GameStore.WinForms
{
    public partial class UserControlStore : UserControl
    {
        Store store;
        Panel panel;
        int index = 0;
        string[] str = new string[5] { "581580.jpg", "destiny_2_forsaken.jpg", "ElQObD9VMAUnIZF.jpg", "og.jpg", "602603.jpg" };

        /*public UserControlStore()
        {
            InitializeComponent();
            loadImage();
        }*/
        public UserControlStore(Store store, Panel panel)
        {
            this.store = store;
            this.panel = panel;
            InitializeComponent();
            loadImage();
            LoadPage();
        }
        public void loadImage()
        {
            timer.Enabled = true;
            pictureBox.Image = Image.FromFile(store.ProjectDirectory+"\\"+str[index%5]);
            index++;
        }
        public void LoadPage()
        {
            InsertGamebox(this.gameOnSale1, store.GamesOnSale[0]);
            InsertGamebox(this.gameOnSale2, store.GamesOnSale[1]);
            InsertGamebox(this.gameOnSale3, store.GamesOnSale[2]);
            InsertGamebox(this.gameOnSale4, store.GamesOnSale[3]);
            InsertGamebox(this.gameOnSale5, store.GamesOnSale[4]);
            InsertGamebox(this.gameOnSale6, store.GamesOnSale[5]);

            InsertGamebox(this.TrendingGame1, store.TrendingGames[0]);
            InsertGamebox(this.TrendingGame2, store.TrendingGames[1]);
            InsertGamebox(this.TrendingGame3, store.TrendingGames[2]);
            InsertGamebox(this.TrendingGame4, store.TrendingGames[3]);
            InsertGamebox(this.TrendingGame5, store.TrendingGames[4]);
            InsertGamebox(this.TrendingGame6, store.TrendingGames[5]);

            InsertNews(this.TopNews1, store.TopNews[0]);
            InsertNews(this.TopNews2, store.TopNews[1]);
            InsertNews(this.TopNews3, store.TopNews[2]);
            InsertNews(this.TopNews4, store.TopNews[3]);
        }
        
        public void InsertGamebox(GameBox to, Game game)
        {
            to.Game = game;
            to.Panel = panel;
            //to.PictureBox = game.ImageLocations;
            to.LabelGameboxGameName.Text = game.Name;
            to.LabelpriceTag.Text = game.Price.ToString()+"$";
        }
        public void InsertNews(NewsBox newsBox, News news)
        {
            newsBox.Panel = panel;
            newsBox.News = news;
            //newsBox.PictureBox = 
            newsBox.LabelNewsTitle.Text = news.Title;
        }
        public GameBox GameOnSale1
        {
            set { this.gameOnSale1 = value; }
            get { return gameOnSale1; }
        }
        public GameBox GameOnSale2
        {
            set { this.gameOnSale2 = value; }
            get { return gameOnSale2; }
        }
        public GameBox GameOnSale3
        {
            set { this.gameOnSale3 = value; }
            get { return gameOnSale3; }
        }
        public GameBox GameOnSale4
        {
            set { this.gameOnSale4 = value; }
            get { return gameOnSale4; }
        }
        public GameBox GameOnSale5
        {
            set { this.gameOnSale5 = value; }
            get { return gameOnSale5; }
        }
        public GameBox GameOnSale6
        {
            set { this.gameOnSale6 = value; }
            get { return gameOnSale6; }
        }


        public GameBox TrendingGame1
        {
            set { this.trendingGame1 = value; }
            get { return trendingGame1; }
        }
        public GameBox TrendingGame2
        {
            set { this.trendingGame2 = value; }
            get { return trendingGame2; }
        }
        public GameBox TrendingGame3
        {
            set { this.trendingGame3 = value; }
            get { return trendingGame3; }
        }
        public GameBox TrendingGame4
        {
            set { this.trendingGame4 = value; }
            get { return trendingGame4; }
        }
        public GameBox TrendingGame5
        {
            set { this.trendingGame5 = value; }
            get { return trendingGame5; }
        }
        public GameBox TrendingGame6
        {
            set { this.trendingGame6 = value; }
            get { return trendingGame6; }
        }
        
        public  NewsBox TopNews1
        {
            set { this.topNews1 = value; }
            get { return topNews1; }
        }
        public NewsBox TopNews2
        {
            set { this.topNews2 = value; }
            get { return topNews2; }
        }
        public NewsBox TopNews3
        {
            set { this.topNews3 = value; }
            get { return topNews3; }
        }
        public NewsBox TopNews4
        {
            set { this.topNews4 = value; }
            get { return topNews4; }
        }

        private void panelBase_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            loadImage();
        }
        
    }
}
