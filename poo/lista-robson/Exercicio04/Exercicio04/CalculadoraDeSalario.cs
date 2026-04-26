using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio04
{
    internal class CalculadoraDeSalario
    {
        private string nomeFuncionario;
        private double salarioBase;
        private double salarioFinal;

        public void receberDados()
        {
            Console.Write("Digite o nome do funcionário: ");
            nomeFuncionario = Console.ReadLine();

            Console.Write("Digite o salário base do funcionário: ");
            salarioBase = double.Parse(Console.ReadLine());
        }

        public void calcularAumento()
        {
            Console.Write("Digite o percentual de aumento: ");
            double percentual = double.Parse(Console.ReadLine());

            salarioFinal = salarioBase + (salarioBase * percentual / 100);
        }

        public void calcularDesconto()
        {
            Console.Write("Digite o percentual de desconto: ");
            double percentual = double.Parse(Console.ReadLine());

            salarioFinal = salarioBase - (salarioBase * percentual / 100);
        }

        public void mostrarSalario()
        {
            Console.WriteLine($"O salário final do funcionário {nomeFuncionario} é: {salarioFinal:C}");
        }
    }
}
