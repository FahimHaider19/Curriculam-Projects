using DAL.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class CategoryRepo
    {
        public Category Get(int id)
        {
            DBEntities db = new DBEntities();
            var category = (from c in db.Categories
                      where c.CategoryId == id
                      select c).FirstOrDefault();
            return category;
        }
    }
}
