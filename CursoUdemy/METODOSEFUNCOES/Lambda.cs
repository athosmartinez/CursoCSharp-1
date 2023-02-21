using CursoUdemy.FUNDAMENTOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoUdemy.METODOSEFUNCOES
{



    internal class Lambda
    {
        public static void Executar()
        {
            Action algoConsole = () =>
            {
                Console.WriteLine("Lambda com C#");
            };

            algoConsole();

            Func<int> jogarDado = () =>
            {
                Random rand = new Random();
                return rand.Next(1, 7);
            };

            Console.WriteLine(jogarDado());

            Func<int, string> conversorHexa = numero => numero.ToString("X");
        }
    }
}
