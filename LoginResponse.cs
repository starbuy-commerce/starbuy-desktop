using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbuy_Desktop
{
    class LoginResponse
    {
        public Usuario user { get; set; }
        public string jwt { get; set; }
    }
}
