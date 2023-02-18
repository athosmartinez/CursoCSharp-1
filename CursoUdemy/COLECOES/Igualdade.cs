using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoUdemy.COLECOES
{
    internal class Igualdade
    {
        public static void Executar()
        {
            var p1 = new Product("Caneta", 1.90);
            var p2 = new Product("Caneta", 1.90);
            var p3 = p2;
            // Compara endereço de memoria
            Console.WriteLine(p1 == p2);
            Console.WriteLine(p3 == p2);

            // Diferente
            Console.WriteLine(p1.Equals(p2));

        }
    }
}
