using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;

namespace ClassMethodDemo
{
    public class CustomerManager
    {
        private readonly List<Customer> _customers;

        public CustomerManager()
        {
            _customers = new List<Customer>()
            {
                new Customer(){Id = 1,FirstName = "Ramiz",LastName = "Valiyev"},
                new Customer(){Id = 2,FirstName = "Asim",LastName = "Elizade"},
                new Customer(){Id = 3,FirstName = "Vuqar",LastName = "Kazimov"}
            };
        }

        public List<Customer> GetAll()
        {
            return _customers;
        }

        public List<Customer> GetByName(string key)
        {
            return _customers.Where(c => c.FirstName.ToLower().Contains(key.ToLower())).ToList();
        }

        public void Add(Customer customer)
        {
            _customers.Add(customer);
            Console.WriteLine("Added");
        }

        public void Update(Customer customer)
        {
            var updatedCustomer = _customers.FirstOrDefault(c=>c.Id==customer.Id);
            _customers[_customers.IndexOf(updatedCustomer)] = customer;
            Console.WriteLine("Updated");
        }

        public void Delete(Customer customer)
        {
            var deletedCustomer = _customers.FirstOrDefault(c => c.Id == customer.Id);
            _customers.Remove(deletedCustomer);
            Console.WriteLine("Deleted");
        }

        public void Clear()
        {
            _customers.Clear();
            Console.WriteLine("Deleted all customers");
        }
    }
}
