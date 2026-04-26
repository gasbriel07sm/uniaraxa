using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio07
{
    internal class Filme
    {
        private string titulo;
        private string genero;
        private int duracaoMinutos;
        private int classificacao;

        public Filme(string titulo, string genero, int duracaoMinutos, int classificacao)
        {
            if (titulo == "")
            {
                this.titulo = "Não informado";
            }
            else
            {
                this.titulo = titulo;
            }

            if (genero == "")
            {
                this.genero = "Não informado";
            }
            else
            {
                this.genero = genero;
            }

            if (duracaoMinutos <= 0)
            {
                this.duracaoMinutos = 1;
            }
            else
            {
                this.duracaoMinutos = duracaoMinutos;
            }

            if (classificacao < 0)
            {
                this.classificacao = 0;
            }
            else
            {
                this.classificacao = classificacao;
            }
        }

        public void ExibirResumo()
        {
            Console.WriteLine("===== RESUMO DO FILME =====");
            Console.WriteLine($"Título: {titulo}");
            Console.WriteLine($"Gênero: {genero}");
            Console.WriteLine($"Duração: {duracaoMinutos} minutos");
            Console.WriteLine($"Classificação indicativa: {classificacao} anos");
            Console.WriteLine();
        }

        public bool EhPermitido(int idadePessoa)
        {
            return idadePessoa >= classificacao;
        }

        public void AlterarDuracao(int novaDuracao)
        {
            if (novaDuracao > 0)
            {
                duracaoMinutos = novaDuracao;
            }
        }
    }
}
