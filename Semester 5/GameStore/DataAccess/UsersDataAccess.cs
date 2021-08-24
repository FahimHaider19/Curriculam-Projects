using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameStore.Classes;

namespace GameStore.DataAccess
{
    public class UsersDataAccess : DataAccess
    {
        Store store;
        public UsersDataAccess(Store store)
        {
            this.store = store;
        }
        public Admin getAdmin(SqlDataReader reader)
        {
            Admin a = new Admin();
            if (reader["userID"] != DBNull.Value) a.UserId = (long)reader["userID"];
            if (reader["username"] != DBNull.Value) a.UserName = reader["username"].ToString();
            if (reader["first_name"] != DBNull.Value) a.FirstName = reader["first_name"].ToString();
            if (reader["last_name"] != DBNull.Value) a.LastName = reader["last_name"].ToString();
            if (reader["age"] != DBNull.Value) a.Age = (int)reader["age"];
            if (reader["sex"] != DBNull.Value) a.Sex = reader["sex"].ToString();
            if (reader["email"] != DBNull.Value) a.Email = reader["email"].ToString();
            if (reader["secondary_mail"] != DBNull.Value) a.SecondaryMail = reader["secondary_mail"].ToString();
            if (reader["nid"] != DBNull.Value) a.Nid = (long)reader["nid"];
            if (reader["phone"] != DBNull.Value) a.Phone = reader["phone"].ToString();
            if (reader["address"] != DBNull.Value) a.Address = reader["address"].ToString();
            if (reader["country"] != DBNull.Value) a.Country = reader["country"].ToString();
            //long cardNumber = (long)reader["card"];
            store.LoggedInUser = a;

            return a;
        }
        public Gamer getGamer(SqlDataReader reader)
        {
            Gamer g = new Gamer();
            if (reader["userID"] != DBNull.Value) g.UserId = (long)reader["userID"];
            if (reader["username"] != DBNull.Value) g.UserName = reader["username"].ToString();
            if(reader["first_name"] != DBNull.Value) g.FirstName = reader["first_name"].ToString();
            if (reader["last_name"] != DBNull.Value) g.LastName = reader["last_name"].ToString();
            if (reader["age"] != DBNull.Value) g.Age = (int)reader["age"];
            if (reader["sex"] != DBNull.Value) g.Sex = reader["sex"].ToString();
            if (reader["email"] != DBNull.Value) g.Email = reader["email"].ToString();
            if (reader["secondary_mail"] != DBNull.Value) g.SecondaryMail = reader["secondary_mail"].ToString();
            if (reader["phone"] != DBNull.Value) g.Phone = reader["phone"].ToString();
            if (reader["address"] != DBNull.Value) g.Address = reader["address"].ToString();
            if (reader["country"] != DBNull.Value) g.Country = reader["country"].ToString();
            if (reader["store_credit"] != DBNull.Value) g.StoreCredit = (double)reader["store_credit"];
            if (reader["xp"] != DBNull.Value) g.XP = (int)reader["xp"];
            if (reader["banstatus"] != DBNull.Value) g.BanStatus = (bool)reader["banstatus"];
            if (reader["region"] != DBNull.Value) g.Region = reader["region"].ToString();

            return g;
        }
        public Developer getDeveloper(SqlDataReader reader)
        {
            Developer d = new Developer();
            if (reader["userID"] != DBNull.Value) d.UserId = (long)reader["userID"];
            if (reader["username"] != DBNull.Value) d.UserName = reader["username"].ToString();
            if (reader["email"] != DBNull.Value) d.Email = reader["email"].ToString();
            if (reader["secondary_mail"] != DBNull.Value) d.SecondaryMail = reader["secondary_mail"].ToString();
            if (reader["phone"] != DBNull.Value) d.Phone = reader["phone"].ToString();
            if (reader["country"] != DBNull.Value) d.Country = reader["country"].ToString();

            return d;
        }
        public void GetUsers() //List<User>
        {
            //List<Gamer> gamers = new List<Gamer>();
            //List<Developer> developers = new List<Developer>();
            //List<Admin> admins = new List<Admin>();
            string sqlUser = "Select * from Users";
            SqlDataReader readerUser = this.GetData(sqlUser);
            while (readerUser.Read())
            {
                
                if (readerUser["user_type"].ToString() == "gamer")
                {
                    Gamer gamer = getGamer(readerUser);
                    store.Gamers.Add(gamer);
      
                }
                else if (readerUser["user_type"].ToString() == "developer")
                {
                    Developer d = new Developer();
                    if (readerUser["userID"] != DBNull.Value) d.UserId = (long)readerUser["userID"];
                    if (readerUser["username"] != DBNull.Value) d.UserName = readerUser["username"].ToString();
                    if (readerUser["email"] != DBNull.Value) d.Email = readerUser["email"].ToString();
                    if (readerUser["secondary_mail"] != DBNull.Value) d.SecondaryMail = readerUser["secondary_mail"].ToString();
                    if (readerUser["phone"] != DBNull.Value) d.Phone = readerUser["phone"].ToString();
                    if (readerUser["country"] != DBNull.Value)  d.Country = readerUser["country"].ToString();
                    //long cardNumber = (long)reader["card"]; //retrive card
                    //cardReader = this.GetData("Select * from PaymentCards where ")
                    //notifications
                    store.Developers.Add(getDeveloper(readerUser));

                    //if (store.LoggedInUser.Email == readerUser["email"].ToString()) store.LoggedInUser = d;
                }
            }
        }
     
