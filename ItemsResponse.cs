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
        private Produtos[] produtos;

        public ItemsResponse(Usuario user, double rating, Produtos[] produtos)
        {
            this.user = user;
            this.rating = rating;
            this.produtos = produtos;
        }

        public Usuario getUser()
        {
            return user;
        }

        public double getRating()
        {
            return rating;
        }

        public Produtos GetProdutos(int posicao)
        {
            return produtos[posicao];
        }

        public String GetAsset(int index,int posicao)
        {
            return produtos[index].assets[posicao];
        }
        public Produtos[] getAllProdutos()
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
