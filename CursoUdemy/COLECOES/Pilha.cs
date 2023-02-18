using System;
using System.Collections;

using System.Text;


namespace CursoUdemy.COLECOES
{
    internal class Pilha
    {
        public static void Executar()
        {
            var pilha = new Stack();
            pilha.Push(3);
            pilha.Push("a");
            pilha.Push(true);
            pilha.Push(5.55);

            Console.WriteLine(pilha.Count);
            foreach (var itens in pilha)
            {
                Console.Write($"{itens} ");
            }

            Console.WriteLine($"\nPop: {pilha.Pop()}");


            foreach (var itens in pilha)
            {
                Console.Write($"{itens} ");
            }

            Console.WriteLine($"\nPeek: {pilha.Peek()}");
            Console.WriteLine(pilha.Count);
            foreach (var itens in pilha)
            {
                Console.Write($"{itens} ");
            }
        }
    }
}
