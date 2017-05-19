using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace coreangular_test.Controllers
{
    [Produces("application/json")]
    [Route("api/Customer")]
    public class CustomerController : Controller
    {
        private CustomerStore customerStore;

        public CustomerController()
        {
            customerStore = CustomerStore.GetInstance();
        }

        [HttpGet("Get")]
        public Customer Get(int id)
        {
            return customerStore.GetCustomers().Single(x => x.Id == id);
        }

        [HttpGet("GetAll")]
        public IEnumerable<Customer> GetAll()
        {
            return customerStore.GetCustomers();
        }

        [HttpPost("Create")]
        public int Post([FromForm]Customer customer)
        {
            Console.WriteLine(customer.Name);

            return customerStore.CreateCustomer(customer);
        }
    }

    public class CustomerStore
    {
        private static CustomerStore instance;

        public static CustomerStore GetInstance()
        {
            if(instance == null)
            {
                instance = new CustomerStore();
            }

            return instance;
        }

        private readonly List<Customer> customers;

        public CustomerStore()
        {
            customers = new List<Customer>();
        }

        public IEnumerable<Customer> GetCustomers()
        {
            return customers;
        }

        public int CreateCustomer(Customer customer)
        {
            int biggestId;

            if (!customers.Any())
            {
                biggestId = 1;
            }
            else
            {
                biggestId = customers.Max(x => x.Id);
                biggestId++;
            }

            customer.Id = biggestId;
            customers.Add(customer);

            return biggestId;
        }
    }

    public class Customer
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}