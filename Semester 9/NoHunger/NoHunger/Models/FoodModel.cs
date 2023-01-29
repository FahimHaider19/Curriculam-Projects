//using Microsoft.Analytics.Interfaces;
//using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace NoHunger.Models
{
    public class FoodModel
    {
        public int FoodId { get; set; }
        public String FoodName { get; set; }
        public  DateTime Expire { get; set; }
        public String FoodType { get; set;}
        public int PersonQuntity { get; set; }
        public String PickupPoint { get; set;}
        public UserModel Donor { get; set; }
    }
}