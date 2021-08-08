using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleEFFrameworkApp.Model
{
    class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }

        public double Balance { get; set; }

        public char Type { get; set; }
      
        public char Type2 { get; set; }

        public string Type3 { get; set; }
    }
}
