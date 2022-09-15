using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoUdemy.FUNDAMENTOS
{
    internal class Converçao
    {
        public static void Executar()
        {
            //Conv Implicita Sem perigo perda informação
            int inteiros = 10;
            double quebrado = inteiros;
            Console.WriteLine(quebrado);
            //Conv Explicita Usando cache Quando há possiblidade de perder informação
            double nota = 9.7;
            int notatruncada = (int)nota;
            Console.WriteLine(notatruncada);
            //Conv String para Inteiro
            Console.WriteLine("Digite sua idade:");
            string idadeString = Console.ReadLine();
            int idadeInteiro = int.Parse(idadeString);
            Console.WriteLine("Idade inserida: " + idadeInteiro);

            idadeInteiro = Convert.ToInt32(idadeString);
            Console.WriteLine("Resultado: " + idadeInteiro);

            //MELHOR METODO
            Console.WriteLine("Ditite um numero:");
            string palavra = Console.ReadLine();
            // int numero;
            int.TryParse(palavra, out int numero);
            Console.WriteLine("O número foi: " + numero);

            //MENOS LINHAS (MELHOR METODO)
            Console.WriteLine("Digite outro numero: ");
            int.TryParse(Console.ReadLine(), out int numero2);
            Console.WriteLine("O número foi: " + numero2);
        }
    }
}
