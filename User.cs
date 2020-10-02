using System;
using System.Collections.Generic;
using System.Text;

namespace Webshop
{
    public class User
    {
        //Tárolt adatok
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email_addres { get; set; }

        //Egy User-nek lehet több review-ja is termékekről.        
        public List<Review> Reviews { get; set; }

        //Egy User-nek van egy kosara        
        public Cart Cart { get; set; }
    }
}
