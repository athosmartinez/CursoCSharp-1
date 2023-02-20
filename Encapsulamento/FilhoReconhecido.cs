using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    public class FilhoReconhecido : Subcelebridades
    {
        public new void MeusAcessos()
        {
            Console.WriteLine("Filho da subcelebridade...");
            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDosOlhos);
            Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitodeFalar);
            Console.WriteLine(SegredoFamilia);
            //Console.WriteLine(eFeio);

        }
    }
}
