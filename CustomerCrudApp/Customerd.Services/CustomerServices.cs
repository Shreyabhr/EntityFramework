using System.Collections.Generic;
using System.Linq;
using Customers.Repository;
using Customers.Model;

namespace Customers.Services
{
    public class CustomerServices : ICustomerServices
    {
        private AurionproDBContext _db;

        public CustomerServices()
        {
            _db = new AurionproDBContext();
        }

        public void AddCustomer(Customer c)
        {
            _db.Customers.Add(c);
            _db.SaveChanges();
        }

        public void DeleteCustomer(int id)
        {
            var customer = _db.Customers.Where(x => x.Id == id).First();
            _db.Customers.Remove(customer);
            _db.SaveChanges();
        }

        public void UpdateCustomer(Customer c)
        {
            var customer = _db.Customers.Where(x => x.Id == c.Id).First();
            customer.Location = c.Location;
            customer.Name = c.Name;
            customer.Balance = c.Balance;
            customer.Type3 = c.Type3;
            _db.SaveChanges();
        }

        public List<Customer> GetCustomers()
        {
            var customers = _db.Customers.ToList();
            return customers;
        }

        public Customer GetCustomer(int id)
        {
            var customer = _db.Customers.Where(x => x.Id == id).First();
            return customer;
        }
    }
}