        public void GetProducts()
        {
            //List<Game> games = store.Games;//new List<Game>();
            //List<Dlc> dlcs = ;//new List<Dlc>();

            string sql = "Select * from Products";
            SqlDataReader reader = this.GetData(sql);
            while (reader.Read())
            {
                if (reader["productType"].ToString() == "game")
                {
                    Game game = new Game();
                    if (reader["name"] != DBNull.Value) game.Name = reader["name"].ToString();
                    if (reader["productId"] != DBNull.Value) game.ProductId = (long)reader["productId"];
                    if (reader["price"] != DBNull.Value) game.Price = (double)reader["price"];
                    if (reader["systemRequirments"] != DBNull.Value) game.SystemRequirements = reader["systemRequirments"].ToString();
                    if (reader["description"] != DBNull.Value) game.Description = reader["description"].ToString();
                    if (reader["discountRate"] != DBNull.Value) game.DiscountRate = (int)reader["discountRate"];
                    if (reader["imageBox"] != DBNull.Value) game.ImageBox = reader["imageBox"].ToString();
                    if (reader["imageCover"] != DBNull.Value) game.ImageCover = reader["imageCover"].ToString();
                    if (reader["developer"] != DBNull.Value) game.Developer = reader["developer"].ToString();
                    if (reader["publisher"] != DBNull.Value) game.Publisher = reader["publisher"].ToString();
                    if (reader["releaseDate"] != DBNull.Value) game.ReleaseDate = reader["releaseDate"].ToString();
                    if (reader["featured"] != DBNull.Value) game.Featured = (bool)reader["featured"];
                    if (reader["trending"] != DBNull.Value) game.Trending = (int)reader["trending"];
                    if (reader["onsale"] != DBNull.Value) game.OnSale = (int)reader["onsale"];
                    if (reader["published"] != DBNull.Value) game.Published = (bool)reader["published"];
                    store.Games.Add(game);

                    if (game.Featured == true) store.FeaturedGames.Add(game);
                    if(game.OnSale != -1 ) store.GamesOnSale[game.OnSale - 1] = game;
                    if (game.Trending != -1) store.TrendingGames[game.Trending-1] = game;

                    /*if (game.Published == true)
                        store.Games.Add(game);
                    else 
                        store.Pending.Add(game);*/

                    string dlcsql = "select * from products where baseGameId='" + game.ProductId + "'";

                    SqlDataReader dlcReader = this.GetData(dlcsql);
                    while (dlcReader.Read())
                    {
                        Dlc d = new Dlc();
                        d.BaseGameName = game.Name;
                        if (dlcReader["name"] != DBNull.Value) d.Name = dlcReader["name"].ToString();
                        if (dlcReader["productId"] != DBNull.Value) d.ProductId = (long)dlcReader["productId"];
                        if (dlcReader["price"] != DBNull.Value) d.Price = (double)dlcReader["price"];
                        if (dlcReader["description"] != DBNull.Value) d.Description = dlcReader["description"].ToString();
                        if (dlcReader["discountRate"] != DBNull.Value) d.DiscountRate = (int)dlcReader["discountRate"];
                        if (dlcReader["developer"] != DBNull.Value) d.Developer = dlcReader["developer"].ToString();
                        if (dlcReader["publisher"] != DBNull.Value) d.Publisher = dlcReader["publisher"].ToString();
                        if (dlcReader["releaseDate"] != DBNull.Value) d.ReleaseDate = dlcReader["releaseDate"].ToString();
                        if (dlcReader["published"] != DBNull.Value) d.Published = (bool)dlcReader["published"];
                        game.Dlcs.Add(d);

                    }

                    string catagorysql = "select category from Categories where exists(select categoryId from GameCategories where productId = '" + game.ProductId + "')";
                    SqlDataReader catagoryreader = this.GetData(catagorysql);
                    while (catagoryreader.Read())
                    {
                        game.Genre.Add(catagoryreader["category"].ToString());
                    }

                    string reviewsql = "SELECT * FROM Reviews WHERE productId = '"+game.ProductId+"' ";
                    SqlDataReader reveiwreader = this.GetData(reviewsql);
                    while (reveiwreader.Read())
                    {
                        Review review = new Review();
                        // review.game.Name = reveiwreader[""];
                        if (reveiwreader["name"] != DBNull.Value) review.User = reveiwreader["name"].ToString();
                        if (reveiwreader["rating"] != DBNull.Value) review.Rating = (int)reveiwreader["rating"];
                        //review.Positive = (bool)reveiwreader["positive"];
                        if (reveiwreader["productId"] != DBNull.Value) review.ProductId = (long)reveiwreader["productId"];
                        // review.Gamer=
                        if (reveiwreader["review"] != DBNull.Value) review.Revieew = reveiwreader["review"].ToString();

                        game.Reviews.Add(review);
                    }

                    string newssql = "select * from news where productId= '" + game.ProductId + "'";
                    SqlDataReader newssqlreader = this.GetData(newssql);
                    while (newssqlreader.Read())
                    {
                        News news = new News();
                        if (newssqlreader["newsId"] != DBNull.Value) news.NewsId = (long)newssqlreader["newsId"];
                        if (newssqlreader["title"] != DBNull.Value) news.Title = newssqlreader["title"].ToString();
                        if (newssqlreader["date"] != DBNull.Value) news.Date = newssqlreader["date"].ToString();
                        if (newssqlreader["description"] != DBNull.Value) news.Description = newssqlreader["description"].ToString();
                        game.News.Add(news);
                        store.News.Add(news);

                    }
                }
            }
            for (int i = 0; i < 4; i++) store.TopNews[i] = store.News[i];
        }

