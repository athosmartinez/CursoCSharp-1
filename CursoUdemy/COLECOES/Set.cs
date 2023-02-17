using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoUdemy.COLECOES
{
    internal class Set
    {

        public static void Executar()
        {
            var livro = new Product("Nome do livro", 49.9);
            var carrinho = new HashSet<Product>();
            carrinho.Add(livro);
            var combo = new HashSet<Product>()
            {
                new Product("Livro 1", 30.0),
                new Product("Livro 2", 50.0),
                new Product("Livro 3", 70.0)
            };
            carrinho.UnionWith(combo);
            
            // carrinho.RemoveAt(0);

            foreach (var item in carrinho)
            {
                //    Console.Write(carrinho.IndexOf(item));
                Console.WriteLine($" {item.Nome} {item.Preco}");
            }

            // Não aceita duplicação!
            Console.WriteLine(carrinho.Count);
            carrinho.Add(livro);
            Console.WriteLine(carrinho.Count);
            //  Console.WriteLine(carrinho.LastIndexOf(livro));
        }
    }
}

