using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbuy_Desktop
{
    class Order
    {
        public String identifier { get; set; }
        public Usuario costumer { get; set; }
        public Usuario seller { get; set; }
        public ItemWithAssets item_with_assets { get; set; }
        public double price { get; set; }
        public int quantity { get; set; }
        public int status { get; set; }
        public LugarPedido send_to { get; set; }
        public DateTime date { get; set; }

    }
}
