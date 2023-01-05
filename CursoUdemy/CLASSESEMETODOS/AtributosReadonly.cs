using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoUdemy.CLASSESEMETODOS
{

    public class Cliente
    {
        public string Nome;
        readonly DateTime Nascimento;

        
        public Cliente(string nome, DateTime nascimento)
        {
            Nome = nome;
            Nascimento = nascimento;
        }

        public string GetDataDeNascimento()
        {
            return String.Format("{0}/{1}/{2}", Nascimento.Day, Nascimento.Month, Nascimento.Year);
        }
    }
    internal class AtributosReadonly
    {
        public static void Executar()
        {
            var NovoCliente = new Cliente("Ana Siva", new DateTime(1987, 5, 22));
            Console.WriteLine(NovoCliente.Nome);
            Console.WriteLine(NovoCliente.GetDataDeNascimento());
            
        }
    }
}
