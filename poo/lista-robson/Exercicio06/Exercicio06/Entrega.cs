using System;
using System.Collections.Generic;
using System.Text;

namespace Exercicio06
{
    internal class Entrega
    {
        private string endereco;
        private double distanciaKm;
        private string tipoEntrega;

        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }

        public double DistanciaKm
        {
            get { return distanciaKm; }
            set
            {
                if (value >= 0)
                {
                    distanciaKm = value;
                }
            }
        }

        public string TipoEntrega
        {
            get { return tipoEntrega; }
            set { tipoEntrega = value; }
        }

        public void ExibirDados()
        {
            Console.WriteLine($"Endereço: {Endereco}");
            Console.WriteLine($"Distância: {DistanciaKm} km");
            Console.WriteLine($"Tipo de entrega: {TipoEntrega}");
        }

        public double CalcularTaxaEntrega()
        {
            return DistanciaKm * 2.00;
        }
    }
}
