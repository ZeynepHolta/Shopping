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
    public class ProductRepository : IProductRepository
    {
        ShoppingDbContext db;

        public ProductRepository()
        {
            db = new ShoppingDbContext();
        }

        public void Add(Product entity)
        {
            db.Entry(entity).State = EntityState.Added;
            Save();
        }

        public void Delete(Product entity)
        {
            db.Entry(entity).State = EntityState.Deleted;
            Save();
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            return db.Set<Product>().Where(filter).SingleOrDefault();
        }

        public ICollection<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            if (filter == null)
            {
                return db.Set<Product>().ToList();
            }
            else
            {
                return db.Set<Product>().Where(filter).ToList();
            }
        }

        public int Save()
        {
            return db.SaveChanges();
        }

        public void Update(Product entity)
        {
            db.Entry(entity).State = EntityState.Modified;
            Save();
        }
    }
}
