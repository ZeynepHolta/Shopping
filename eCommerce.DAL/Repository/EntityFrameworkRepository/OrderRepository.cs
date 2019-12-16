using eCommerce.DAL.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace eCommerce.DAL.Repository.EntityFrameworkRepository
{
    public class OrderRepository : IOrderRepository
    {
        private ShoppingDbContext db;

        public OrderRepository()
        {
            db = new ShoppingDbContext();
        }

        public Order Get(Expression<Func<Order, bool>> filter)
        {
            return db.Set<Order>().Where(filter).SingleOrDefault();
        }

        public ICollection<Order> GetAll(Expression<Func<Order, bool>> filter = null)
        {
            if (filter == null)
            {
                return db.Set<Order>().ToList();
            }
            else
            {
                return db.Set<Order>().Where(filter).ToList();
            }
        }
    }
}
