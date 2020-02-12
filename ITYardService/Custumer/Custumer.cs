using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;

namespace ITYardService
{
    [DataContract]
    public class Customer : EntityBase<T> 
    {
        public Customer() : base()
        {
        }
        public Customer(string name)
        {
            // base.Id = customerId;
            this.Name = name;
            AddressList = new List<Address>();
        }
        public List<Address> AddressList { get; set; }
        public int CustomerType { get; set; }
        public static int InstanceCount { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        [DataMember]
        public string FullName
        {
            get
            {
                return this.Name + " " + this.LastName;
            }
        }

        public object Id { get; internal set; }

        public void GetOrder()
        {
            // вернуть лист ордера
        }
        public override void DisplayEntityInfo()
        {
            Console.WriteLine($"Customer Id - {base.Id}, first name - {this.Name}, last name - {this.LastName}");
        }
        public override bool Validator()
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
