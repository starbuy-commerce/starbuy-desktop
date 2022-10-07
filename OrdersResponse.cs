using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbuy_Desktop
{
    class OrdersResponse
    {
        private static OrdersResponse ordersResponse;
        private Order[] order;

        public OrdersResponse(Order[]ord)
        {
            this.order = ord;
        }

        public static void setOrdersResponse(OrdersResponse or)
        {
            ordersResponse = or;
        }

        /*
        public Produtos getProduto(int pedido,int posicao)
        {
            return order[pedido].getProduto(posicao);
        }

        public Produtos[] getAllProdutosFromOrder(int posicao)
        {
            return order[posicao].getAllProdutos();
        }
        */
        /*
        public Produtos getProduto(int posicao)
        {
            return sell.getProduto(posicao);
        }

        public Produtos[] getAllProdutos()
        {
            return sell.getAllProdutos();
        }*/
    }
}
