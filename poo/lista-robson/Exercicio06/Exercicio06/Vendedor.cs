using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio06
{
    internal class Vendedor
    {
        private string nome;
        private double percentualComissao;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Matricula
        {
            get { return Nome + "10"; }
        }

        public double PercentualComissao
        {
            get { return percentualComissao; }
            set
            {
                if (value >= 0)
                {
                    percentualComissao = value;
                }
            }
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Vendedor: {Nome}");
            Console.WriteLine($"Matrícula: {Matricula}");
            Console.WriteLine($"Comissão: {PercentualComissao}%");
        }

        public double CalcularComissao(double valorPedido)
        {
            return valorPedido * PercentualComissao / 100;
        }
    }
}
