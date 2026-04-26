using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio01
{
    internal class Aluno
    {
        private string RA;
        private string nome;
        private double notaProva;
        private double notaTrabalho;
        private double notaFinal;

        public void receberDados(string RA, string nome, double notaProva, double notaTrabalho)
        {
            this.RA = RA;
            this.nome = nome;
            this.notaProva = notaProva;
            this.notaTrabalho = notaTrabalho;
        }

        public void calcularMedia()
        {
            notaFinal = (notaProva + notaTrabalho) / 2;
            Console.WriteLine($"Média calculada: {notaFinal}");
        }

        public Boolean calcularNotaFinal()
        {
            if (notaFinal >= 7.0)
            {
                Console.WriteLine("Aprovado.");
                return true;
            } 
            else
            {
                double notaNecessaria = 10 - notaFinal;
                Console.WriteLine($"Reprovado. Nota necessária para aprovação: {notaNecessaria}");
                return false;
            }
        }

        public void imprimirNotaFinal()
        {
            Console.WriteLine($"Nota final: {notaFinal}");
        }


    }
}
