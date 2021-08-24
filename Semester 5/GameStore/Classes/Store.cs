using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameStore.DataAccess;

namespace GameStore.Classes
{
    public class Store
    {
        UsersDataAccess uda;
        User loggedInUser;
        string projectDirectory = System.IO.Directory.GetCurrentDirectory().Replace("\\bin\\Debug", "");
        List<Game> featuredGames = new List<Game>();
        News[] topNews =  new News[4];
        Game[] gamesOnSale = new Game[6];
        Game[] trendingGames = new Game[6];
        string viewAs;
        List<Developer> developers = new List<Developer>();
        List<Gamer> gamers = new List<Gamer>();
        string region;
        List<Game> games =  new List<Game>();
        List<News> news = new List<News>();
        List<RefundRequests> refundRequests = new List<RefundRequests>();
        List<Game> pending = new List<Game>();

        public UsersDataAccess Uda
        {
            set { this.uda = value; }
            get { return uda; }
        }
        public User LoggedInUser
        {
            set { this.loggedInUser = value; }
            get { return loggedInUser; }
        }
        public string ProjectDirectory
        {
            set { this.projectDirectory = value; }
            get { return projectDirectory; }
        }
        public List<Game> FeaturedGames
        {
            set { this.featuredGames = value; }
            get { return this.featuredGames; }
        }
        public Game[] GamesOnSale
        {
            set { this.gamesOnSale = value; }
            get { return this.gamesOnSale; }
        }
        public Game[] TrendingGames
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
        public List<Gamer> Gamers
        {
            set { this.gamers = value; }
            get { return this.gamers; }
        }
        public List<Developer> Developers
        {
            set { this.developers = value; }
            get { return this.developers; }
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
        public List<Game> Pending
        {
            set { this.pending = value; }
            get { return this.pending; }
        }
        public Game getGame(long id)
        {
            foreach(Game g in games)
            {
                if(g.ProductId == id)
                {
                    return g;
                }
            }
            return null;
        }
        public Game getGame(string name)
        {
            foreach (Game g in games)
            {
                if (g.Name == name)
                {
                    return g;
                }
            }
            return null;
        }
        public Dlc getDlc(long dlcId)
        {
            foreach(Game game in games)
            {
                foreach(Dlc d in game.Dlcs)
                {
                    if(d.ProductId == dlcId)
                    {
                        return d;
                    }
                }
            }
            return null;
        }
        public Gamer getGamer(long id)
        {
            foreach(Gamer g in gamers)
            {
                if(g.UserId == id)
                {
                    return g;
                }
            }
            return null;
        }
        public News getNews(string title)
        {
            foreach(News n in news)
            {
                if (n.Title == title)
                    return n;
            }
            return null;
        }
    }
}
