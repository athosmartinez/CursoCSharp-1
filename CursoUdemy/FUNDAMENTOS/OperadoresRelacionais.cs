using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace CursoUdemy.FUNDAMENTOS
{
    internal class OperadoresRelacionais
    {
        public static void Executar()
        {
            // double nota = 6.0;
            Console.Write("Digite sua nota: ");
            double.TryParse(Console.ReadLine(), out double nota);

            double notacorte = 7.0;
            Console.WriteLine("Nota inválida? {0}", nota > 10.0);
            Console.WriteLine("Nota inválida? {0}", nota < 0.0);
            Console.WriteLine("Perfeito? {0}", nota == 10.0);
            Console.WriteLine("Tem como melhorar? {0}", nota != 10.0);
            Console.WriteLine("Passou por média? {0}", nota >= notacorte);
            Console.WriteLine("Recuperação? {0}", nota < notacorte);
            Console.WriteLine("Reprovado? {0}", nota <= 3.0);
        }
    }
}
