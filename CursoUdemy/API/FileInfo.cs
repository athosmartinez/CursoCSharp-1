using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace CursoUdemy.API
{
    internal class ExemploFileInfo
    {
        public static void ExcluirSeExistir(params string[] caminhos)
        {
            foreach (var cam in caminhos)
            {
                FileInfo arquivo = new FileInfo(cam);
                if (arquivo.Exists)
                {
                    arquivo.Delete();
                }

            }
        }
        public static void Executar()
        {

            var caminhoOrigem = @"C:\Users\athos\testes_curso\arq_origem.txt";

            var caminhoDestino = @"C:\Users\athos\testes_curso\arq_destinho.txt";

            var caminhoCopia = @"C:\Users\athos\testes_curso\arq_copia.txt";

            ExcluirSeExistir(caminhoOrigem, caminhoDestino, caminhoCopia);

            using (StreamWriter sw = File.CreateText(caminhoOrigem))
            {
                sw.WriteLine("Arquivo Original");

            }
            FileInfo origem = new FileInfo(caminhoOrigem);
            Console.WriteLine(origem.Name);
            Console.WriteLine(origem.IsReadOnly);
            Console.WriteLine(origem.FullName);
            Console.WriteLine(origem.Extension);
            Console.WriteLine(origem.DirectoryName);
            origem.CopyTo(caminhoCopia);
            origem.MoveTo(caminhoDestino);
        }
    }
}
