using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbuy_Desktop
{
    class Produtos
    {
        public Item item { get; set; }
        public String[] asset { get; set; }
        public String GetAsset(int posicao)
        {
            return asset[posicao];
        }
    }
}
