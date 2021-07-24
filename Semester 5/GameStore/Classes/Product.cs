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
        protected long id;
        protected double price;
        protected string description;
        protected int discountRate;
        string imageLocations;
        string developer;
        string publisher;
        string releaseDate;
        List<string> genre =  new List<string>();
    }
}
