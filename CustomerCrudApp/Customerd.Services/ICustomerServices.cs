using Customers.Model;
using System.Collections.Generic;

namespace Customers.Services
{
    public interface ICustomerServices
    {
        void AddCustomer(Customer c);
        void DeleteCustomer(int id);
        List<Customer> GetCustomers();
        void UpdateCustomer(Customer c);

        Customer GetCustomer(int id);
    }
}