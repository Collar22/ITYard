using System;
using System.Collections.Generic;

namespace WebITYard.Services.Models
{
    public class Order
    {
        public Guid Id { get; set; }
        public int PoNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public IEnumerable<OrderItem> OrderItems { get; set; }
    }
}
