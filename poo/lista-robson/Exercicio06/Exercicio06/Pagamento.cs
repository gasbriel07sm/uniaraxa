using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio06
{
    internal class Pagamento
    {
        private string formaPagamento;
        private int parcelas;

        public string FormaPagamento
        {
            get { return formaPagamento; }
            set { formaPagamento = value; }
        }

        public int Parcelas
        {
            get { return parcelas; }
            set
            {
                if (value >= 1)
                {
                    parcelas = value;
                }
            }
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Forma de pagamento: {FormaPagamento}");
            Console.WriteLine($"Parcelas: {Parcelas}");
        }

        public bool ValidarPagamento()
        {
            return Parcelas >= 1;
        }

        public double CalcularAcrescimo(double valorBase)
        {
            if (Parcelas <= 1)
            {
                return 0;
            }

            return valorBase * 0.05;
        }
    }
}
