using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbuy_Desktop
{
    class RequestCadastro
    {
        public String username { get; set; }
        public String name{ get; set; }
        public String email { get; set; }
        public String birthdate { get; set; }
        public class Seller
        {
            public Boolean seller { get; set; }
        }
        public String password{ get; set; }
    }
}
