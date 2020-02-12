using System;
using System.Collections.Generic;
using System.Linq;
using WebITYard.Repositories;
using WebITYard.Services.Interfaces;
using WebITYard.Services.Models;

namespace WebITYard.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly IRepository<Repositories.Models.Customer> customerRepository;

        public CustomerService()
        {
            customerRepository = new Repository<Repositories.Models.Customer>();
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            var customers = this.customerRepository
                .All()
                .Including(c => c.Orders)
                .ToList();

            return customers.Select(x => new Customer
            {
                Id = x.Id,
                FirstName = x.FirstName,
                LastName = x.LastName,
                Age = x.Age,
                Orders = this.MapOrders(x.Orders)
            });
        }

        public Customer GetCustomer(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool RemoveCustomer(Guid id)
        {
            throw new NotImplementedException();
        }

        public Guid SaveCustomer(Customer customer)
        {
            var customerToSave = new Repositories.Models.Customer
            {
                Age = customer.Age,
                FirstName = customer.FirstName,
                LastName = customer.LastName,
            };

            var id = customerRepository.Insert(customerToSave);
            customerRepository.SaveChanges();

            return id;
        }

        public bool UpdateCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        private IEnumerable<Order> MapOrders(IEnumerable<Repositories.Models.Order> orders)
        {
            // return empty list if null
            if(orders == null || !orders.Any())
            {
                return new List<Order>
                {
                    new Order()
                };
            }

            return orders.Select(
                order => new Order
                {
                    Id = order.Id,
                    PoNumber = order.PoNumber,
                    OrderDate = order.OrderDate,
                    OrderItems = this.MapOrderItems(order.OrderItems)
                });
        }

        private IEnumerable<OrderItem> MapOrderItems(List<Repositories.Models.OrderItem> orderItems)
        {
            // return empty list if null
            if (orderItems == null || !orderItems.Any())
            {
                return new List<OrderItem>
                {
                    new OrderItem()
                };
            }

            return orderItems.Select(
                orderItem => new OrderItem
                {
                    Id = orderItem.Id,
                    Title = orderItem.Title,
                    Price = orderItem.Price
                });
        }
    }
}
