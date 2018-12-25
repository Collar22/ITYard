using System;
using System.Collections.Generic;
using System.Text;

namespace ITYardService
{
    public class Product : Entity
    {
        //  public int Id;
        string Name { get; set; }
        public string Description { get; set; }
        decimal Price { get; set; }

        public void ProductName(string name)
        {
            this.Name = name;
        }

        public void CurrentPrice(decimal value)
        {
            this.Price = value;
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
            Console.WriteLine($"Product Name - {this.Name}, Description - {Description}, Current price - {this.Price}");
        }
    }
}

