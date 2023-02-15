using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoUdemy.COLECOES
{
    internal class Array
    {
        public static void Executar()
        {
            string[] alunos = new string[5];
            alunos[0] = "Pedro";
            alunos[1] = "Bia";
            alunos[2] = "Carlos";
            alunos[3] = "Santos";
            alunos[4] = "Werneck";

            foreach(var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }

            double somatorio = 0;
            double[] notas = { 9.7, 8.4, 5, 9.9, 8.6 };

            foreach(var nota in notas) {
                somatorio += nota;
            }

            double media = somatorio / notas.Length;
            Console.WriteLine(media);

            char[] letras = { 'A', 'n', 'd', 'r', 'e' };
            string palavra = new string(letras);
            Console.WriteLine(palavra);
            foreach(var letra in letras)
            {
                Console.WriteLine(letra);
            }

        }
    }
}
