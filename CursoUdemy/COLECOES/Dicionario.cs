using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoUdemy.COLECOES
{
    internal class Dicionario
    {
        public static void Executar()
        {
            var filmes = new Dictionary<int, string>();
            filmes.Add(2000, "Gladiador");
            filmes.Add(2020, "Louco de Banana");
            filmes.Add(2010, "Filme bacana");
            filmes.Add(2014, "Filme das divas");

            if (filmes.ContainsKey(2020))
            {
                Console.WriteLine("2020: " + filmes[2020]);
                Console.WriteLine("2020: " + filmes.GetValueOrDefault(2020));

            }

            Console.WriteLine(filmes.ContainsValue("Filme bacana"));

            Console.WriteLine($"REMOVEU {filmes.Remove(2000)}");

            filmes.TryGetValue(2020, out string filme2020);
            Console.WriteLine($"Filme: {filme2020}");

            foreach (var chaves in filmes.Keys)
            {
                Console.WriteLine(chaves);
            }

            foreach (var valor in filmes.Values)
            {
                Console.WriteLine(valor);
            }
            foreach (KeyValuePair<int, string> filme in filmes)
            {
                Console.WriteLine($"{filme.Value} é de {filme.Key}");
            }

            foreach (var filme in filmes)
            {
                Console.WriteLine($"{filme.Value} é de {filme.Key}");
            }
        }
    }
}
