using BAL.DTOs;
using DAL.EF;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL.Services
{
    public class AuthService
    {
        public static TokenDTO Authenticate(string uname, string pass)
        {
            var user = DataAccessFactory.AuthDataAccess().Authenticate(uname, pass);
            if (user != null)
            {
                var token = new Token();
                token.UserId = user.UserId;
                token.Create = DateTime.Now;
                token.TokenKey = Guid.NewGuid().ToString();
                var obj = DataAccessFactory.TokenDataAccess().Add(token);
                TokenDTO tokenDTO = new TokenDTO();
                tokenDTO.TokenKey = token.TokenKey;
                tokenDTO.Username = uname;
                tokenDTO.CreationTime = token.Create;
                return tokenDTO;
            }
            return null;
        }
        public static bool IsTokenValid(int id)
        {
            var tk = DataAccessFactory.TokenDataAccess().Get(id);

            if (tk != null && tk.Expire == null)
            {
                return true;
            }
            return false;


        }

        public static bool IsTokenValid(string v1, int v2)
        {
            throw new NotImplementedException();
        }
    }
}
