using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoUdemy.ESTRUTURASDECONTROLE
{
    internal class EstruturaIf
    {
        public static void Executar()
        {
            bool bomComportamento = false;
            string entrada;
            Console.WriteLine("Digite a nota do aluno: ");
            entrada = Console.ReadLine();
            double.TryParse(entrada, out double nota);

            Console.WriteLine("Possui bom comportamento (S/N):");
            entrada = Console.ReadLine();

            //if (entrada == "S" || entrada == "s")
            //    bomComportamento = true;

            // bomComportamento = entrada = "S" || entrada == "s";

            bomComportamento = entrada.ToLower() == "s";

            if (nota >= 9.0 && bomComportamento)
            {
                Console.WriteLine("Quadro de honra");
            }
            else { Console.WriteLine("Pelo o menos passou!"); }

            Console.WriteLine("Digite sua nota:");
            string entrada1;
            entrada1 = Console.ReadLine();
            double.TryParse(entrada1, out double nota1);

            if (nota1 >= 9.0)
            {
                Console.WriteLine("Quadro de honra");
            }
            else if (nota1 >= 7.00)
            {
                Console.WriteLine("Aprovado!");
            }
            else if (nota >= 5.0)
            {
                Console.WriteLine("Recuperação");
            }
            else Console.WriteLine("BOMBA!");

        }
    }
}
