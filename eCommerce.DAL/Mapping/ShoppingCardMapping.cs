using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace eCommerce.DAL.Mapping
{
    public class ShoppingCardMapping : EntityTypeConfiguration<ShoppingCard>
    {
        public ShoppingCardMapping()
        {
            Property(a => a.ShoppingCardId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(a => a.Quantity).IsRequired().HasColumnType("int");

            Property(a => a.TotalPrice).IsRequired().HasColumnType("decimal");
        }
    }
}
