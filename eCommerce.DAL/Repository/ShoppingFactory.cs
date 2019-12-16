using System.Data.Entity.Infrastructure;

namespace eCommerce.DAL.Repository
{
    public class ShoppingFactory : IDbContextFactory<ShoppingDbContext>
    {
        public static ShoppingDbContext _instance;

        public static ShoppingDbContext GetInstance()
        {
            if (_instance == null)
            {
                _instance = new ShoppingDbContext();
            }
            return _instance;
        }
        public ShoppingDbContext Create()
        {
            return GetInstance();
        }
    }
}
