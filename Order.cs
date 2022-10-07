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
        
        private Venda[] sell { get; set; }

    }
}
