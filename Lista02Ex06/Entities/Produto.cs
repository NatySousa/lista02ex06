using System;
using System.Collections.Generic;
using System.Text;

namespace Lista02Ex06.Entities
{
    public class Produto
    {
        public int IdProduto { get; set; }
        public string Nome { get; set; }
        public double Preco { get; set; }
        public int Quantidade { get; set; }
        public Categoria Categoria { get; set; }


    }
}
