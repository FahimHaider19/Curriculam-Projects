using DAL.EF;
using DAL.Interfaces;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        public static IRepo<User> UserDataAccess()
        {
            return new UserRepo();
        }


        public static IAuth AuthDataAccess()
        {
            return new UserRepo();
        }

        public static IRepo<Token> TokenDataAccess()
        {
            return new TokenRepo();
        }
    }
}
