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
    public partial class UserControllStore : UserControl
    {
        public UserControllStore()
        {
            InitializeComponent();
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
        public GameBox TrendingGame7
        {
            set { this.trendingGame7 = value; }
            get { return trendingGame7; }
        }
        public GameBox TrendingGame8
        {
            set { this.trendingGame8 = value; }
            get { return trendingGame8; }
        }
        public GameBox TrendingGame9
        {
            set { this.trendingGame9 = value; }
            get { return trendingGame9; }
        }
        public GameBox TrendingGame10
        {
            set { this.trendingGame10 = value; }
            get { return trendingGame10; }
        }
        public GameBox TrendingGame11
        {
            set { this.trendingGame11 = value; }
            get { return trendingGame11; }
        }
        public GameBox TrendingGame12
        {
            set { this.trendingGame12 = value; }
            get { return trendingGame12; }
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
    }
}
