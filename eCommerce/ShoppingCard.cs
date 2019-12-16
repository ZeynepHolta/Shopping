using eCommerce.Core;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eCommerce
{
    public class ShoppingCard : IEntity
    {
        public ShoppingCard()
        {
            Products = new HashSet<Product>();
        }

        public int ShoppingCardId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }

        //Nav. Prop.
        public virtual ICollection<Product> Products { get; set; }

        public virtual User User { get; set; }

    }
}
