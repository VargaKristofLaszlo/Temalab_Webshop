using System;
using System.Collections.Generic;
using System.Text;

namespace Webshop
{
    public class Category
    {
        //Tárolt adatok
        public string Category_Name { get; set; }
        public int CategoryId { get; set; }

        //Egy Category több termékhez tartozik.
        public List<Product> Products { get; set; }
    }
}
