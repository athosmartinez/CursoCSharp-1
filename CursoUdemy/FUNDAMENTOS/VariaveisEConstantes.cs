using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoUdemy.FUNDAMENTOS
{
    internal class VariaveisEConstantes
    {
        public static void Executar()
        {
            // Area da Circunferencia
            double raio = 4.5;
            const double PI = 3.14;

            raio = 5.5;
            // PI = 3.1415;

            double area = PI * raio * raio;
            Console.WriteLine("Área é " + area);

            // Tipos internos
            bool estaChovendo = true;
            Console.WriteLine("Está chovendo " + estaChovendo);
            // 0 a 256 - Apenas positivos
            byte idade = 45;
            Console.WriteLine("Idade " + idade);
            // -127 a 128 - Tem um range de positivo e negativo
            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("Saldo de Gols " + saldoDeGols);
            // -32 e uns quebrados até 32 e uns quebrados
            short salario = short.MinValue;
            Console.WriteLine("Salario " + salario);
            //Mais usado dos inteiros!
            int menorValorInt = int.MinValue;
            Console.WriteLine("Menor inteiro é " + menorValorInt);
            //inteiro sem sinal - Todos positivos
            uint populacaoBrasileira = 207_600_000;
            Console.WriteLine("População Brasileira " + populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor valor long " + menorValorLong);

            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine("População Mundial " + populacaoMundial);

            float precoComputador = 1299.99f;
            Console.WriteLine("Preço computador " + precoComputador);

            double valorDeMercadoDaApple = 1_000_000_000_000.00; // Mais usado numeros decimais
            Console.WriteLine("Valor Apple " + valorDeMercadoDaApple);

            decimal distanciaEntreEstrelas = decimal.MaxValue; // Numeros astronomicos
            Console.WriteLine("Distancia entre as Estrelas " + distanciaEntreEstrelas);

            char letra = 'b';
            Console.WriteLine("Letra: " + letra);

            string textoBoasVindas = "Seja bem vindo meu amigo!";
            Console.WriteLine(textoBoasVindas);






        }
    }
}
