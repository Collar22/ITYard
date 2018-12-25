using System;
using System.Collections.Generic;
using System.Text;

namespace ITYardService
{
    public class Entity
    {
        int Id;
        string Name;
        public virtual void DisplayEntityInfo()
        {
            Console.WriteLine($"Id - {this.Id}, name - {this.Name}");
        }
        public virtual bool Validate()
        {
            if (string.IsNullOrWhiteSpace(this.Name))
            {
                return false;
            }
            return true;
        }
    }
}
