using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace eCommerce.DAL.Mapping
{
    public class UserMapping : EntityTypeConfiguration<User>
    {
        public UserMapping()
        {
            Property(a => a.UserId).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(a => a.Username).IsRequired().HasColumnType("nvarchar").HasMaxLength(50);

            Property(a => a.Password).IsRequired().HasColumnType("nvarchar").HasMaxLength(16);
        }
    }
}
