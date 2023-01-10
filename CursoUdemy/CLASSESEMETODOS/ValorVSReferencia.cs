using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace CursoUdemy.CLASSESEMETODOS
{
    internal class ValorVSReferencia
    {
        public class Dependete
        {
            public int Idade;
            public string Nome;
        }

        public static void Executar()
        {
            int numero = 3;
            int CopiaNumero = numero;
            Console.WriteLine($"{numero}  {CopiaNumero}");
            numero++;
            Console.WriteLine($"{numero}  {CopiaNumero}");

            Dependete dep = new Dependete
            {
                Idade = 20,
                Nome = "Beto"
            };

            Dependete CopiaDep = dep;

            Console.WriteLine($"{dep.Nome} {CopiaDep.Nome}");
            Console.WriteLine($"{dep.Idade} {CopiaDep.Idade}");
            CopiaDep.Nome = "Renato";
            dep.Idade = 21;
            Console.WriteLine($"{dep.Nome} {CopiaDep.Nome}");
            Console.WriteLine($"{dep.Idade} {CopiaDep.Idade}");
        }
    }
}
