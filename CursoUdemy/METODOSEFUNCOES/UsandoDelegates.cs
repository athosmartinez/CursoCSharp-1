using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoUdemy.METODOSEFUNCOES
{
    internal class UsandoDelegates
    {
        delegate double Soma(double a, double b);
        delegate void ImprimarSoma(double a, double b);

        static double MinhaSoma(double x, double y)
        {
            return x + y;
        }
        static void MeuImprimir(double a, double b)
        {
            Console.WriteLine(a + b);
        }
        public static void Executar()
        {
            Soma op1 = MinhaSoma;
            Console.WriteLine(op1(2, 3));

            ImprimarSoma op2 = MeuImprimir;
            op2(5.3, 9);

            Func<double, double, double> op3 = MinhaSoma;
            Console.WriteLine(op3(2.5, 3));
            Action<double, double> op4 = MeuImprimir;
            op4(7.1, 7.8);


        }
    }
}
