using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Classes
{
    class Game : Product
    {
        bool isFavourite;



        SystemRequirements systemRequirments;
        List<Dlc> dlcs = new List<Dlc>();
        List<Review> reviews = new List<Review>();
        List<News> news = new List<News>();

        public SystemRequirements SystemRequirements
        {
            set { this.systemRequirments = value; }
            get { return this.systemRequirments; }
        }
        public List<Dlc> Dlcs
        {
            set { this.dlcs = value; }
            get { return this.dlcs; }
        }
        public List<Review> Reviews
        {
            set { this.reviews = value; }
            get { return this.reviews; }
        }
        public List<News> News
        {
            set { this.news = value; }
            get { return this.news; }
        }

    }
}
