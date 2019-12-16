using eCommerce.DAL.Mapping;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace eCommerce.DAL.Repository
{
    public class ShoppingDbContext : DbContext
    {
        public ShoppingDbContext() : base("Server=.; Database=ShoppingDB; Trusted_Connection=true")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<ShoppingDbContext>());
            //Database.SetInitializer(new DropCreateDatabaseAlways<ShoppingDbContext>());
        }

        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ShoppingCard> ShoppingCards { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new OrderMapping());
            modelBuilder.Configurations.Add(new ProductMapping());
            modelBuilder.Configurations.Add(new ShoppingCardMapping());
            modelBuilder.Configurations.Add(new UserMapping());

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
