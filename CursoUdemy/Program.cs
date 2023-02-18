﻿using System;
using System.Collections.Generic;
using CursoUdemy.FUNDAMENTOS;
using CursoUdemy.ESTRUTURASDECONTROLE;
using CursoUdemy.CLASSESEMETODOS;
using CursoUdemy.COLECOES;

namespace CursoCSharp

{
    class Program
    {
        static void Main(string[] args)
        {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                // Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroProgramaCurso.Executar},
                {"Comentarios Programa - Fundamentos", Comentarios.Executar},
                {"Variaveis e Constantes Programa - Fundamentos", VariaveisEConstantes.Executar},
                {"Interferenica Programa - Fundamentos", Interferencia.Executar},
                {"Interpolação Programa - Fundamentos", InterporlaçãoDeStrings.Executar},
                {"Notacao de Ponto Programa - Fundamentos", NotacaoPonto.Executar},
                {"lendo Dados do Console - Fundamentos", LendoDadosDoConsole.Executar},
                {"Formatando Numeros - Fundamentos", FormatandoNumeros.Executar},
                {"Converção - Fundamentos", Converçao.Executar},
                {"Operadores Aritimeticos - Fundamentos", OperadoresAritimeticos.Executar},
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Lógicos - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores Atribuição - Fundamentos", OperadoresAtribuicao.Executar},
                {"Operadores Unarios - Fundamentos", OperadoresUnarios.Executar},
                {"Operadores Ternarios - Fundamentos", OperadoresTernarios.Executar},
                // Estruturas de Controle 
                {"Estrura If -  Estruturas de Controle", EstruturaIf.Executar},
                {"Estrura Switch -  Estruturas de Controle", EstruturaSwitch.Executar},
                {"Estrura While -  Estruturas de Controle", EstruturaWhile.Executar},
                {"Estrura do While -  Estruturas de Controle", EstruturaDoWhile.Executar},
                {"Estrura do For -  Estruturas de Controle", For.Executar},
                {"Estrura do ForEach -  Estruturas de Controle", ForEach.Executar},
                {"Estrura do Break -  Estruturas de Controle", Break.Executar},
                {"Estrura do Continue -  Estruturas de Controle", Continue.Executar},
                // Classes e Metodos
                {"Membros - Classes e Metodos", AtributoseMetodos.Executar},
                {"Construtores - Classes e Metodos", Construtores.Executar},
                {"Metodos com Retorno - Classes e Metodos", MetodosComRetorno.Executar},
                {"Metodos Estaticos - Classes e Metodos", MetodosEstaticos.Executar},
                {"Atributos Estaticos - Classes e Metodos", AtributosEstaticos.Executar},
                {"Desafio - Classes e Metodos", Desafio.Executar},
                {"Parametros Variaveis - Classes e Metodos", ParametrosVariaveis.Executar},
                {"Parametros Nomeados - Classes e Metodos", ParametrosNomeados.Executar},
                {"Getters e Setters - Classes e Metodos", GettersSetters.Executar},
                {"Propriedades - Classes e Metodos", Propriedades.Executar},
                {"Atributos Readonly - Classes e Metodos", AtributosReadonly.Executar},
                {"Enumerações - Classes e Metodos", Enumeracoes.Executar},
                {"Struct - Classes e Metodos", ExemploStruct.Executar},
                {"Struct vs Classe - Classes e Metodos", StructVsClass.Executar},
                {"Valores vs Referencia - Classes e Metodos", ValorVSReferencia.Executar},
                {"Parametros por Referencia - Classes e Metodos", ParametrosPorRef.Executar},
                {"Parametros Padrao - Classes e Metodos", ParametroPadrao.Executar},
                //COLECOES
                {"Coleções - Array", CursoUdemy.COLECOES.Array.Executar},
                {"Coleções - Lista", Lista.Executar},
                {"Coleções - Array List", ListaArray.Executar},
                {"Coleções - Set", Set.Executar},
                {"Coleções - Queue", Fila.Executar},
                {"Coleções - Igualdade", Igualdade.Executar},
                using System;
            using System.Collections.Generic;
            using System.Linq;
            using System.Text;
            using System.Threading.Tasks;

namespace CursoUdemy.COLECOES
    {

        public class Product
        {
            public string Nome;
            public double Preco;

            public Product(string nome, double preco)
            {
                Nome = nome;
                Preco = preco;
            }

            public override bool Equals(object? obj)
            {
                Product outroProduto = (Product)obj;
                bool mesmoNome = Nome == outroProduto.Nome;
                bool mesmoPreco = Preco == outroProduto.Preco;

                return mesmoNome && mesmoPreco;
            }

            public override int GetHashCode()
            {
                return Nome.Length;
            }
        }

        class Lista
        {
            public static void Executar()
            {
                var livro = new Product("Nome do livro", 49.9);
                var carrinho = new List<Product>();
                carrinho.Add(livro);
                var combo = new List<Product>()
            {
                new Product("Camisa 1", 30.0),
                new Product("Camisa 2", 50.0),
                new Product("Camisa 3", 70.0)
            };
                carrinho.AddRange(combo);
                Console.WriteLine(carrinho.Count);
                carrinho.RemoveAt(0);

                foreach (var item in carrinho)
                {
                    Console.Write(carrinho.IndexOf(item));
                    Console.WriteLine($" {item.Nome} {item.Preco}");
                }

                Console.WriteLine(carrinho.Count);
                carrinho.Add(livro);
                Console.WriteLine(carrinho.LastIndexOf(livro));

            }
        }
    }


});

            central.SelecionarEExecutar();
        }
    }
}