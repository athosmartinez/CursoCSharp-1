using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Encapsulamento;

namespace CursoUdemy.OO
{

    public class FilhoNaoReconhedio : Subcelebridades
    {
        public new void MeusAcessos()
        {
            Console.WriteLine("Filho não reconhecido...");
            Console.WriteLine(InfoPublica);
            Console.WriteLine(CorDosOlhos);
            //Console.WriteLine(NumeroCelular);
            Console.WriteLine(JeitodeFalar);
            //Console.WriteLine(SegredoFamilia);
            //Console.WriteLine(eFeio);
        }
    }

    public class AmigoDistante
    {
        public readonly Subcelebridades amigo = new Subcelebridades();

        public void MeusAcessos()
        {
            Console.WriteLine("Amigo distante...");
            Console.WriteLine(amigo.InfoPublica);
            //Console.WriteLine(amigo.CorDosOlhos);
            //Console.WriteLine(amigo.NumeroCelular);
            //Console.WriteLine(amigo.JeitodeFalar);
            //Console.WriteLine(amigo.SegredoFamilia);
            //Console.WriteLine(amigo.eFeio);
        }
    }

    internal class Encapsulamento
    {
        public static void Executar()
        {
            Subcelebridades sub = new Subcelebridades();
            sub.MeusAcessos();
            new FilhoReconhecido().MeusAcessos();
            new AmigoProximo().MeusAcessos();
            new FilhoNaoReconhedio().MeusAcessos();
            new AmigoDistante().MeusAcessos();
         
        }
    }
}
