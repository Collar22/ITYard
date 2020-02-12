using System;

namespace WebITYard.Repositories.Models
{
    public class OrderItem : IEntity<Guid>
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }

        // navigation property
        public Guid OrderId { get; set; }
        public Order Order { get; set; }
    }
}
