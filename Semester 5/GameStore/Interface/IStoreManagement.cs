using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameStore.Classes;

namespace GameStore.Interface
{
    interface IStoreManagement
    {
        void addFeaturedGames(Game game);
        void removeFeaturedGames(Game game);
        void addTopNews(News news);
        void removeTopNews(News news);
        void warning(User user, string text);
    }
}
