using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Classes
{
    public class Receipt
    {
        long customerId;
        string productType;
        long productId;
        string dateAndTime;
        double price;

        public long CustomerId
        {
            set { this.customerId = value; }
            get { return this.customerId; }
        }
        //public Product ProductItem 
        //{
        //    set { this.productItem = value; }
        //    get { return this.productItem; }
        //}
        public string ProductType
        {
            set { this.productType = value; }
            get { return this.productType; }
        }
        public long ProductId
        {
            set { this.productId = value; }
            get { return this.productId; }
        }
        public string DateAndTime
        {
            set { this.dateAndTime = value; }
            get { return this.dateAndTime; }
        }
        public double Price
        {
            set { this.price = value; }
            get { return this.price; }
        }
    }
}
