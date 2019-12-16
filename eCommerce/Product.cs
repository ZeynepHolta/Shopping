using eCommerce.Core;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eCommerce
{
    public class Product : IEntity
    {
        public Product()
        {
            ShoppingCards = new HashSet<ShoppingCard>();
        }

        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }

        //Nav. Prop.
        public virtual ICollection<ShoppingCard> ShoppingCards { get; set; }
    }
}
