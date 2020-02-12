using System;
using System.Collections.Generic;

namespace WebITYard.Repositories.Models
{
    public class Order : IEntity<Guid>
    {
        public Guid Id { get; set; }
        public int PoNumber { get; set; }
        public DateTime OrderDate { get; set; }

        // navigation property
        public Guid CustomerId { get; set; }
        public Customer Customer { get; set; }

        public List<OrderItem> OrderItems { get; set; }
    }
}
