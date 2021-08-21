using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Classes
{
    public class Game : Product
    {
        bool isFavourite;



        SystemRequirements systemRequirments;
        List<Dlc> dlcs = new List<Dlc>();
        List<Review> reviews = new List<Review>();
        List<News> news = new List<News>();
        //List<string> genre = new List<string>();

        public Game() { }
        public Game(string name) { this.Name = name; }
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
        public List<string> Genre
        {
            set { this.genre = value; }
            get { return this.genre; }
        }
        public Game Copy()
        {
            Game temp = new Game();
            temp.name = this.name;
            temp.productId = this.productId;
            temp.price = price;
            temp.description = description;
            temp.discountRate = discountRate;
            temp.imageLocations = this.imageLocations;
            temp.developer = this.developer;
            temp.publisher = this.publisher;
            temp.releaseDate = this.releaseDate;
            return temp;
        }
    }
}
