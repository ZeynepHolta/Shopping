using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace eCommerce.DAL.Mapping
{
    public class ProductMapping : EntityTypeConfiguration<Product>
    {
        public ProductMapping()
        {
            Property(a => a.ProductId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(a => a.ProductName).IsRequired().HasColumnType("nvarchar").HasMaxLength(50);

            Property(a => a.Price).IsRequired().HasColumnType("decimal");

            HasMany(a => a.ShoppingCards)
                .WithMany(a => a.Products)
                .Map(z =>
                {
                    z.MapLeftKey("ProductId");
                    z.MapRightKey("ShoppingCardId");
                    z.ToTable("ShoppingCardProductDetails");
                });
        }
    }
}
