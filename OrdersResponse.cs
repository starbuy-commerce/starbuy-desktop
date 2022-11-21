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
        private static List<Order> order;

        public OrdersResponse(List<Order> ord)
        {
            order = ord;
        }

        public static void setOrdersResponse(OrdersResponse or)
        {
            ordersResponse = or;
        }

        public Order getOrder(int posicao)
        {
            return order[posicao];
        }

        public Order[] getOrders()
        {
            return order.ToArray();
        }

        public static OrdersResponse GetOrdersResponse()
        {
            return ordersResponse;
        }
    }
}
