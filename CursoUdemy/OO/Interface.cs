using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoUdemy.OO
{
    interface Teste
    {
        bool bla(string a);
    }

    interface OperacaoBinaria
    {
        int Operacao(int a, int b);

    }

    class Soma : OperacaoBinaria, Teste
    {
        public int Operacao(int a, int b)
        {
            return a + b;
        }

        public bool bla(string a)
        {
            return true;
        }
    }

    class Subtracao : OperacaoBinaria
    {
        public int Operacao(int a, int b)
        {
            return a - b;
        }
    }
    class Multiplicacao : OperacaoBinaria
    {
        public int Operacao(int a, int b)
        {
            return a * b;
        }
    }

    class Calc
    {
        List<OperacaoBinaria> operacoes = new List<OperacaoBinaria>
        {
            new Soma(),
            new Subtracao(),
            new Multiplicacao(),
        };
        public string ExecutarOperacoes(int a, int b)
        {
            string resultado = "";

            foreach (var op in operacoes)
            {
                resultado += $"Usando {op.GetType().Name} = {op.Operacao(a, b)}\n";
            }
            return resultado;
        }
    }

    internal class Interface
    {
        public static void Executar()
        {
            var calc = new Calc();
            var resultado = calc.ExecutarOperacoes(52, 25);
            Console.WriteLine(resultado);
        }
    }
}
