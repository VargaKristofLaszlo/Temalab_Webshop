using System;
using System.Collections.Generic;
using System.Text;

namespace Webshop
{
   public class Cart
    {
        //Tárolt adatok
        public int CartId { get; set; }

        // A kosár egy adott felhasználóhoz tartozik
        public int UserId { get; set; }
        public User User {get;set;}

        //Egy kosárba több termék is tartozik
        public List<Product> Products { get; } = new List<Product>();
    }
}
