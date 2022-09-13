using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoUdemy.FUNDAMENTOS
{
    internal class InterporlaçãoDeStrings
    {
        public static void Executar()
        {
            string nome = "Notebook gamer ";
            string marca = "DELL";

            double preco = 5800.00;

            Console.WriteLine("O " + nome + " da marca " + marca + " custa " + preco + ".");

            Console.WriteLine("o {0} da marca {1} custa {2}.", nome, marca, preco);

            Console.WriteLine($"A marca {marca} é legal!");

            Console.WriteLine($"1 + 1 = {1 + 1}");
        }
    }
}
