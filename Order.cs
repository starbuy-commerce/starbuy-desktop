using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbuy_Desktop
{
    class Order
    {
        private String identifier { get; set; }
        private Usuario costumer { get; set; }
        private Usuario seller { get; set; }
        private ItemWithAssets item_with_assets { get; set; }
        private double price { get; set; }
        private int quantity { get; set; }
        private int status { get; set; }
        private LugarPedido send_to { get; set; }
        private DateTime date { get; set; }

    }
}
