using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoUdemy.FUNDAMENTOS
{
    internal class OperadoresLogicos
    {
        public static void Executar()
        {
            var executoutrabalho1 = true;
            var executoutrabalho2 = false;

            bool comproutv50 = executoutrabalho1 && executoutrabalho2;
            Console.WriteLine("Comprou a TV 50? {0}", comproutv50);

            var comprousorvete = executoutrabalho1 || executoutrabalho2;
            Console.WriteLine("Comprou a o sorvete? {0}", comprousorvete);

            var comproutv32 = executoutrabalho1 ^ executoutrabalho2;
            Console.WriteLine("Comprou a TV32? {0}", comproutv32);
            // Negação Logica - Operador Unario
            Console.WriteLine("Mais saudável? {0}", !comprousorvete);

        }
    }
}
