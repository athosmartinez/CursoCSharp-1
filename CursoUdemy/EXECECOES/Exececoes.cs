﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoUdemy.EXECECOES
{
    public class Conta
    {
        double Saldo;
        public Conta(double saldo)
        {
            Saldo = saldo;
        }
        public void Sacar(double valor)
        {
            if (valor > Saldo)
            {
                throw new ArgumentException("Saldo Insuficiente.");

            }
            Saldo -= valor;
        }
    }
    internal class Exececoes
    {
        public static void Executar()
        {
            var conta = new Conta(1_230.45);
            try
            {
                //int.Parse("abc");
                conta.Sacar(1600);
                Console.WriteLine("Retirada com sucesso!");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Obrigado!");
            }
        }
    }
}
