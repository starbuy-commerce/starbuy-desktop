using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbuy_Desktop
{
    class Item
    {   public String identifier { get; set; }
        public String title { get; set; }
        public class Seller { 
            public Boolean seller { get; set; }
        } 
        public double price { get; set; }
        public int stock { get; set; }
        public int category { get; set; }
        public string description { get; set; }

        public Item(string title, double price, int stock, int category, string description )
        {
            this.title = title;
            this.price = price;
            this.stock = stock;
            this.category = category;
            this.description = description;
        }
    }
}
