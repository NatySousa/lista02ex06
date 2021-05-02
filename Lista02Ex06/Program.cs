using Lista02Ex06.Entities;
using Lista02Ex06.Repositories;
using System;

namespace Lista02Ex06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\n*** CONTROLE DE PRODUTOS ***\n ");

            var produto = new Produto();
            produto.Categoria = new Categoria();

            Console.Write("\nInforme o Id do Produto: ");
            produto.IdProduto = int.Parse(Console.ReadLine());

            Console.Write("\nInforme o Nome do Produto: ");
            produto.Nome = Console.ReadLine();

            Console.Write("\nInforme o Preço de Produto: ");
            produto.Preco = double.Parse(Console.ReadLine());

            Console.Write("\nInforme a Quantidade do Produto: ");
            produto.Quantidade = int.Parse(Console.ReadLine());

            Console.Write("\nInforme o Id da Categoria do Produto: ");
            produto.Categoria.IdCategoria = int.Parse(Console.ReadLine());

            Console.Write("\nInforme a Descrição da Categoria do Produto: ");
            produto.Categoria.Descricao = Console.ReadLine();


            Console.Write("\n*** DADOS DO PRODUTO ***\n");
            Console.WriteLine("ID..................:" + produto.IdProduto);
            Console.WriteLine("Nome................:" + produto.Nome);
            Console.WriteLine("Quantidade..........:" + produto.Quantidade);


            Console.WriteLine("\n*** DADOS DA CATEGORIA ***\n");
            Console.WriteLine("ID..................:" + produto.Categoria.IdCategoria);
            Console.WriteLine("Descrição...........:" +produto.Categoria.Descricao);

            var produtoRepository = new ProdutoRepository();

            try
            {
                produtoRepository.ExportarDados(produto);

                Console.WriteLine("\nDados gravados com sucesso!");

            }
            catch (Exception e)
            {

                Console.WriteLine("\nErro: " + e.Message);

            }
            Console.ReadKey();






        }
    }
}
