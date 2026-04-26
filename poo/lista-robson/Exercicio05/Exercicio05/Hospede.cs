using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio05
{
    internal class Hospede
    {
        private string nome;
        private string cpf;
        private string telefone;

        public void receberDados()
        {
            Console.WriteLine("Digite o nome do hóspede:");
            nome = Console.ReadLine();

            Console.WriteLine("Digite o CPF do hóspede:");
            cpf = Console.ReadLine();

            Console.WriteLine("Digite o telefone do hóspede:");
            telefone = Console.ReadLine();
        }

        public void exibirDados()
        {
            Console.WriteLine("Nome do hóspede: " + nome);
            Console.WriteLine("CPF do hóspede: " + cpf);
            Console.WriteLine("Telefone do hóspede: " + telefone);
        }

        public void atualizarTelefone(string novoTelefone)
        {
            telefone = novoTelefone;
            Console.WriteLine("Telefone atualizado para: " + telefone);
        }
    }
}
