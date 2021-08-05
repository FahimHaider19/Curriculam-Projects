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
        string customerName;
        string productType;
        string productName;
        string gameName; //only if productType == DLC
        string dateAndTime;
        double price;
        public long PurchaseId
        {
            set { this.purchaseId = value; }
            get { return this.purchaseId; }
        }
        public string CustomerName
        {
            set { this.customerName = value; }
            get { return this.customerName; }
        }
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

        public string GameName
        {
            set { this.gameName = value; }
            get { return this.gameName; }
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
