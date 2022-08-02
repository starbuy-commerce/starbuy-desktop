using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbuy_Desktop
{
    class MultiplosEnderecosResponse
    {
        private static MultiplosEnderecosResponse multipleAddress;
         private Address[] address { get; set; }

        public MultiplosEnderecosResponse(Address[] address)
        {
            this.address = address;
        }

        public Address getAddress(int posicao)
        {
            return address[posicao];
        }
        public Address[] getAddresses()
        {
            return address;
        }
        public static void setMultiplosEnderecosResponse(MultiplosEnderecosResponse enderecos)
        {
            multipleAddress = enderecos;
        }

        public static MultiplosEnderecosResponse getEnderecosResponse()
        {
            return multipleAddress;
        }
    }
}
