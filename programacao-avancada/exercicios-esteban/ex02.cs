using System;
using System.Collections.Generic;

class ex02
{
    static void Main()
    {
        Stack<int> pilhaOriginal = new Stack<int>();
        Stack<int> pilhaAuxiliar = new Stack<int>();

        Console.WriteLine("===== ORDENAR PILHA =====");

        Console.Write("Quantos números deseja inserir? ");
        int quantidade = int.Parse(Console.ReadLine());

        for (int i = 1; i <= quantidade; i++)
        {
            Console.Write($"Digite o {i}º número: ");
            int numero = int.Parse(Console.ReadLine());

            pilhaOriginal.Push(numero);
        }

        while (pilhaOriginal.Count > 0)
        {
            int elementoRetirado = pilhaOriginal.Pop();

            while (pilhaAuxiliar.Count > 0 && pilhaAuxiliar.Peek() < elementoRetirado)
            {
                pilhaOriginal.Push(pilhaAuxiliar.Pop());
            }

            pilhaAuxiliar.Push(elementoRetirado);
        }

        Console.WriteLine("\nPilha ordenada em ordem crescente no topo:");
        Console.WriteLine("Topo ↓");

        foreach (int numero in pilhaAuxiliar)
        {
            Console.WriteLine(numero);
        }
    }
}