using System;
using System.Collections.Generic;
using System.Text;

namespace Webshop
{
    public class Review
    {
        //Tárolt adatok  
        public string Description { get; set; }
        public int Stars { get; set; }
        public int ReviewId { get; set; }


        //Egy review egy termékhez tartozik
        public int ProductId { get; set; }
        public Product Product { get; set; }

        // Egy review egy felhasználóhoz tartozik
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
