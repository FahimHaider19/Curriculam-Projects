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
        string viewAs;
        List<User> user = new List<User>();
        string region;
        List<Game> games =  new List<Game>();
        List<News> news = new List<News>();
        List<RefundRequests> refundRequests = new List<RefundRequests>();
    }
}
