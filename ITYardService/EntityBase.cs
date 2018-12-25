﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ITYardService
{
    public class EntityBase : Entity
    {
       public int Id;
        public string Name;
        public override void DisplayEntityInfo()
        {
            Console.WriteLine($"Id - {this.Id}, name - {this.Name}");
        }
        public override bool Validate()
        {
            if (string.IsNullOrWhiteSpace(this.Name))
            {
                return false;
            }
            return true;
        }
    }


    public class Address : EntityBase
    {
        public Address()
        {
        }
        public Address(int addressId)
        {
            base.Id = addressId;
        }
        public int AddressType;
        public string StreetLine1;
        public string StreetLine2;
        public string City;
        public string State;
        public string PostalCode;
        public string Country;
        public override void DisplayEntityInfo()
        {
            Console.WriteLine($"Address Id - {base.Id}, country - {this.Country}, city - {this.City}");
        }
    }

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
        public List<Address> AddressList;
        public int CustomerType;
        public static int InstanceCount;
        public string LastName;
        public string EmailAddress;
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

   
}