using ConsoleEFApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ConsoleEFApp
{
    public class Program
    {
        static void Main(String[] args)
        {
            Customer c1 = new Customer { Name = "shreya", Id = 123, Location = "thane" };
            Customer c2 = new Customer { Name = "prachi", Id = 154, Location = "kalyan" };
            AurionproDBContext db = new AurionproDBContext();
            db.customers.Add(c1);
            db.customers.Add(c2);
            db.SaveChanges();
        }
    }
}