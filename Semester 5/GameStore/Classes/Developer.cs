using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Classes
{
    class Developer : User
    {
        List<Game> publishedGames = new List<Game>();
        void publishGame(Game game) { }
        void updateGame(Game game) { }
        void setDiscount(Game game, double discountPercentage) { }
        void removeDiscount(Game game) { }
        void removePublishedGame(Game game) { }
    }
}