using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoUdemy.FUNDAMENTOS
{
    internal class NotacaoPonto
    {
        public static void Executar()
        {
            var saudacao = "ola".ToUpper().Insert(3, " Mundo").Replace(" Mundo", " Globo");
            Console.WriteLine(saudacao);

            Console.WriteLine("teste");

            string valorImportante = null;
            // "?" confere se é um valor vazio ou não 
            Console.WriteLine(valorImportante?.Length);
        }
    }
}
