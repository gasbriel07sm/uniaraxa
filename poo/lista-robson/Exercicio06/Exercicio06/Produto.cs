using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio06
{
    internal class Produto
    {
        private string descricao;
        private double precoUnitario;
        private int quantidade;

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        public double PrecoUnitario
        {
            get { return precoUnitario; }
            set
            {
                if (value >= 0)
                {
                    precoUnitario = value;
                }
            }
        }

        public int Quantidade
        {
            get { return quantidade; }
            set
            {
                if (value > 0)
                {
                    quantidade = value;
                }
            }
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Produto: {Descricao}");
            Console.WriteLine($"Preço unitário: R$ {PrecoUnitario:F2}");
            Console.WriteLine($"Quantidade: {Quantidade}");
        }

        public double CalcularSubtotal()
        {
            return PrecoUnitario * Quantidade;
        }
    }
}
