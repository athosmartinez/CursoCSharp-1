using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoUdemy.CLASSESEMETODOS
{
    internal class ParametrosVariaveis
    {
        public static void Recepcionar(params string[] pessoas)
        {
            foreach (var pe in pessoas)
            {
                Console.WriteLine("Olá {0}", pe);
            }
        }

        public static void Executar()
        {
            Recepcionar("pedro", "manu", "marina", "ana", "bia");
        }
    }
}
