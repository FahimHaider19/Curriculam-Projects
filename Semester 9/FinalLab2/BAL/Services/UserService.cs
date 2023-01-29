using BAL.DTOs;
using DAL;
using DAL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Services
{
    public class UserService
    {
        public static List<UserDTO> Get()
        {
            List<UserDTO> users = new List<UserDTO>();
            var dbuserlist = DataAccessFactory.UserDataAccess().Get();
            foreach (var dbuser in dbuserlist)
            {
                users.Add(new UserDTO() { 
                    UserId = dbuser.UserId,
                    Username = dbuser.Uname,
                    Type = dbuser.Type,
                    Password = dbuser.Password});
            }
            return users;
        }


        public static UserDTO Get(int id)
        {
            var dbuser = DataAccessFactory.UserDataAccess().Get(id);
            UserDTO user = new UserDTO()
            {
                UserId = dbuser.UserId,
                Username = dbuser.Uname,
                Type = dbuser.Type,
                Password = dbuser.Password
            };
            return user;
        }

        public static bool Add(UserDTO dto)
        {
            User user = new User()
            {
                Uname = dto.Username,
                Type = dto.Type,
                Password = dto.Password
            };
            var result = DataAccessFactory.UserDataAccess().Add(user);
            return result;
        }

        public static bool Update(UserDTO dto)
        {
            User user = new User()
            {
                Uname = dto.Username,
                Type = dto.Type,
                Password = dto.Password
            };
            var result = DataAccessFactory.UserDataAccess().Update(user);
            return result;
        }

        public static bool Delete(int id)
        {

            var result = DataAccessFactory.UserDataAccess().Delete(id);
            return result;

        }
    }
}
