using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoUdemy.ESTRUTURASDECONTROLE
{
    internal class EstruturaDoWhile
    {
        public static void Executar()
        {
            int palpite = 0;
            Random aleatorio = new Random();
            // 1 a 15
            int numeroSecreto = aleatorio.Next(1, 16);
            bool numeroEncontrado = false;
            int tentativasRestantes = 5;
            int tentativas = 0;
            // PELO MENOS 1 VEZ O DO WHILE É EXECUTADO, DIFERENTE DE APENAS WHILE
            do
            {
                Console.WriteLine("Insira seu palpite: ");
                string entrada = Console.ReadLine();
                int.TryParse(entrada, out palpite);

                tentativas++;
                tentativasRestantes--;
                if (numeroSecreto == palpite)
                {
                    numeroEncontrado = true;
                    var corAnterior = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine("Numero encontrado em {0} tentativas", tentativas);
                    Console.BackgroundColor = corAnterior;

                }
                else if (palpite > numeroSecreto)
                {
                    Console.WriteLine("Menor... Tente novamente");
                    Console.WriteLine("Tentativas restantes: ", tentativasRestantes);
                }
                else
                {
                    Console.WriteLine("Maior... Tente novamente");
                    Console.WriteLine("Tentativas restantes: ", tentativasRestantes);
                }
            } while (tentativasRestantes > 0 && !numeroEncontrado);
        }
    }
}
