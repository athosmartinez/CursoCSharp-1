﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoUdemy.TOPICOSAVANCADOS
{
    internal class Dynamic
    {
        public static void Executar()
        {
            dynamic meuObjeto = "teste";
            meuObjeto = 3;

            meuObjeto++;
            Console.WriteLine(meuObjeto);

            dynamic aluno = new System.Dynamic.ExpandoObject();
            aluno.nome = "Maria Julia";
            aluno.nota = 8.9;
            aluno.idade = 24;

            Console.WriteLine($"{aluno.nome} {aluno.nota} {aluno.idade}");
        }
    }
}
