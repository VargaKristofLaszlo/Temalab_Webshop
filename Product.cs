using System;
using System.Collections.Generic;
using System.Text;

namespace Webshop
{
    public class Product
    {
        //Tárolt adatok
        public string Product_Name { get; set; }
        public int Price { get; set; }
        public int ProductID { get; set; }
        public string Product_Description { get; set; }
        public int Shipping_Price { get; set; }


        //Egy termék egy kategóriához tartozik
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        // Egy termék tartozhat egy kosárhoz
        public int? CartId { get; set; }
        public Cart Cart { get; set; }

        //Egy terméket egy beszállító hozhat
        public int SupplierId { get; set; }
        public Supplier Supplier { get; set; }

        //Egy terméknek több review-ja is lehet
        public List<Review> Reviews { get; set; }
    }
}
