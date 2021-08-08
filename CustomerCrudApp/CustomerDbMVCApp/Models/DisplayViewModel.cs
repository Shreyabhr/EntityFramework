using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CustomerDbMVCApp.Models
{
    public class DisplayViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Location { get; set; }

        public double Balance { get; set; }

        public string Type { get; set; }
    }
}