using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    public class Subcelebridades
    {
        // Todos
        public string InfoPublica = "Tenho insta";
        // Herenca
        protected string CorDosOlhos = "Verde";
        // Mesmo projeto (assembly)
        internal ulong NumeroCelular = 5199999999;
        // Herenca ou mesmo projeto 
        protected internal string JeitodeFalar = "Uso muitas girias";
        // Mesma class ou herança no mesmo projeto
        private protected string SegredoFamilia = "Bla bla";
        // Private é o padrão
        bool eFeio = true;

        public void MeusAcessos()
        {
            Console.WriteLine("Subcelebridade...");
            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDosOlhos);
            Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitodeFalar);
            Console.WriteLine(SegredoFamilia);
            Console.WriteLine(eFeio);
        }


    }
}
