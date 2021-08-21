using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Classes
{
    public class Developer : User
    {
        List<Game> publishedGames = new List<Game>();
        
        public List<Game> PublishedGames
        {
            set { this.publishedGames = value; }
            get { return this.publishedGames; }
        }

        void publishGame(Game game) { }
        void updateGame(Game game) { }
        void setDiscount(Game game, double discountPercentage) { }
        void removeDiscount(Game game) { }
        void removePublishedGame(Game game) { }

    }
}