﻿using System;
using System.Collections.Generic;
using CursoUdemy.FUNDAMENTOS;
using CursoUdemy.ESTRUTURASDECONTROLE;
using CursoUdemy.CLASSESEMETODOS;
using CursoUdemy.COLECOES;
using CursoUdemy.OO;
using CursoUdemy.METODOSEFUNCOES;
using CursoUdemy.EXECECOES;
using CursoUdemy.API;
using CursoUdemy.LINQ;
using CursoUdemy.TOPICOSAVANCADOS;

namespace CursoCSharp

{
    class Program
    {
        static void Main(string[] args)
        {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                // Fundamentos
                {"Primeiro Programa - Funda     mentos", PrimeiroProgramaCurso.Executar},
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
                {"Array - Coleções", CursoUdemy.COLECOES.Array.Executar},
                {"Lista - Coleções", Lista.Executar},
                {"Array List - Coleções", ListaArray.Executar},
                {"Set - Coleções", Set.Executar},
                {"Queue - Coleções", Fila.Executar},
                {"Igualdade - Coleções", Igualdade.Executar},
                {"Stack - Coleções", Pilha.Executar},
                {"Dicionario - Coleções", Dicionario.Executar},
                //OO 
                {"Herança - OO", Heranca.Executar},
                {"This - OO", ConstrutorThis.Executar},
                {"Encapsulamento - OO", CursoUdemy.OO.Encapsulamento.Executar },
                {"Polimorfismo - OO", Polimorfismo.Executar},
                {"Abstract - OO", Abstract.Executar},
                {"Interface - OO", Interface.Executar},
                {"Sealed - OO", Sealed.Executar},
                //METODOS E FUNCOES
                {"Lambda - Metodos e funções", Lambda.Executar},
                {"Lambda como delegates - Metodos e funções", LambdasDelegate.Executar},
                {"Usando Delegates - Metodos e funções", UsandoDelegates.Executar},
                {"Delegate com funcoes anonimas Delegates - Metodos e funções", DelegatefFuncAno.Executar},
                {"Delegate com parametros - Metodos e funções", DelegatesComPara.Executar},
                {"Metodos e Extensão - Metodos e funções", FuncaoExtensao.Executar},
                //EXCEÇÕES
                {"Exceções e tratamento de erro - Exceções", Exececoes.Executar},
                {"Exceções personalizadas - Exceções", ExececoesPersonalizadas.Executar},
                //API
                {"Primeiro Arquivo- API", PrimeiroArquivo.Executar},
                {"Leitura Arquivo- API", LeituraArquivo.Executar},
                {"File Info - API", ExemploFileInfo.Executar},
                {"Exemplo diretorios - API", ExemploDiretorios.Executar},
                {"Exemplo DirectoryInfo - API", ExemploDiretoriosInfo.Executar},
                {"Exemplo Path - API", ExemploPath.Executar},
                {"Exemplo Path - API", ExemploDateTime.Executar},
                {"Exemplo TimeSpan - API", ExemploTimeSpan.Executar},
                //TOPICOS AVANÇADOS
                {"LINQ1 - Topicos Avançados", LINQ1.Executar},
                {"LINQ2 - Topicos Avançados", LINQ2.Executar},
                {"Nullabes - Topicos Avançados", Nullables.Executar},
                {"Dynamic - Topicos Avançados", Dynamic.Executar},
                {"Generics - Topicos Avançados", Genericos.Executar}


            }); ;

            central.SelecionarEExecutar();
        }
    }
}