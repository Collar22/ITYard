using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebITYard.Services.Models
{
    public class Customer
    {
        public Guid Id { get; set; }

        public int Age { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public IEnumerable<Order> Orders { get; set; }
    }
}
