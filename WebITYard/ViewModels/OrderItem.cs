using System;

namespace WebITYard.ViewModels
{
    public class OrderItem
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public decimal Price { get; set; }
    }
}
