using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbuy_Desktop
{
    class Endereco
    {
        public String name { get; set; }
        public String cep { get; set; }
        public int number { get; set; }
        public String complement { get; set; }

        public Endereco(string name, string cep, int number, string complement)
        {
            this.name = name;
            this.cep = cep;
            this.number = number;
            this.complement = complement;
        }

    }
}
