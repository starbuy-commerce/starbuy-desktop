using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbuy_Desktop
{
    class Item
    {   
        public String identifier { get; set; }
        public String title { get; set; }
        public class Seller { 
            public Boolean seller { get; set; }
        }
        public Double price { get; set; }
        public int stock { get; set; }
        public int category { get; set; }
        public string description { get; set; }
    }

}
