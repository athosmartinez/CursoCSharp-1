using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CursoUdemy.API
{
    internal class LeituraArquivo
    {
        public static void Executar()
        {
            var path = @"C:\Users\athos\lendo_arquivo.txt";

            if (!File.Exists(path))
            {
                using (StreamWriter sw = File.AppendText(path))
                {
                    sw.WriteLine("Produto;Preço;Qtde");
                    sw.WriteLine("Caneta;3.59;28");
                    sw.WriteLine("Borracha;2.59;20");
                }

            }
                try
                {
                    using (StreamReader sr = new StreamReader(path))
                    {
                        var texto = sr.ReadToEnd();
                        Console.WriteLine(texto);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

        }
    }
}
