using DAL.EF;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class TokenRepo : IRepo<Token>
    {
        protected FL2Entities db = new FL2Entities();

        public bool Add(Token obj)
        {
            db.Tokens.Add(obj);
            return db.SaveChanges() > 0;
        }

        public bool Delete(int id)
        {
            var token = Get(id);
            db.Tokens.Remove(token);
            return db.SaveChanges() > 0;
        }

        public List<Token> Get()
        {
            return db.Tokens.ToList();
        }

        public Token Get(int id)
        {
            return db.Tokens.FirstOrDefault(t => t.TokenId.Equals(id));
        }

        public bool Update(Token dtotoken)
        {
            var dbtoken = Get(dtotoken.TokenId);
            db.Entry(dbtoken).CurrentValues.SetValues(dtotoken);
            return db.SaveChanges() > 0;
        }
    }
}
