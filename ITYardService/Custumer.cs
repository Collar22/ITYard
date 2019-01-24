using System;
using System.Collections.Generic;

namespace ITYardService
{

    public class Customer : EntityBase
    {
        public Customer()
            : this(0, string.Empty)
        {
        }
        public Customer(int customerId, string name)
        {
            base.Id = customerId;
            base.Name = name;
            AddressList = new List<Address>();
        }
        public List<Address> AddressList { get; set; }
        public int CustomerType { get; set; }
        public static int InstanceCount { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }

        public string FullName
        {
            get
            {
                return this.Name + " " + this.LastName;
            }
        }
        public override void DisplayEntityInfo()
        {
            Console.WriteLine($"Customer Id - {base.Id}, first name - {base.Name}, last name - {this.LastName}");
        }
        public override bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;
            return isValid;
        }
    }




    //class Custumer
    //{
    //    int age;
    //    static string _country = "Ukraine";
    //    string _firstName;
    //    string _lastName;

    //    //static Custumer()
    //    //{
    //    //    _country = "Argentina";
    //    //}

    //    public Custumer(string firstName, string lastName, string country)
    //    {
    //        _country = country;
    //        _firstName = firstName;
    //        _lastName = lastName;
    //    }

    //    public void PrintFullName()
    //    {
    //        Console.WriteLine($"Full name is {_firstName} {_lastName} from country {_country}");
    //    }
    //}



}
