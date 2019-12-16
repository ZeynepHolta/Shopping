using eCommerce.DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.DAL.Repository.EntityFrameworkRepository
{
    public class ShoppingCardRepository : IShoppingCardRepository
    {
        ShoppingDbContext db;

        public ShoppingCardRepository()
        {
            db = new ShoppingDbContext();
        }

        public void Add(ShoppingCard entity)
        {
            db.Entry(entity).State = EntityState.Added;
            Save();
        }

        public void Delete(ShoppingCard entity)
        {
            db.Entry(entity).State = EntityState.Deleted;
            Save();
        }

        public ShoppingCard Get(Expression<Func<ShoppingCard, bool>> filter)
        {
            return db.Set<ShoppingCard>().Where(filter).SingleOrDefault();
        }

        public ICollection<ShoppingCard> GetAll(Expression<Func<ShoppingCard, bool>> filter = null)
        {
            if (filter == null)
            {
                return db.Set<ShoppingCard>().ToList();
            }
            else
            {
                return db.Set<ShoppingCard>().Where(filter).ToList();
            }
        }

        public int Save()
        {
            return db.SaveChanges();
        }

        public void Update(ShoppingCard entity)
        {
            db.Entry(entity).State = EntityState.Modified;
            Save();
        }
    }
}
