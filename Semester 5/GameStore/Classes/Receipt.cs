using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Classes
{
    class Receipt
    {
        long purchaseId;
        long customerId;
        //Product productItem;
        string productType;
        string productName;
        string baseGame; //only if productType == DLC
        string dateAndTime;
        double price;

        public long PurchaseId
        {
            set { this.purchaseId = value; }
            get { return this.purchaseId; }
        }
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
        public string ProductName
        {
            set { this.productName = value; }
            get { return this.productName; }
        }

        public string BaseGame
        {
            set { this.baseGame = value; }
            get { return this.baseGame; }
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
