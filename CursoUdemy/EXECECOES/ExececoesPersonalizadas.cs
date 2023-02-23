using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoUdemy.EXECECOES
{

    public class NegativoExeception : Exception
    {
        public NegativoExeception() { }

        public NegativoExeception(string msg) : base(msg)
        {

        }
        public NegativoExeception(string msg, Exception inner) : base(msg, inner) { }
    }

    public class ImparExeception : Exception
    {
        public ImparExeception(string msg) : base(msg) { }
    }

    internal class ExececoesPersonalizadas
    {
        public static int PositivoPar()
        {
            Random random = new Random();
            int valor = random.Next(-30, 30);
            if (valor < 0)
            {
                throw new NegativoExeception("Numero negativo!");

            }
            if (valor % 2 == 0)
            {
                throw new ImparExeception("valor Impar");
            }
            return valor;
        }
        public static void Executar()
        {
            try
            {
                Console.WriteLine(PositivoPar());

            }
            catch (NegativoExeception ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (ImparExeception ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
