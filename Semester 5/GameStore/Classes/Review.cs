using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Classes
{
    public class Review
    {
        string user;
        long productId;
        int rating;
        bool positive;
        string review;

        public string User
        {
            set { this.user = value; }
            get { return this.user; }
        }
        public long ProductId
        {
            set { this.productId = value; }
            get { return this.productId; }
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
