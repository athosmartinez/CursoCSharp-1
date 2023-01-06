using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoUdemy.CLASSESEMETODOS
{
    internal class Desafio
    {

        //Atributo pertence a instancia
        int a = 10;
        public static void Executar()
        {
            //Acessar a variavel 'a' dentro do metodo executar!
      

            //Criar está instancia
            Desafio desafio = new Desafio();

            Console.WriteLine(desafio.a);
        }
    }
}
