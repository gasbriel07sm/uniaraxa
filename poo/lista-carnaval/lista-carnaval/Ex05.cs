using System;

class Ex05
{
    static void Main(string[] args)
    {
        Console.Write("Total de horas trabalhadas no mês: ");
        double horasMes = double.Parse(Console.ReadLine());

        Console.Write("Salário por hora (R$): ");
        double valorHora = double.Parse(Console.ReadLine());

        const double horasSemanais = 40.0;
        const int semanasMes = 4;
        double horasRegularesMes = horasSemanais * semanasMes;

        double salarioTotal;

        if (horasMes <= horasRegularesMes)
        {
            salarioTotal = horasMes * valorHora;
        }
        else
        {
            double horasExtras = horasMes - horasRegularesMes;
            double valorHoraExtra = valorHora * 1.5; // 50% a mais

            salarioTotal = (horasRegularesMes * valorHora) +
                           (horasExtras * valorHoraExtra);
        }

        Console.WriteLine($"Salário total no mês: R$ {salarioTotal:F2}");
    }
}