using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio06
{
    internal class Pedido
    {
        private int numero;
        private Cliente cliente;
        private Vendedor vendedor;
        private Produto produto;
        private Pagamento pagamento;
        private Entrega entrega;

        public int Numero
        {
            get { return numero; }
        }

        public Cliente Cliente
        {
            get { return cliente; }
            set
            {
                if (value != null)
                {
                    cliente = value;
                }
            }
        }

        public Vendedor Vendedor
        {
            get { return vendedor; }
            set
            {
                if (value != null)
                {
                    vendedor = value;
                }
            }
        }

        public Produto Produto
        {
            get { return produto; }
            set
            {
                if (value != null)
                {
                    produto = value;
                }
            }
        }

        public Pagamento Pagamento
        {
            get { return pagamento; }
            set
            {
                if (value != null)
                {
                    pagamento = value;
                }
            }
        }

        public Entrega Entrega
        {
            get { return entrega; }
            set
            {
                if (value != null)
                {
                    entrega = value;
                }
            }
        }

        public Pedido(int numero)
        {
            this.numero = numero;
        }

        public double CalcularValorFinal()
        {
            double subtotal = Produto.CalcularSubtotal();
            double taxaEntrega = Entrega.CalcularTaxaEntrega();
            double acrescimo = Pagamento.CalcularAcrescimo(subtotal);

            return subtotal + taxaEntrega + acrescimo;
        }

        public double CalcularComissaoVendedor()
        {
            double valorFinal = CalcularValorFinal();
            return Vendedor.CalcularComissao(valorFinal);
        }

        public void ExibirResumo()
        {
            Console.WriteLine("===== RESUMO DO PEDIDO =====");
            Console.WriteLine($"Número do pedido: {Numero}");

            Console.WriteLine("\n--- Cliente ---");
            Cliente.ExibirDados();

            Console.WriteLine("\n--- Vendedor ---");
            Vendedor.ExibirDados();

            Console.WriteLine("\n--- Produto ---");
            Produto.ExibirDados();

            Console.WriteLine("\n--- Pagamento ---");
            Pagamento.ExibirDados();

            Console.WriteLine("\n--- Entrega ---");
            Entrega.ExibirDados();

            Console.WriteLine("\n--- Valores ---");
            Console.WriteLine($"Subtotal: R$ {Produto.CalcularSubtotal():F2}");
            Console.WriteLine($"Taxa de entrega: R$ {Entrega.CalcularTaxaEntrega():F2}");
            Console.WriteLine($"Valor final: R$ {CalcularValorFinal():F2}");
            Console.WriteLine($"Comissão do vendedor: R$ {CalcularComissaoVendedor():F2}");
        }
    }
}
