using eCommerce.DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.DAL.Repository.EntityFrameworkRepository
{
    public class UserRepository : IUserRepository
    {
        ShoppingDbContext db;

        public UserRepository()
        {
            db = new ShoppingDbContext();
        }

        public User Get(Expression<Func<User, bool>> filter)
        {
            return db.Set<User>().Where(filter).SingleOrDefault();
        }

        public ICollection<User> GetAll(Expression<Func<User, bool>> filter = null)
        {
            if (filter == null)
            {
                return db.Set<User>().ToList();
            }
            else
            {
                return db.Set<User>().Where(filter).ToList();
            }
        }
    }
}
