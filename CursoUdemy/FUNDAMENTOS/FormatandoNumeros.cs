using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CursoUdemy.FUNDAMENTOS
{
    internal class FormatandoNumeros
    {
        public static void Executar()
        {
            double valor = 15.175;
            Console.WriteLine(valor.ToString("F3"));
            // C = Currency, P = Percentual, F = Numero de casa decimal e arredonda
            Console.WriteLine(valor.ToString("C"));
            Console.WriteLine(valor.ToString("P"));
            Console.WriteLine(valor.ToString("#.##"));

            CultureInfo cultutra = new CultureInfo("pt-BR");
            Console.WriteLine(valor.ToString("C0", cultutra));
            int inteiro = 256;
            // D = numero de caracteres 10 posicoes
            Console.WriteLine(inteiro.ToString("D10"));

        }
    }
}
