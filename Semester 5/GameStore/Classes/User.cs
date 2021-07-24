using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Classes
{
    abstract class User
    {
        protected string userName;
        int userID;
        protected string email;
        protected string secondaryMail;
        protected string phone;
        string region;
        protected string country;
        protected PaymentCard card = new PaymentCard();
        bool banStatus;
        KeyValuePair<bool, string> notifications = new KeyValuePair<bool, string>();
    }
}
