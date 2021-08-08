using ConsoleEFFrameworkApp.Model;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleEFFrameworkApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Customer c1 = new Customer { Name = "shreya", Id = 123, Location = "thane" };
            //Customer c2 = new Customer { Name = "prachi", Id = 154, Location = "kalyan" };
            //Customer c3 = new Customer { Name = "jack", Id = 124, Location = "andheri" };
            AurionproDBContext db = new AurionproDBContext();
            //Customer c = new Customer { Name = "jhill", Id = 124, Location = "parel" , Balance = 100};
            //InsertCustomer(c, db);

            //Customer c = new Customer { Name = "rose", Id = 124, Location = "parel", Balance = 100 , Type3 = "gold"};
            //InsertCustomer(c, db);
            var customer = db.Customers.Find("shreya");
            System.Console.WriteLine(customer);
            System.Console.ReadLine();




            //db.SaveChanges();
        }

        private static void InsertCustomer(Customer c, AurionproDBContext db)
        {
            db.Customers.Add(c);
            db.SaveChanges();
        }


        private static void DeleteCustomer(Customer c, AurionproDBContext db)
        {
            var customer = db.Customers.Where(x => x.Name == c.Name).First();
            db.Customers.Remove(customer);
            db.SaveChanges();
        }

        private static void UpdateCustomer(Customer c, AurionproDBContext db)
        {
            var customer = db.Customers.Where(x => x.Name == c.Name).First();
            customer.Location = "hello";
            db.SaveChanges();
        }
    }
}
