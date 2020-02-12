using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ITYardService.Services
{
   public class CustumerService
    {
        private readonly IRepository<Customer> _custumerRepository;
        private readonly IRepository<Order> _orderRepository;
        public CustumerService(IRepository<Customer> custumerRepository, IRepository<Order> orderRepository)
        {
            _custumerRepository = custumerRepository;
            _orderRepository = orderRepository;
        }
        IEnumerable<Customer> GetALLCustomers()
        {
            var customers = _custumerRepository.All();
            var orders = _orderRepository.All();

            var composedCustomer = customers.Join(
                orders,
                cust => cust.Id,
                ord => ord.CustomerId,
                (customer, order) => new Customer
                {
                    Id = customer.Id,
                    Name = customer.Name,
                    LastName = customer.LastName,
                    //Orders = ordersGroup(),
                }
                );
            return _custumerRepository.All();
        }
    }
}
