using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace eCommerce.DAL.Mapping
{
    public class OrderMapping : EntityTypeConfiguration<Order>
    {
        public OrderMapping()
        {
            Property(a => a.OrderId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(a => a.OrderDate).IsRequired().HasColumnType("date");

            Property(a => a.Quantity).IsRequired().HasColumnType("int");
        }
    }
}
