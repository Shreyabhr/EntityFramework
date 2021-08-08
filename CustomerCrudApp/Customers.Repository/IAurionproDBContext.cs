using Customers.Model;
using System;
using System.Data.Entity;

namespace Customers.Repository
{
    public interface IAurionproDBContext 
    {
        DbSet<Customer> Customers { get; set; }
    }
}