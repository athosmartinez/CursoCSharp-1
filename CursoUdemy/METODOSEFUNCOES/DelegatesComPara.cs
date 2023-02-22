using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoUdemy.METODOSEFUNCOES
{
    internal class DelegatesComPara
    {

        public delegate int Operacao(int x, int y);
        public static int Soma(int x, int y)
        {
            return x + y;


        }

        public static string Calc(Operacao op, int x, int y)
        {
            var resultado = op(x, y);
            return "Resultado" + resultado;

        }

        public static void Executar()
        {
            Operacao Subtracao = (int x, int y) => x - y;
            Console.WriteLine(Calc(Subtracao, 3, 2));
            Console.WriteLine(Calc(Soma, 4, 2));
        }
    }
}
