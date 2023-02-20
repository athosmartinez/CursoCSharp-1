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
    internal class Abstract
    {
        public static void Executar()
        {
            Celular c = new Celular();

        }
    }
}
