using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbuy_Desktop {
    [Serializable()]
    public class AuthException : Exception {

        public AuthException(String message) : base(message) {}

    }
}
