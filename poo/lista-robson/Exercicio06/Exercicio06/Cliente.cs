using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio06
{
    internal class Cliente
    {
        private string nome;
        private string cpf;
        private string cidade;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }

        public string Cidade
        {
            get { return cidade; }
            set { cidade = value; }
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Cliente: {Nome}");
            Console.WriteLine($"CPF: {Cpf}");
            Console.WriteLine($"Cidade: {Cidade}");
        }

        public string RetornarApresentacao()
        {
            return $"Cliente {Nome}, CPF {Cpf}, da cidade de {Cidade}.";
        }
    }
}
