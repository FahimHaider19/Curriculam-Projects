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
            a.UserId = (long)reader["userID"];
            a.UserName = reader["username"].ToString();
            a.FirstName = reader["first_name"].ToString();
            a.LastName = reader["last_name"].ToString();
            a.Age = (int)reader["age"];
            a.Sex = reader["sex"].ToString();
            a.Email = reader["email"].ToString();
            a.SecondaryMail = reader["secondary_mail"].ToString();
            a.Nid = (long)reader["nid"];
            a.Phone = reader["phone"].ToString();
            a.Address = reader["address"].ToString();
            a.Country = reader["country"].ToString();
            long cardNumber = (long)reader["card"];
            store.LoggedInUser = a;

            return a;
        }
        public Gamer getGamer(SqlDataReader reader)
        {
            Gamer g = new Gamer();
            g.UserId = (long)reader["userID"];
            g.UserName = reader["username"].ToString();
            g.FirstName = reader["first_name"].ToString();
            g.LastName = reader["last_name"].ToString();
            g.Age = (int)reader["age"];
            g.Sex = reader["sex"].ToString();
            g.Email = reader["email"].ToString();
            g.SecondaryMail = reader["secondary_mail"].ToString();
           // g.Nid = (long)reader["nid"];
            g.Phone = reader["phone"].ToString();
            g.Address = reader["address"].ToString();
            g.Country = reader["country"].ToString();
            g.StoreCredit = (double)reader["store_credit"];
            g.XP = (int)reader["xp"];
            g.BanStatus = (bool)reader["banstatus"];
            g.Region = reader["region"].ToString();
            long cardNumber = (long)reader["card"];

            return g;
        }
        public Developer getDeveloper(SqlDataReader reader)
        {
            Developer d = new Developer();
            d.UserId = (long)reader["userID"];
            d.UserName = reader["username"].ToString();
            d.Email = reader["email"].ToString();
            d.SecondaryMail = reader["secondary_mail"].ToString();
            d.Phone = reader["phone"].ToString();
            d.Country = reader["country"].ToString();

            return d;
        }
        public void GetUsers() //List<User>
        {
           
            string sqlUser = "Select * from Users";
            SqlDataReader readerUser = this.GetData(sqlUser);
            while (readerUser.Read())
            {
                if (readerUser["user_type"].ToString() == "gamer")
                {
                    Gamer g = getGamer(readerUser);


                    store.Gamers.Add(g);

                    //if (store.LoggedInUser.Email == readerUser["email"].ToString()) store.LoggedInUser = g;
                }
                else if (readerUser["user_type"].ToString() == "developer")
                {
                    Developer d = new Developer();
                    d.UserId = (long)readerUser["userID"];
                    d.UserName = readerUser["username"].ToString();
                    d.Email = readerUser["email"].ToString();
                    d.SecondaryMail = readerUser["secondary_mail"].ToString();
                    d.Phone = readerUser["phone"].ToString();
                    d.Country = readerUser["country"].ToString();
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
                    game.Name = reader["name"].ToString();
                    game.ProductId = (long)reader["productId"];
                    game.Price = (double)reader["price"];

                    game.Description = reader["description"].ToString();
                    // game.DiscountRate = (int)reader["discountRate"];
                    game.ImageLocations = reader["imageLocations"].ToString();
                    game.Developer = reader["developer"].ToString();
                    game.Publisher = reader["publisher"].ToString();
                    game.ReleaseDate = reader["releaseDate"].ToString();

                    store.Games.Add(game);

                    string dlcsql = "select * from products where baseGameId='" + game.ProductId + "'";

                    SqlDataReader dlcReader = this.GetData(dlcsql);
                    while (dlcReader.Read())
                    {
                        Dlc d = new Dlc();
                        d.BaseGameName = game.Name;  //bujhinai
                        d.Name = dlcReader["name"].ToString();
                        d.ProductId = (long)dlcReader["productId"];
                        d.Price = (double)dlcReader["price"];

                        d.Description = dlcReader["description"].ToString();
                        // d.DiscountRate = (int)reader["discountRate"];
                        d.ImageLocations = dlcReader["imageLocations"].ToString();
                        d.Developer = dlcReader["developer"].ToString();
                        d.Publisher = dlcReader["publisher"].ToString();
                        d.ReleaseDate = dlcReader["releaseDate"].ToString();
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
                        review.Rating = (int)reveiwreader["rating"];
                        review.Positive = (bool)reveiwreader["positive"];
                        review.ProductId = (long)reveiwreader["productId"];
                        // review.Gamer=
                        review.Revieew = reveiwreader["review"].ToString();

                        game.Reviews.Add(review);
                    }

                    string newssql = "select * from news where productId= '" + game.ProductId + "'";
                    SqlDataReader newssqlreader = this.GetData(newssql);
                    while (newssqlreader.Read())
                    {
                        News news = new News();
                        news.NewsId = (long)newssqlreader["newsId"];
                        news.Title = newssqlreader["title"].ToString();
                       // news.Topic = newssqlreader["domain"].ToString();
                        news.Date = newssqlreader["date"].ToString();
                        news.Description = newssqlreader["description"].ToString();
                        game.News.Add(news);
                        store.News.Add(news);

                    }
                }
            }

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
                else if (reader["listedAs"].ToString() == "wishlist") 
                {
                    long id = (long)reader["productId"];
                    Game gm = store.getGame(id).Copy();
                    gamer.Wishlist.Add(gm);
                }
                else if (reader["listedAs"].ToString() == "cart")
                {
                    Game gm = store.getGame((long)reader["productId"]).Copy();
                    gamer.Cart.Add(gm);
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
