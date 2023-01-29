//using Microsoft.Analytics.Interfaces;
//using Microsoft.Analytics.Types.Sql;
using NoHunger.DB;
using NoHunger.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace NoHunger.Repo
{
    public class FoodRepo
    {
        public static List<FoodModel> Get()
        {
            var db = new NoHungerEntities();
            var foods = new List<FoodModel>();
            foreach (var f in db.Foods)
            {
                foods.Add(new FoodModel()
                {
                    FoodId = f.FoodId,
                    FoodName = f.FoodName,
                    FoodType = f.FoodType,
                    PersonQuntity = (int)f.PersonQuantity,
                    PickupPoint= f.PickupPoint,
                    Expire = (DateTime)f.Expire,
                    Donor = (UserModel)UserRepo.Get(f.FoodDonor),
                }) ;
            }
            return foods;
        }

        public static object Get(int FoodId)
        {
            var db = new NoHungerEntities();
            var Food = (from f in db.Foods
                        where f.FoodId == FoodId
                        select f).FirstOrDefault();
            var FoodModel = new FoodModel();
            FoodModel.FoodId = Food.FoodId;
            FoodModel.FoodName = Food.FoodName;
            FoodModel.FoodType = Food.FoodType;
            FoodModel.Expire = Convert.ToDateTime(Food.Expire);
            FoodModel.PersonQuntity = (int)Food.PersonQuantity;
            FoodModel.PickupPoint = Food.PickupPoint;
            FoodModel.Donor = (UserModel)UserRepo.Get((int)Food.FoodDonor);
            return FoodModel;
        }

        public static void Create(FoodModel Food)
        {
            var f = new Food();
            //f.FoodId = Food.FoodId;
            f.FoodName = Food.FoodName;
            f.FoodType= Food.FoodType;
            f.PersonQuantity = Food.PersonQuntity;
            f.PickupPoint = Food.PickupPoint;
            f.FoodDonor = 5;
            f.Expire = Food.Expire;
            var db = new NoHungerEntities();
            db.Foods.Add(f);
            db.SaveChanges();
        }

        public static void Update(FoodModel Food)
        {
            var db = new NoHungerEntities();
            var f = (from fd in db.Foods
                     where fd.FoodId == Food.FoodId
                     select fd).FirstOrDefault();
            /*f.name = Food.FoodName;
            f.password = Food.Password;
            f.role = Food.Role;
            db.Foods.Add(f);*/
            db.Entry(f).CurrentValues.SetValues(Food);
            db.SaveChanges();
        }

        public static void Delete(FoodModel food)
        {
            var db = new NoHungerEntities();
            db.Foods.Remove(new Food() { FoodId = food.FoodId });
            db.SaveChanges();
        }
    }
}