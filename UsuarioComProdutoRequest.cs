using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;   

namespace Starbuy_Desktop
{
    class UsuarioComProdutoRequest{
        public Produto[] items { get; set; }
        public Usuario user { get; set; }
        public double rating { get; set; }
    }
}
