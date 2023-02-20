using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    public class AmigoProximo
    {
        public readonly Subcelebridades amiga = new Subcelebridades();
        public void MeusAcessos()
        {
            Console.WriteLine("Amigo proximo...");
            Console.WriteLine(amiga.InfoPublica);
            //Console.WriteLine(amiga.CorDosOlhos);
            Console.WriteLine(amiga.NumeroCelular);
            Console.WriteLine(amiga.JeitodeFalar);
            //Console.WriteLine(amiga.SegredoFamilia);
            //Console.WriteLine(amiga.eFeio);
        }
    }
}
