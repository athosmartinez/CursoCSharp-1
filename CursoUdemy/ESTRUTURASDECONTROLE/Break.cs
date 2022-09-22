using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoUdemy.ESTRUTURASDECONTROLE
{
    internal class Break
    {
        public static void Executar()
        {
            Random random = new Random();
            int numero = random.Next(1, 51);
            Console.WriteLine("O numero que quermos: " + numero);
            for (int i = 1; i <= 50; i++)
            {
                Console.WriteLine("{0} é o numero que queremos ", i);
                if (i == numero)
                {
                    Console.WriteLine("Sim!");
                    // O BREAK ESTA RELACIONADO AO FOR
                    break;

                }
                else
                {
                    Console.WriteLine("Não!");
                }
            }
            Console.WriteLine("FIM");
        }
    }
}
