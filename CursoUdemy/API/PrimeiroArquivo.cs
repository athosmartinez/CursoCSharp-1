using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CursoUdemy.API
{

    public static class ExtensaoString
    {

    }
    internal class PrimeiroArquivo
    {
        public static void Executar()
        {

            var path = @"C:\Users\athos\primeiro_arquivo.txt";
            if (!File.Exists(path))
            {
                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.WriteLine("Esse é");
                    sw.WriteLine("o nosso");
                    sw.WriteLine("primeiro");
                    sw.WriteLine("arquivo!");
                }
            }
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine("");
                sw.WriteLine("pode adicioanr");
                sw.WriteLine("mais");
                sw.WriteLine("texto!");
            }
        }
    }
}
