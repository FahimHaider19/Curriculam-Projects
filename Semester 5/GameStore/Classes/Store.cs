using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Classes
{
    class Store
    {
        Game[] featuredGames = new Game[10];
        News[] topNews =  new News[10];
        Game[] gamesOnSale = new Game[10];
        Game[] trendingGames = new Game[10];
        string viewAs;
        List<User> user = new List<User>();
        string region;
        List<Game> games =  new List<Game>();
        List<News> news = new List<News>();
        List<RefundRequests> refundRequests = new List<RefundRequests>();

        public Game[] FeaturedGames
        {
            set { this.featuredGames = value; }
            get { return this.featuredGames; }
        }
        public Game[] GamesOnSale
        {
            set { this.gamesOnSale = value; }
            get { return this.gamesOnSale; }
        }
        public Game[] GrendingGames
        {
            set { this.trendingGames = value; }
            get { return this.trendingGames; }
        }
        public News[] TopNews
        {
            set { this.topNews = value; }
            get { return this.topNews; }
        }
        public string ViewAs
        {
            set { this.viewAs = value; }
            get { return this.viewAs; }
        }
        public string Region
        {
            set { this.region = value; }
            get { return this.region; }
        }
        public List<User> User
        {
            set { this.user = value; }
            get { return this.user; }
        }
        public List<Game> Games
        {
            set { this.games = value; }
            get { return this.games; }
        }
        public List<News> News
        {
            set { this.news = value; }
            get { return this.news; }
        }
        public List<RefundRequests> RefundRequests
        {
            set { this.refundRequests = value; }
            get { return this.refundRequests; }
        }

    }
}
