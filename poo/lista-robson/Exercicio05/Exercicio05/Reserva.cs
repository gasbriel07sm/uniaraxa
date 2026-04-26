using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio05
{
    internal class Reserva
    {
        private int numeroReserva;
        private int quantidadeDiarias;
        private double valorDiaria;
        private double valorTotal;

        private void receberDadosReserva()
        {
            Console.WriteLine("Digite o número da reserva:");
            numeroReserva = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade de diárias:");
            quantidadeDiarias = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor da diária:");
            valorDiaria = double.Parse(Console.ReadLine());
        }

        public void calcularTotal()
        {
            valorTotal = quantidadeDiarias * valorDiaria;
        }

        public void aplicarDesconto(double percentualDesconto)
        {
            double valorDesconto = valorTotal * (percentualDesconto / 100);
            valorTotal -= valorDesconto;
        }

        public void mostrarReserva()
        {
            Console.WriteLine("Número da reserva: " + numeroReserva);
            Console.WriteLine("Quantidade de diárias: " + quantidadeDiarias);
            Console.WriteLine("Valor da diária: " + valorDiaria);
            Console.WriteLine("Valor total da reserva: " + valorTotal);
        }
    }
}
