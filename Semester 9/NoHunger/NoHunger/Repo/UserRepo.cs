//using Microsoft.Analytics.Interfaces;
//using Microsoft.Analytics.Types.Sql;
using NoHunger.DB;
using NoHunger.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace NoHunger.Repo
{
    public class UserRepo
    {
        public static List<UserModel> Get()
        {
            var db = new NoHungerEntities();
            var users = new List<UserModel>();
            foreach (var u in db.Users)
            {
                users.Add(new UserModel()
                {
                    UserId = u.UserId,
                    UserName = u.UserName,
                    Password = u.Password,
                    Role = u.Role
                });
            }
            return users;
        }

        public static void Create(UserModel user)
        {
            var u = new User();
            u.UserId = user.UserId;
            u.UserName = user.UserName; 
            u.Password = user.Password;
            u.Role = user.Role;

            var db = new NoHungerEntities();
            db.Users.Add(u);
            db.SaveChanges();
        }

        public static object Get(int userId)
        {
            var db = new NoHungerEntities();
            var User = (from u in db.Users
                           where u.UserId == userId
                           select u).FirstOrDefault();
            var UserModel = new UserModel();
            UserModel.UserId = User.UserId;
            UserModel.UserName = User.UserName;
            UserModel.Role = User.Role;
            return UserModel;
        }

        public static void Update(UserModel user)
        {
            var db = new NoHungerEntities();
            var u = (from usr in db.Users
                     where usr.UserId == user.UserId
                     select usr).FirstOrDefault();
            /*u.name = user.UserName;
            u.password = user.Password;
            u.role = user.Role;
            db.users.Add(u);*/
            db.Entry(u).CurrentValues.SetValues(user);
            db.SaveChanges();
        }

        public static void Delete(UserModel user)
        {
            var db = new NoHungerEntities();
            db.Users.Remove(new User() { UserId = user.UserId});
            db.SaveChanges();
        }

    }
}