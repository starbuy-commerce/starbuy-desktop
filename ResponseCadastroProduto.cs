using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbuy_Desktop
{
    class ResponseCadastroProduto
    {
        private static ResponseCadastroProduto ResponseCad;
        public Item item { get; set; }
        public String[] assets { get; set; }
        public static void setResponseCadastroProduto(ResponseCadastroProduto rp)
        {
            ResponseCad = rp;
        }
    }
}
