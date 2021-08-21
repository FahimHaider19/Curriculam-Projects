using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Classes
{
    public class Dlc : Product
    {
        string baseGameName;
        public string BaseGameName
        {
            set { this.baseGameName = value; }
            get { return this.baseGameName; }
        }
        
        public Dlc Copy()
        {
            Dlc temp = new Dlc();
            temp.name = this.name;
            temp.productId = this.productId;
            temp.price = price;
            temp.description = description;
            temp.discountRate = discountRate;
            temp.imageLocations = this.imageLocations;
            temp.developer = this.developer;
            temp.publisher = this.publisher;
            temp.releaseDate = this.releaseDate;
            temp.baseGameName = this.baseGameName;
            return temp;
        }
    }
}
