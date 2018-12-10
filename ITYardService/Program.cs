using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITYardService
{
    class Program
    {
        static void Main(string[] args)
        {
            var user1 = new User();
            var user2 = new User("And", "Konon");
            var repo = new UserRepository();
            repo.Insert(user1);
            repo.Insert(user2);
            var users = repo.All();

            foreach (var user in users)
            {
                user.DisplayInfo();
            }

           
            //Custumer custumer1 = new Custumer("And", "Konon", "USA");
            //Custumer custumer2 = new Custumer("John", "Rembo", "USA");
            //custumer1.PrintFullName();
            //custumer2.PrintFullName();
            Console.ReadKey();
        }
    }
}
