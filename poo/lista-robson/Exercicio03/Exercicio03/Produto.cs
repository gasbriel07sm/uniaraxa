using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio03
{
    internal class Produto
    {
        private string codigoProduto;
        private string nomeProduto;
        private double preco;
        private int quantidadeEstoque;

        public void receberDados()
        {
            Console.Write("Digite o código do produto: ");
            codigoProduto = Console.ReadLine();

            Console.Write("Digite o nome do produto: ");
            nomeProduto = Console.ReadLine();

            Console.Write("Digite o preço do produto: ");
            preco = double.Parse(Console.ReadLine());

            Console.Write("Digite a quantidade inicial em estoque: ");
            quantidadeEstoque = int.Parse(Console.ReadLine());
        }

        public void adicionarEstoque()
        {
            Console.Write("Digite a quantidade a ser adicionada ao estoque: ");
            int quantidadeAdicionar = int.Parse(Console.ReadLine());

            if (quantidadeAdicionar < 0)
            {
                Console.WriteLine("Quantidade inválida. A quantidade a ser adicionada deve ser positiva.");
            }
            else
            {
                quantidadeEstoque += quantidadeAdicionar;
                Console.WriteLine("Estoque atualizado. Quantidade atual: " + quantidadeEstoque);
            }
        }

        public void removerEstoque()
        {
            Console.Write("Digite a quantidade a ser removida do estoque: ");
            int quantidadeRemover = int.Parse(Console.ReadLine());

            if (quantidadeRemover < 0)
            {
                Console.WriteLine("Quantidade inválida. A quantidade a ser removida deve ser positiva.");
            }
            else if (quantidadeRemover > quantidadeEstoque)
            {
                Console.WriteLine("Quantidade insuficiente em estoque. Quantidade atual: " + quantidadeEstoque);
            }
            else
            {
                quantidadeEstoque -= quantidadeRemover;
                Console.WriteLine("Estoque atualizado. Quantidade atual: " + quantidadeEstoque);
            }
        }

        public void mostrarProduto()
        {
            Console.WriteLine($"Código produto: {codigoProduto}");
            Console.WriteLine($"Nome produto: {nomeProduto}");
            Console.WriteLine($"Preço: {preco:F2}");
            Console.WriteLine($"Quantidade atual em estoque: {quantidadeEstoque}");
        }
    }
}
