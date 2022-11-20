using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbuy_Desktop
{
    class Categorias
    {
        private static Categorias categoria;
        String[] categorias = { "", "Tecnologia e Informática", "Moda e Acessórios", "Casa e Decoração", "Livros e Revistas", "Papelaria", "Brinquedos e Jogos", "Música e Instrumentos" };
        public string getCategoria(int posicao)
        {
            return categorias[posicao];
        }

        public string[] getTodasCategorias()
        {
            return categorias;
        }
    }
}
