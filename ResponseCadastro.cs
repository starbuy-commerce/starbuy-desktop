using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbuy_Desktop
{
    class ResponseCadastro
    {
        private static ResponseCadastro ResponseCad;
        public static void setResponseCadastro (ResponseCadastro rp)
        {
            ResponseCad = rp;
        }

        public String jwt { get; set; }
        public String message { get; set; }
        public Boolean status { get; set; }
        public Usuario user { get; set; }

        public static ResponseCadastro getResponseCadastro()
        {
            return ResponseCad;
        }
    }
}
