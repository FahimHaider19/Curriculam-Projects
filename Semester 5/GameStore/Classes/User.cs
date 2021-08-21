using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Classes
{
    public abstract class User
    {
        protected long userID;
        protected string userName;
        protected string email;
        protected string secondaryMail;
        protected string phone;
        protected string country;
        protected PaymentCard card = new PaymentCard();
        KeyValuePair<bool, string> notifications = new KeyValuePair<bool, string>();

        public long UserId
        {
            set { this.userID = value; }
            get { return this.userID; }
        }
        public string UserName
        {
            set { this.userName = value; }
            get { return this.userName; }
        }
        public string Email
        {
            set { this.email = value; }
            get { return this.email; }
        }
        public string SecondaryMail
        {
            set { this.secondaryMail = value; }
            get { return this.secondaryMail; }
        }
        public string Phone
        {
            set { this.phone = value; }
            get { return this.phone; }
        }
        public string Country
        {
            set { this.country = value; }
            get { return this.country; }
        }
        public PaymentCard Card
        {
            set { this.card = value; }
            get { return this.card; }
        }
        public KeyValuePair<bool, string> Notifications
        {
            set { this.notifications = value; }
            get { return this.notifications; }
        }
               
    }
}
