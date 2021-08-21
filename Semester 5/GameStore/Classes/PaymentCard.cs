using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Classes
{
    public class PaymentCard
    {
        string brand;
        int length;
        string owner;
        string cardNumber;
        string cardType;
        string expiryDate;
        int cvv;

        public string Brand
        {
            set { this.brand = value; }
            get { return this.brand; }
        }
        public int Length
        {
            set { this.length = value; }
            get { return this.length; }
        }
        public string Owner
        {
            set { this.owner = value; }
            get { return this.owner; }
        }
        public string CardNumber
        {
            set { this.cardNumber = value; }
            get { return this.cardNumber; }
        }
        public string CardType
        {
            set { this.cardType = value; }
            get { return this.cardType; }
        }
        public string ExpiryDate
        {
            set { this.expiryDate = value; }
            get { return this.expiryDate; }
        }
        public int Cvv
        {
            set { this.cvv = value; }
            get { return this.cvv; }
        }
    }
}
