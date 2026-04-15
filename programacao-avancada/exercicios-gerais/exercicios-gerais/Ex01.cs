using System;

class Ex01
{
    static void Main()
    {
        Console.WriteLine("Digite o valor de A:");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor de B:");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor de C:");
        int c = int.Parse(Console.ReadLine());

        // Encontrando o maior valor
        int maior = a;
        if (b > maior) maior = b;
        if (c > maior) maior = c;

        Console.WriteLine($"O maior valor digitado é: {maior}");

        // Verificando a paridade da soma
        int soma = a + b + c;
        if (soma % 2 == 0)
            Console.WriteLine($"A soma ({soma}) é PAR.");
        else
            Console.WriteLine($"A soma ({soma}) é ÍMPAR.");
    }
}