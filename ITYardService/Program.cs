﻿using System;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;
using System.Linq;

namespace ITYardService
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вызов скрытых методов         
            var address1 = new Address();
            address1.City = "Poltava";
            address1.Country = "Ukraine";
            var customer1 = new Customer("Andrii");
            customer1.LastName = "Kononenko";
            // Сокрытие методов
            address1.DisplayEntityInfo();
            //customer1.DisplayEntityInfo();
            Console.ReadLine();

            
            var user1 = new User("Andriy", "Konon");
            var user2 = new User("Jonh", "*MFfs3fd213");
                        
            var repo = new UserRepository();
           

            DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(User));

            using (FileStream fs = new FileStream("people.json", FileMode.OpenOrCreate))
            {
                jsonFormatter.WriteObject(fs, repo.All());
            }


            //Console.WriteLine("{0}", user1._id);

            //repo.Insert(user1);
            //repo.Insert(user2);

            //repo.GetById(user2._id);
            //repo.DisplayUserInfo(user2._id);
            //repo.HardUpdate(user2._id);
            //repo.DisplayUserInfo(user2._id);

            //if (repo.Delete(user2._id))
            //{
            //    Console.WriteLine("delete user");
            //}

            //var users = repo.All();
            //foreach (var user in users)
            //{
            //    user.DisplayInfo();
            //}

            //Console.WriteLine($"password decrypt: \'{StringUtil.Decrypt(user1._password)}\'");

            //Custumer custumer1 = new Custumer("And", "Konon", "USA");
            //Custumer custumer2 = new Custumer("John", "Rembo", "USA");
            //custumer1.PrintFullName();
            //custumer2.PrintFullName();




            Console.ReadKey();
        }
    }
}
