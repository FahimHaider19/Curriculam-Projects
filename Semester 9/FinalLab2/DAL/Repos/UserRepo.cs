using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class UserRepo : IRepo<User>, IAuth
    {
        protected FL2Entities db = new FL2Entities();

        public bool Add(User user)
        {
            db.Users.Add(user);
            return db.SaveChanges() > 0;
        }

        public User Authenticate(string username, string password)
        {
            var obj = db.Users.FirstOrDefault(
                x => x.Uname.Equals(username) && x.Password.Equals(password)
                );
            return obj;
        }

        public bool Delete(int id)
        {
            var user = Get(id);
            db.Users.Remove(user);
            return db.SaveChanges() > 0;
        }

        public List<User> Get()
        {
            return db.Users.ToList();
        }

        public User Get(int id)
        {
            return db.Users.Find(id);
        }

        public bool Update(User dtouser)
        {
            var dbuser = Get(dtouser.UserId);
            db.Entry(dbuser).CurrentValues.SetValues(dtouser);
            return db.SaveChanges() > 0;
        }
    }
}
