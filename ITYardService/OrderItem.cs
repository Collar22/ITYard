using System;
using System.Collections.Generic;
using System.Text;

namespace ITYardService
{
    public class OrderItem : Entity
    {
        string Name { get; set; }
        public Guid _id;
        public OrderItem()
        {
            this._id = Guid.NewGuid();
        }
        public int Quantity { get; set; }
        public decimal PurchasePrice { get; set; }
        public Guid OrderId { get; set; }
        public void Product(string name)
        {
            this.Name = name;
        }
        public override bool Validate()
        {
            if (string.IsNullOrWhiteSpace(this.Name))
            {
                return false;
            }
            return true;
        }

        public override void DisplayEntityInfo()
        {
            Console.WriteLine($"Product Name - {this.Name}, Quantity - {Quantity}");
        }
    }
}
