using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebITYard.ViewModels
{
    public class Customer
    {
        public Guid Id { get; set; }

        [Range(16, 100)]
        public int Age { get; set; }

        [MinLength(2)]
        public string Name { get; set; }

        [MinLength(2)] 
        public string LastName { get; set; }

        public IEnumerable<Order> Orders { get; set; }
    }
}
