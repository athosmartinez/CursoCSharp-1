﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoUdemy.METODOSEFUNCOES
{
    public static class ExtensoesInteiro
    {
        public static int Soma(this int num, int OutroNumero)
        {
            return num + OutroNumero;

        }

        public static int Sub(this int num, int outroNumero)
        {
            return num - outroNumero;
        }
    }
    internal class FuncaoExtensao
    {
        public static void Executar()
        {
            int numero = 5;
            Console.WriteLine(numero.Soma(3));
            Console.WriteLine(numero.Sub(10));
            Console.WriteLine(2.Soma(3));
            Console.WriteLine(2.Sub(3));
        }
    }
}
