using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Classes
{
    abstract class Product
    {
        protected string name;
        protected long productId;
        protected double price;
        protected string description;
        protected int discountRate;
        string imageLocations;
        string developer;
        string publisher;
        string releaseDate;
        List<string> genre =  new List<string>();

        public List<string> Genre
        {
            set { this.genre = value; }
            get { return this.genre; }
        }
        public string ReleaseDate
        {
            set { this.releaseDate = value; }
            get { return this.releaseDate; }
        }
        public string Developer
        {
            set { this.developer = value; }
            get { return this.developer; }
        }
        public string Publisher
        {
            set { this.publisher = value; }
            get { return this.publisher; }
        }

        public string ImageLocations
        {
            set { this.imageLocations = value; }
            get { return this.imageLocations; }
        }
        public int DiscountRate
        {
            set { this.discountRate = value; }
            get { return this.discountRate; }
        }
       
        public string Name
        {
            set { this.name = value; }
            get { return this.name; }
        }
        public long ProductId
        {
            set { this.productId = value; }
            get { return this.productId; }
        }
        public double Price
        {
            set { this.price = value; }
            get { return this.price; }
        }
        public string Description
        {
            set { this.description = value; }
            get { return this.description; }
        }
    }
}
