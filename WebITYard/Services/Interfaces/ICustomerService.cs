using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebITYard.Services.Models;

namespace WebITYard.Services.Interfaces
{
    public interface ICustomerService
    {
        IEnumerable<Customer> GetAllCustomers();

        Customer GetCustomer(Guid id);

        Guid SaveCustomer(Customer customer);

        bool UpdateCustomer(Customer customer);

        bool RemoveCustomer(Guid id);
    }
}
