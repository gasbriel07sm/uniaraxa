using System;

namespace Exercicio01
{
    internal class Aluno
    {
        private string RA;
        private string nome;
        private double notaProva;
        private double notaTrabalho;
        private double notaFinal;

        public void ReceberDados()
        {
            Console.Write("RA: ");
            RA = Console.ReadLine();

            Console.Write("Nome: ");
            nome = Console.ReadLine();

            Console.Write("Nota da prova: ");
            notaProva = double.Parse(Console.ReadLine());

            Console.Write("Nota do trabalho: ");
            notaTrabalho = double.Parse(Console.ReadLine());
        }

        public void CalcularMedia()
        {
            notaFinal = (notaProva + notaTrabalho) / 2;
        }

        public bool CalcularNotaFinal()
        {
            if (notaFinal >= 7.0)
            {
                Console.WriteLine("Aprovado diretamente.");
                return true;
            }
            else
            {
                double notaNecessaria = 10 - notaFinal;

                Console.WriteLine("Precisa fazer prova final.");
                Console.WriteLine($"Nota necessária na prova final: {notaNecessaria:F2}");

                return false;
            }
        }

        public void ImprimirNotaFinal()
        {
            Console.WriteLine($"Nota final: {notaFinal:F2}");
        }
    }
}