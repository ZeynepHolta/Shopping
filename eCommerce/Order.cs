using eCommerce.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eCommerce
{
    public class Order : IEntity
    {
        public int OrderId { get; set; }
        public int ShoppingCardId { get; set; }
        public DateTime OrderDate { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }

        //Nav. Prop.
        public virtual ShoppingCard ShoppingCard { get; set; }

    }
}
