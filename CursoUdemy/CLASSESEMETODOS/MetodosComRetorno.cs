﻿using CursoUdemy.CLASSESEMETODOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoUdemy.CLASSESEMETODOS
{
    class CalculadoraComum
    {
        public int Somar(int a, int b)
        {
            return a + b;

        }
        public int Subtrair(int a, int b)
            { 
            return a - b;
        }
        public int Multiplicar(int a, int b)
        {
            return a * b;
        }
        public int Divisão(int a, int b)
        {
            return a / b;
        }
    }


    internal class MetodosComRetorno
    {
        public static void Executar()
        {
            var calculadoraComum = new CalculadoraComum();
            var resultado = calculadoraComum.Somar(5, 5);

            Console.WriteLine(resultado);
            Console.WriteLine(calculadoraComum.Subtrair(2,7));
            Console.WriteLine(calculadoraComum.Multiplicar(4,4));
            Console.WriteLine(calculadoraComum.Divisão(4,2));
        }
    }
}