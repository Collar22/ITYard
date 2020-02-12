using System;
using System.Collections.Generic;

namespace WebITYard.Repositories.Models
{
    public class Customer : IEntity<Guid>
    {
        public Guid Id { get; set; }
        public int Age { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // navigation property
        public List<Order> Orders { get; set; }
    }
}
