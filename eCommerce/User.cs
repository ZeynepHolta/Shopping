using eCommerce.Core;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eCommerce
{
    public class User : IEntity
    {
        public User()
        {
            ShoppingCards = new HashSet<ShoppingCard>();
        }

        public int UserId { get; set; }
        public int ShoppingCardId { get; set; }

        [Required(ErrorMessage = "Enter Username !")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Enter user Password !")]
        public string Password { get; set; }

        //Nav. Prop.
        public virtual ICollection<ShoppingCard> ShoppingCards { get; set; }


    }
}
