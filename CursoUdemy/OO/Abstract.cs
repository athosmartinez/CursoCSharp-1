using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoUdemy.OO
{
    public abstract class Celular
    {
        public abstract string Assistente();

        public string Tocar()
        {
            return "Truim truim truim...";
        }
    }

    public class Samsung : Celular
    {
        public override string Assistente()
        {
            return "Olá meu nome é Bixby!";
        }
    }

    public class Iphone : Celular
    {
        public override string Assistente()
        {
            return "Olá meu nome é Siri!";
        }
    }

    internal class Abstract
    {
        public static void Executar()
        {
            var celular = new List<Celular> { new Iphone(),
                new Samsung()};

            foreach (var celulares in celular)
            {
                Console.WriteLine(celulares.Assistente());
            }
        }
    }
}
