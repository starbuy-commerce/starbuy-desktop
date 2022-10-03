using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbuy_Desktop
{
    class RequestCadastro
    {
        public RequestCadastro(String username, String name, String email, String city, String birthdate, String password)
        {
            this.username = username;
            this.name = name;
            this.email = email;
            this.city = city;
            this.birthdate = birthdate;
            this.password = password;
        }
        public String username { get; set; }
        public String name{ get; set; }
        public String email { get; set; }
        public String city { get; set; }
        public String birthdate { get; set; }
        public class Seller
        {
            public Boolean seller = true;
        }
        public String profilePicture { get; set; }
        public String password{ get; set; }
    }
}
