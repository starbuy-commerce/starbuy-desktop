using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbuy_Desktop
{
    class ItemsResponse
    {
        private static ItemsResponse itemsResponse;

        private Usuario user;
        private double rating;
        private Produto[] produtos;

        public ItemsResponse(Usuario user, double rating, Produto[] produtos)
        {
            this.user = user;
            this.rating = rating;
            for(int i = 0; i < produtos.Length; i++) {
                produtos[i] = produtos[i];
            }

        }

        public Usuario getUser()
        {
            return user;
        }

        public double getRating()
        {
            return rating;
        }

        public Produto GetProdutos(int posicao)
        {
            return produtos[posicao];
        }

        public Produto[] getAllProdutos()
        {
            return produtos;
        }

        public static void setItemsResponse(ItemsResponse itensResp)
        {
            itemsResponse = itensResp;
        }

        public static ItemsResponse GetItemsResponse()
        {
            return itemsResponse;
        }
    }
}
