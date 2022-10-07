using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbuy_Desktop
{
    class Venda
    {
        private Produtos[] item { get; set; }
        private double price { get; set; }

        private int quantity { get; set; }

        public Produtos getProduto(int posicao)
        {
            return item[posicao];
        }

        public Produtos[] getAllProdutos()
        {
            return item;
        }
    }
}
