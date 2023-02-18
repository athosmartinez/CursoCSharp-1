using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoUdemy.COLECOES
{

    public class Product
    {
        public string Nome;
        public double Preco;

        public Product(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public override bool Equals(object? obj)
        {
            Product outroProduto = (Product)obj;
            bool mesmoNome = Nome == outroProduto.Nome;
            bool mesmoPreco = Preco == outroProduto.Preco;

            return mesmoNome && mesmoPreco;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Nome, Preco);
        }
    }

    class Lista
    {
        public static void Executar()
        {
            var livro = new Product("Nome do livro", 49.9);
            var carrinho = new List<Product>();
            carrinho.Add(livro);
            var combo = new List<Product>()
            {
                new Product("Camisa 1", 30.0),
                new Product("Camisa 2", 50.0),
                new Product("Camisa 3", 70.0)
            };
            carrinho.AddRange(combo);
            Console.WriteLine(carrinho.Count);
            carrinho.RemoveAt(0);

            foreach (var item in carrinho)
            {
                Console.Write(carrinho.IndexOf(item));
                Console.WriteLine($" {item.Nome} {item.Preco}");
            }

            Console.WriteLine(carrinho.Count);
            carrinho.Add(livro);
            Console.WriteLine(carrinho.LastIndexOf(livro));

        }
    }
}
