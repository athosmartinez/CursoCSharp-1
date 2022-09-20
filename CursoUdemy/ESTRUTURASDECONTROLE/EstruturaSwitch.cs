using CursoUdemy.FUNDAMENTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoUdemy.ESTRUTURASDECONTROLE
{
    internal class EstruturaSwitch
    {
        public static void Executar()
        {
            Console.WriteLine("Avalie meu atendimento com uma nota de 1 a 5:");
            int.TryParse(Console.ReadLine(), out int nota);

            switch (nota)
            {
                case 0:
                    Console.WriteLine("Pessimo");
                    break;
                case 1:
                case 2:
                    Console.WriteLine("Ruim");
                    break;
                case 4:
                    Console.WriteLine("Boa");
                    break;
                case 5:
                    Console.WriteLine("OTIMO!");
                    Console.WriteLine("PARABENS!");
                    break;
                default:
                    Console.WriteLine("INVALIDA");
                    break;
            }
            Console.WriteLine("Obrigado!");
        }
    }
}
