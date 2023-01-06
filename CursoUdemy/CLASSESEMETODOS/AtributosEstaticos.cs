using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoUdemy.CLASSESEMETODOS
{

    public class Produto
    {

        //instancia nome e preco, DESCONTO deixou de ser atributo de instancia
        public string Nome;
        public double Preco;

        //variael estatica
        public static double Desconto = 0.1;


        public Produto(string nome, double preco, double desconto)
        {
            Nome = nome;
            Preco = preco;
            Desconto = desconto;
        }

        public Produto()
        {

        }


        //metodo de instancia

        //Desconto pertence a classe 
        public double CalcDesconto()
        {
            return Preco - Preco * Desconto;

        }


    }

    internal class AtributosEstaticos
    {
        public static void Executar()
        {
            var Produto1 = new Produto("Caneta", 3.2, 0.1);
            var Produto2 = new Produto()
            {
                Nome = "Borracha",
                Preco = 2.5,
            };

            Produto.Desconto = 0.5;


            Console.WriteLine("Preço com desconto: {0}", Produto1.CalcDesconto());
            Console.WriteLine("Preço com desconto: {0}", Produto2.CalcDesconto());

            Produto.Desconto = 0.2;

            Console.WriteLine("Preço com desconto: {0}", Produto1.CalcDesconto());
            Console.WriteLine("Preço com desconto: {0}", Produto2.CalcDesconto());

        }
    }
}
