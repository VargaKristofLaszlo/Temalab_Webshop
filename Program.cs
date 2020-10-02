using EFGetStarted;
using System;
using System.Linq;
namespace Webshop
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (var db = new WebshopModel())
            {
                // Create
                Console.WriteLine("Inserting a new User");
                db.Add(new User { Username="teszt",Password= "123", Email_addres = "test@gmai.com" }) ;
                db.SaveChanges();

                // Read
                Console.WriteLine("Querying for a user");
                var user = db.Users
                    .OrderBy(b => b.UserId)
                    .First();

                Console.WriteLine("Felhasználónév:" + user.Username);
                Console.WriteLine("Email:" + user.Email_addres);
                Console.WriteLine("Jelszó:" + user.Password);
                /*  // Update
                  Console.WriteLine("Updating the blog and adding a post");
                  blog.Url = "https://devblogs.microsoft.com/dotnet";
                  blog.Posts.Add(
                      new Post
                      {
                          Title = "Hello World",
                          Content = "I wrote an app using EF Core!"
                      });
                  db.SaveChanges();

                  // Delete
                  Console.WriteLine("Delete the blog");
                  db.Remove(blog);
                  db.SaveChanges();*/
            }
//reeeeeeeeeeeeeeeeeeeeeeeeeeee


        }
    }
}
