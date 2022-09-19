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
        public Usuario Seller { get; set; } 
        public Double price { get; set; }
        public int stock { get; set; }
        public int category { get; set; }
        public string description { get; set; }

        public Item(String title, Usuario seller, Double price, int stock, int category, String description)
        {
            this.title = title;
            this.price = price;
            this.stock = stock;
            this.category = category;
            this.description = description;
            this.Seller.username = seller.username;
            this.Seller.seller = seller.seller;
        }
    }

}
