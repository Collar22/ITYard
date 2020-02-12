using System;
using System.Collections.Generic;
using System.Text;

namespace ITYardService
{
    public class Order : Entity
    {
        public Guid _id;
        public Order()
        {
            this._id = Guid.NewGuid();
        }
        public string Customer { get; set; }
        public DateTime OrderData { get; set; }
        public string ShippingAddress { get; set; }

        public List<object> Items { get; set; }
        public object CustomerId { get; internal set; }

        public override bool Validate()
        {
            if (string.IsNullOrWhiteSpace(this.Customer))
            {
                return false;
            }
            return true;
        }

        public override void DisplayEntityInfo()
        {
            Console.WriteLine($"Customer - {this.Customer}, Order Data - {OrderData}, Shipping Address - {ShippingAddress}");
        }
    }
}
