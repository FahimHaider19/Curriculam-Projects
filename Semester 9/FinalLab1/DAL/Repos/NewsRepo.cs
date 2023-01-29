using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class NewsRepo : IRepo<News>
    {
        DBEntities db = new DBEntities();
        public void Create(News obj)
        {
            db.News.Add(obj);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            var news = (from n in db.News
                        where n.NewsId == id
                        select n).FirstOrDefault();
            db.News.Remove(news);
            db.SaveChanges();
        }

        public List<News> Get()
        {
            var newslist = (from n in db.News
                            select n).ToList();
            return newslist;
        }

        public News Get(int id)
        {
            var news = (from n in db.News
                        where n.NewsId == id
                        select n).FirstOrDefault();
            return news;
        }

        public void Update(News obj)
        {
            var news = (from n in db.News
                        where n.NewsId == obj.NewsId
                        select n).FirstOrDefault();
            db.Entry(news).CurrentValues.SetValues(obj);
            db.SaveChanges();
        }
    }
}
