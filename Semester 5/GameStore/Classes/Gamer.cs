using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameStore.Interface;

namespace GameStore.Classes
{
    class Gamer : User//, IPurchase
    {
        int age;
        string firstName;
        string lastName;
        long nid;
        char sex;
        string address;
        double storeCredit;
        int xp;
        List<Game> purchasedGames = new List<Game>();
        List<Dlc> purchasedDlcs = new List<Dlc>();
        Gamer[] friends;
        Gamer[] friendRequests;
        List<Product> wishlist = new List<Product>();
        List<Product> cart = new List<Product>();
        List<Receipt> purchaseHistory = new List<Receipt>();
        long[] favouriteGamesId;
        Dictionary<long, int> playtime = new Dictionary<long, int>();
        RefundRequests[] refundRequests = new RefundRequests[5];
    }
}
