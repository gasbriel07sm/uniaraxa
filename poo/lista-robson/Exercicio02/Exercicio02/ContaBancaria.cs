using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio02
{
    internal class ContaBancaria
    {
        private int numeroConta;
        private string nomeTitular;
        private double saldo;

        public void receberDados()
        {
            Console.Write("Digite o número da conta: ");
            numeroConta = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome do titular: ");
            nomeTitular = Console.ReadLine();

            Console.Write("Digite o saldo inicial: ");
            saldo = double.Parse(Console.ReadLine());
        }

        public void depositar()
        {
            Console.Write("Digite o valor a ser depositado: ");
            double valor = double.Parse(Console.ReadLine());

            saldo += valor;
            Console.WriteLine($"Depósito realizado. Novo saldo: {saldo}");
        }

        public void sacar()
        {
            Console.Write("Digite o valor a ser sacado: ");
            double valor = double.Parse(Console.ReadLine());

            if (valor > saldo || valor < 0)
            {
                Console.WriteLine("Saldo insuficiente para realizar o saque.");
            }
            else
            {
                saldo -= valor;
                Console.WriteLine($"Saque realizado. Novo saldo: {saldo}");
            }
        }

        public void mostrarSaldo()
        {
            Console.WriteLine($"Saldo atual: {saldo}");
        }
    }
}
