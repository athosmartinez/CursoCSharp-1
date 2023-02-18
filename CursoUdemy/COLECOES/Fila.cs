using CursoUdemy.CLASSESEMETODOS;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoUdemy.COLECOES
{
    internal class Fila
    {
        public static void Executar()
        {
            var fila = new Queue<string>();
            fila.Enqueue("Pedro");
            fila.Enqueue("Joao");
            fila.Enqueue("Mariana");

            Console.WriteLine(fila.Peek());
            Console.WriteLine(fila.Count);

            Console.WriteLine(fila.Dequeue());
            Console.WriteLine(fila.Count);

            foreach (var pessoa in fila)
            {
                Console.WriteLine(pessoa);
            }

            var salada = new Queue();
            salada.Enqueue(1.5);
            salada.Enqueue(3);
            salada.Enqueue("ITEM");
            salada.Enqueue(true);

            foreach (var itens in salada)
            {
                Console.WriteLine(itens);
            }

            Console.WriteLine(salada.Contains("30"));
        }
    }
}
