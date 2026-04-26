using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio08
{
    internal class ReservaHotel
    {
        private string nomeHospede;
        private int numeroQuarto;
        private int quantidadeDiarias;
        private double valorDiaria;
        private string statusReserva;

        public ReservaHotel(string nomeHospede, int numeroQuarto)
        {
            if (nomeHospede == "")
            {
                this.nomeHospede = "Hóspede não informado";
            }
            else
            {
                this.nomeHospede = nomeHospede;
            }

            if (numeroQuarto <= 0)
            {
                this.numeroQuarto = 1;
            }
            else
            {
                this.numeroQuarto = numeroQuarto;
            }

            quantidadeDiarias = 1;
            valorDiaria = 50;
            statusReserva = "Ativa";
        }

        public ReservaHotel(string nomeHospede, int numeroQuarto, int quantidadeDiarias, double valorDiaria)
        {
            if (nomeHospede == "")
            {
                this.nomeHospede = "Hóspede não informado";
            }
            else
            {
                this.nomeHospede = nomeHospede;
            }

            if (numeroQuarto <= 0)
            {
                this.numeroQuarto = 1;
            }
            else
            {
                this.numeroQuarto = numeroQuarto;
            }

            if (quantidadeDiarias <= 0)
            {
                this.quantidadeDiarias = 1;
            }
            else
            {
                this.quantidadeDiarias = quantidadeDiarias;
            }

            if (valorDiaria <= 0)
            {
                this.valorDiaria = 50;
            }
            else
            {
                this.valorDiaria = valorDiaria;
            }

            statusReserva = "Ativa";
        }

        public double CalcularTotal()
        {
            return quantidadeDiarias * valorDiaria;
        }

        public void ExibirReserva()
        {
            Console.WriteLine("===== RESERVA DO HOTEL =====");
            Console.WriteLine($"Hóspede: {nomeHospede}");
            Console.WriteLine($"Quarto: {numeroQuarto}");
            Console.WriteLine($"Diárias: {quantidadeDiarias}");
            Console.WriteLine($"Valor da diária: R$ {valorDiaria:F2}");
            Console.WriteLine($"Total: R$ {CalcularTotal():F2}");
            Console.WriteLine($"Status: {statusReserva}");
            Console.WriteLine();
        }

        public void AdicionarDiarias(int quantidade)
        {
            if (quantidade > 0)
            {
                quantidadeDiarias += quantidade;
            }
        }

        public void CancelarReserva()
        {
            statusReserva = "Cancelada";
        }

        public void ReativarReserva()
        {
            statusReserva = "Ativa";
        }
    }
}
