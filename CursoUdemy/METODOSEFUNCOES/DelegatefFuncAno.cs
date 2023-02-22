using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoUdemy.METODOSEFUNCOES
{
    internal class DelegatefFuncAno
    {
        delegate string StringOpera(string s);
        public static void Executar()
        {
            StringOpera inverter = delegate (string s)
            {
                char[] charArray = s.ToCharArray();
                Array.Reverse(charArray);
                return new string(charArray);
            };

            Console.WriteLine(inverter("Athos"));
        }
    }
}
