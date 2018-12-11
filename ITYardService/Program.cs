using System;
using System.IO;
using System.Security.Cryptography;

namespace ITYardService
{
    
    class Program
    {
        static void Main(string[] args)
        {
            
            //qww


            var user1 = new User("Andriy", "Konon");
            var user2 = new User("Jonh", "*MFfs3fd213");
            var repo = new UserRepository();
            //Console.WriteLine("{0}", user1._id);

            repo.Insert(user1);
            repo.Insert(user2);
            
            repo.GetById(user2._id);
            repo.DisplayUserInfo(user2._id);
            repo.HardUpdate(user2._id);
            repo.DisplayUserInfo(user2._id);

            if (repo.Delete(user2._id))
            {
                Console.WriteLine("delete user");
            }

            var users = repo.All();
            foreach (var user in users)
            {
                user.DisplayInfo();
            }

            Console.WriteLine($"password decrypt: \'{StringUtil.Decrypt(user1._password)}\'");

            //Custumer custumer1 = new Custumer("And", "Konon", "USA");
            //Custumer custumer2 = new Custumer("John", "Rembo", "USA");
            //custumer1.PrintFullName();
            //custumer2.PrintFullName();
            Console.ReadKey();
        }
        
    } 
   
}
