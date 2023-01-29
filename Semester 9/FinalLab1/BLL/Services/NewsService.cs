using BLL.DTOs;
using DAL.EF;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    internal class NewsService
    {
        public static List<NewsDTO> Get()
        {
            DBEntities db = new DBEntities();

            List<NewsDTO> newslist = new List<NewsDTO>();
            var nl = new NewsRepo().Get();
            if (nl != null) { 
                foreach (News news in nl) {
                    var ct = new CategoryRepo().Get(news.NewsId);
                    CategoryDTO category = new CategoryDTO();
                    category.CategoryId = ct.CategoryId;
                    category.CategoryName = ct.CategoryName;

                    newslist.Add(new NewsDTO()
                    {
                        NewsId = news.NewsId,
                        Title = news.Title,
                        Category = category,
                    });
                }
            }
            return newslist;
        }
    }
}
