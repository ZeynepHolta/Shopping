using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eCommerce.PL.Models
{
    public class AdminModel
    {
        public List<Order> Orders { get; set; }
        public List<Product> Products { get; set; }
        public List<ShoppingCard> ShoppingCards { get; set; }
    }
}