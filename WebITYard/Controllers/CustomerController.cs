using System;
using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using WebITYard.Services;
using WebITYard.Services.Interfaces;

namespace WebITYard.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService customerService;
        private readonly IMapper mapper;

        public CustomerController(IMapper mapper)
        {
            this.customerService = new CustomerService();

            this.mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        // GET api/customer
        [HttpGet]
        public ActionResult<IEnumerable<ViewModels.Customer>> GetAll()
        {
            var customers = this.customerService.GetAllCustomers();

            var mapped = this.mapper.Map<IEnumerable<ViewModels.Customer>>(customers);

            return mapped.ToList();
        }

        [HttpGet("{id:Guid}")]
        public ActionResult<ViewModels.Customer> GetById(Guid id)
        {
            if(id == Guid.Empty)
            {
                return this.BadRequest();
            }

            var customer = this.customerService.GetCustomer(id);

            return this.mapper.Map<ViewModels.Customer>(customer);
        }

        // POST api/customer
        [HttpPost]
        public ActionResult Post([FromBody] ViewModels.Customer customer)
        {
            if(!this.ModelState.IsValid)
            {
                return this.BadRequest();
            }

            var customerServiceModel = this.mapper.Map<Services.Models.Customer>(customer);

            var id = this.customerService.SaveCustomer(customerServiceModel);

            return this.Created("", id);
        }

        // PUT api/customer/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/customer/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}