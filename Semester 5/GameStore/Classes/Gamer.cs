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
        bool banStatus;
        string region;
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

        public  string Region
        {
            set { this.region = value; }
            get { return this.region; }
        }

        public Dictionary<long, int> Playtime
        {
            set { this.playtime = value; }
            get { return this.playtime; }
        }
        public double StoreCredit
        {
            set { this.storeCredit = value; }
            get { return this.storeCredit; }
        }
        public bool BanStatus
        {
            set { this.banStatus = value; }
            get { return this.banStatus; }
        }

        public int XP
        {
            set { this.xp = value; }
            get { return this.xp; }
        }
        public int Age
        {
            set { this.age = value; }
            get { return this.age; }
        }
        public string FirstName
        {
            set { this.firstName = value; }
            get { return this.firstName; }
        }
        public string LastName
        {
            set { this.lastName = value; }
            get { return this.lastName; }
        }
        public char Sex
        {
            set { this.sex = value; }
            get { return this.sex; }
        }
        public string Address
        {
            set { this.address = value; }
            get { return this.address; }
        }
        public long Nid
        {
            set { this.nid = value; }
            get { return this.nid; }
        }
       
        public List<Game> PurchasedGames
        {
            set { this.purchasedGames = value; }
            get { return this.purchasedGames; }
        }

        public RefundRequests[] RefundRequests
        {
            set { this.refundRequests = value; }
            get { return this.refundRequests; }
        }
        public Gamer[] Friends
        {
            set { this.friends = value; }
            get { return this.friends; }

        }
        public long[] FavouriteGamesId
        {
            set { this.favouriteGamesId = value; }
            get { return this.favouriteGamesId; }
        }
        public Gamer[] FriendRequests
        {
            set { this.friendRequests = value; }
            get { return this.friendRequests; }

        }
        public List<Product> Wishlist
        {
            set { this.wishlist = value; }
            get { return this.wishlist; }
        }
        public List<Product> Cart
        {
            set { this.cart = value; }
            get { return this.cart; }
        }
        public List<Receipt> PurchaseHistory
        {
            set { this.purchaseHistory = value; }
            get { return this.purchaseHistory; }
        }
        public List<Dlc> PurchasedDlcs
        {
            set { this.purchasedDlcs = value; }
            get { return this.purchasedDlcs; }
        }
    }
}