        public void getNews()
        {
            //List<News> news = new List<News>();

            string sql = "Select * from news";
            SqlDataReader reader = this.GetData(sql);
            while (reader.Read())
            {
                News n = new News();
                n.NewsId = (long)reader["newsId"];
                n.ProductId = (long)reader["productId"];
                n.Title = reader["title"].ToString();
                n.Date = reader["date"].ToString();
                n.Description = reader["description"].ToString();
                store.News.Add(n);
            }
        }

        public void getProductRecord(Gamer gamer)
        {
            string sql = "Select * from ProductRecords where userId = '"+gamer.UserId+"'";
            SqlDataReader reader = this.GetData(sql);
            //
            //Game game = new Game();
            //game.Name = "RDR2";
            //List<Dlc> dlcList = new List<Dlc>();
            //
            while (reader.Read())
            {
                if (reader["productType"].ToString() == "game" && reader["listedAs"].ToString() == "owned") 
                {
                    Game gm = store.getGame((long)reader["productId"]).Copy();
                    gamer.PurchasedGames.Add(gm);
                }
                else if(reader["productType"].ToString() == "dlc" && reader["listedAs"].ToString() == "owned")
                {
                    Dlc dlc = store.getDlc((long)reader["productId"]).Copy();
                    foreach(Game g in gamer.PurchasedGames)
                    {
                        if(g.Name == dlc.BaseGameName)
                        {
                            g.Dlcs.Add(dlc);
                            break;
                        }
                    }
                }
                else if (reader["listedAs"].ToString() == "wishlist" && reader["productType"].ToString() == "game") 
                {
                    long id = (long)reader["productId"];
                    Game gm = store.getGame(id).Copy();
                    gamer.Wishlist.Add(gm);
                }
                else if (reader["listedAs"].ToString() == "wishlist" && reader["productType"].ToString() == "dlc")
                {
                    long id = (long)reader["productId"];
                    Dlc dlc = store.getDlc(id).Copy();
                    gamer.Wishlist.Add(dlc);
                }
                else if (reader["listedAs"].ToString() == "cart" && reader["productType"].ToString() == "game")
                {
                    Game gm = store.getGame((long)reader["productId"]).Copy();
                    gamer.Cart.Add(gm);
                }
                else if (reader["listedAs"].ToString() == "cart" && reader["productType"].ToString() == "dlc")
                {
                    Dlc dlc = store.getDlc((long)reader["productId"]).Copy();
                    gamer.Cart.Add(dlc);
                }
            }
        }

        public void getReceipt(Gamer gamer)
        {
            string sql = "Select * from Receipts where userId = '" + gamer.UserId + "'";
            SqlDataReader reader = this.GetData(sql);
            Receipt r = new Receipt();

            while (reader.Read())
            {
                r.CustomerId = gamer.UserId;
                r.ProductId = (long)reader["productId"];
                r.Price = (double)reader["price"];
                r.ProductType = reader["productType"].ToString();
                //r.DateAndTime = reader["date"].ToString();
                gamer.PurchaseHistory.Add(r);
            }
        }
    }
}
