using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoUdemy.CLASSESEMETODOS
{
    public enum Genero { Acao, Aventura, Terror, Animacao, Comedia };
    public class Filme
    {
        public string Titulo;
        public Genero GeneroDoFilme;
    }
    internal class Enumeracoes
    {
        public static void Executar()
        {
            int id = (int)Genero.Animacao;
            Console.WriteLine(id);
            var FilmeParaFamilia = new Filme();

            FilmeParaFamilia.Titulo = "Minions";
            FilmeParaFamilia.GeneroDoFilme = Genero.Comedia;

            Console.WriteLine("{0} é do genero {1}!", FilmeParaFamilia.Titulo, FilmeParaFamilia.GeneroDoFilme);
        }
    }
}
