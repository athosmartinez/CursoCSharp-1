using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoUdemy.CLASSESEMETODOS
{

    public struct SPonto
    {
        public int X;
        public int Y;
    }


    public class CPonto
    {
        public int X, Y;
    }

    internal class StructVsClass
    {
        public static void Executar()

        {
            SPonto Ponto1 = new SPonto { X = 1, Y = 3 };
            SPonto CopiaPonto1 = Ponto1; //Atribuição por VALOR!
            Ponto1.X = 3;
            Console.WriteLine("Ponto 1 X: {0}", Ponto1.X);
            Console.WriteLine("Copia Ponto 1 X: {0}", CopiaPonto1.X);

            CPonto Ponto2 = new CPonto { X = 1, Y = 3 };
            CPonto CopiaPonto2 = Ponto2; //Atribuição por REFERENCIA!
            Ponto2.X = 3;
            Console.WriteLine("Ponto 2 X: {0}", Ponto2.X);
            Console.WriteLine("Copia Ponto 2 X: {0}", CopiaPonto2.X);




        }
    }
}
