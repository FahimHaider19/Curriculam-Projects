using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Classes
{
    class Review
    {
        
        Gamer gamer;
        long productId;
        int rating;
        bool positive;
        string review;
        public long ProductId
        {
            set { this.productId = value; }
            get { return this.productId; }
        }
        public Gamer Gamer
        {
            set { this.gamer = value; }
            get { return this.gamer; }
        }
        
        public int Rating
        {
            set { this.rating = value; }
            get { return this.rating; }
        }
        public bool Positive
        {
            set { this.positive = value; }
            get { return this.positive; }
        }
        public string Revieew
        {
            set { this.review = value; }
            get { return this.review; }
        }

    }
}
