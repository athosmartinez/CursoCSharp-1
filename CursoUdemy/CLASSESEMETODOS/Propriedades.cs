using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoUdemy.CLASSESEMETODOS
{
    public class CarroOpcional
    {
        double desconto = 0.1;
        string nome;
        public string Nome
        {
            get
            {
                return "Opcional: " + nome;
            }
            set
            {
                nome = value;
            }
        }

        //Propriedades autoimplementada
        public double Preco { get; set; }
        //Somente leitura
        public double PrecoComDesconto
        {
            get => Preco - (desconto * Preco); //Lambda
        }

        public CarroOpcional()
        {

        }

        public CarroOpcional(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;

        }
    }

    internal class Propriedades
    {
        public static void Executar()
        {
            var opcao1 = new CarroOpcional("Ar Condicionado", 3499.9);
            Console.WriteLine(opcao1.PrecoComDesconto);
            var opcao2 = new CarroOpcional("Direção eletrica", 2349.9);
            Console.WriteLine("");
            Console.WriteLine(opcao2.Nome);
            Console.WriteLine(opcao2.Preco);
            Console.WriteLine(opcao2.PrecoComDesconto);
        }
    }
}
