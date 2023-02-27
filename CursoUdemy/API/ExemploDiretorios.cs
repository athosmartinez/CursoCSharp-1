using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoUdemy.API
{
    internal class ExemploDiretorios
    {
        public static void Executar()
        {
            var novoDir = @"C:\Users\athos\CursoCriou";
            var novoDirDestino = @"C:\Users\athos\CursoCriouDestino";
            var dirProjeto = @"C:\Users\athos\source\repos\athosmartinez\CursoUdemy\CursoUdemy";

            if (Directory.Exists(novoDir))
            {
                Directory.Delete(novoDir, true);
            }
            if (Directory.Exists(novoDirDestino))
            {
                Directory.Delete(novoDirDestino, true);

            }
            Directory.CreateDirectory(novoDir);
            Console.WriteLine(Directory.GetCreationTime(novoDir));
            Console.WriteLine("===== Pastas =======");

            var pastas = Directory.GetDirectories(dirProjeto);
            foreach (var pasta in pastas)
            {
                Console.WriteLine(pasta);

            }
            Console.WriteLine("\n\n===== Arquivos =======");
            var arquivos = Directory.GetFiles(dirProjeto);
            foreach (var arquivo in arquivos)
            {
                Console.WriteLine(arquivo);

            }

            Console.WriteLine("\n\n===== Raiz =======");
            Console.WriteLine(Directory.GetDirectoryRoot(novoDir));

            Directory.Move(novoDir, novoDirDestino);
        }
    }
}
