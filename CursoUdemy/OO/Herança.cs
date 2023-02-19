using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoUdemy.OO
{
    public class Carro
    {
        protected readonly int VelocidadeMaxima;
        int VelocidadeAtual;

        public Carro(int velocidadeMaxima)
        {
            VelocidadeMaxima = velocidadeMaxima;
        }

        protected int AlterarVelocidade(int delta)
        {
            int novaVelocidade = VelocidadeAtual + delta;

            if (novaVelocidade < 0)
            {
                VelocidadeAtual = 0;

            }
            else if (novaVelocidade > VelocidadeMaxima)
            {
                VelocidadeAtual = VelocidadeMaxima;
            }
            else
            {
                VelocidadeAtual = novaVelocidade;
            }
            return VelocidadeAtual;


        }

        public int Acelelar()
        {
            return AlterarVelocidade(5);

        }
        public int Freiar()
        {
            return AlterarVelocidade(-5);
        }
    }

    public class Uno : Carro
    {
        public Uno() : base(200)
        {

        }
    }

    public class Ferrari : Carro
    {
        public Ferrari() : base(370)
        {
        }
    }


    internal class Herança
    {
        public static void Executar()
        {
            Console.WriteLine("Uno...");
            Uno carro1 = new Uno();
            Console.WriteLine(carro1.Acelelar());
            Console.WriteLine(carro1.Acelelar());
            Console.WriteLine(carro1.Freiar());
            Console.WriteLine(carro1.Freiar());
            Console.WriteLine(carro1.Acelelar());

            Console.WriteLine("Ferrari...");
            Ferrari carro2 = new Ferrari();
            Console.WriteLine(carro2.Acelelar());
            Console.WriteLine(carro2.Acelelar());
            Console.WriteLine(carro2.Freiar());
            Console.WriteLine(carro2.Freiar());
            Console.WriteLine(carro2.Acelelar());
        }
    }
}
