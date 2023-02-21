using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoUdemy.OO
{

    sealed class SemFilho
    {
        public double valorF()
        {
            return 1_414_044.05;
        }
    }
    //class Soufilho : Semfilho
    //{

    //}

    class Avo
    {
        public virtual bool HonrarNomeFamilia()
        {
            return true;

        }
    }

    class Pai : Avo
    {
        public sealed override bool HonrarNomeFamilia()
        {
            return true;
        }
    }
    class FilhoRebelde : Pai { }
    //{
    //    public override bool HonrarNomeFamilia()
    //    {
    //        return false;
    //    }
    //}
    internal class Sealed
    {
        public static void Executar()
        {
            SemFilho semFilho = new SemFilho();
            Console.WriteLine(semFilho.valorF);

            FilhoRebelde filho = new FilhoRebelde();
            Console.WriteLine(filho.HonrarNomeFamilia());
        }
    }
}
