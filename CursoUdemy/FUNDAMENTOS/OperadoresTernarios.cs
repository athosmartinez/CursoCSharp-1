using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoUdemy.FUNDAMENTOS
{
    internal class OperadoresTernarios
    {
        public static void Executar()
        {
            var nota = 7.0;
            bool bomcomportamento = true;
            var resultado = nota >= 7.0 && bomcomportamento ? "Aprovado" : "Reprovado";
            Console.WriteLine(resultado);
        }
    }
}
