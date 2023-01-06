using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CursoUdemy.CLASSESEMETODOS
{
    interface Ponto
    {
        void MoverDiagonal(int delta);

    }

    struct Coordenada : Ponto
    {
        public int x;
        public int y;
        public Coordenada(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void MoverDiagonal(int delta)
        {
            x += delta;
            y += delta;
        }
    }

    internal class ExemploStruct
    {
        public static void Executar()
        {
            Coordenada coordenadaInicial;
            coordenadaInicial.x = 2;
            coordenadaInicial.y = 2;

            Console.WriteLine("Cordenada inicial:");
            Console.WriteLine("X = {0}", coordenadaInicial.x);
            Console.WriteLine("y = {0}", coordenadaInicial.y);

            var coordenadaFinal = new Coordenada(9, 1);
            coordenadaFinal.MoverDiagonal(10);

            Console.WriteLine("Cordenada final:");
            Console.WriteLine("X = {0}", coordenadaFinal.x);
            Console.WriteLine("y = {0}", coordenadaFinal.y);

        }

    }
}
