using System;
using System.Collections.Generic;
using System.Text;

namespace ITYardService
{
    public class Address : EntityBase
    {
        public Address()
        {
        }
        public Address(int addressId)
        {
            base.Id = addressId;
        }
        public int AddressType { get; set; }
        public string StreetLine1 { get; set; }
        public string StreetLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public override void DisplayEntityInfo()
        {
            Console.WriteLine($"Address Id - {base.Id}, country - {this.Country}, city - {this.City}");
        }
    }
}
