using System;
using System.Collections.Generic;

class ex01
{
    static void Main()
    {
        Stack<string> historico = new Stack<string>();
        Stack<string> avancar = new Stack<string>();

        while (true)
        {
            Console.WriteLine("\n===== HISTÓRICO DE NAVEGAÇÃO =====");
            Console.WriteLine("1 - Visitar URL");
            Console.WriteLine("2 - Voltar");
            Console.WriteLine("3 - Avançar");
            Console.WriteLine("4 - Exibir página atual");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha uma opção: ");

            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.Write("Digite a URL: ");
                    string url = Console.ReadLine();

                    historico.Push(url);
                    avancar.Clear();

                    Console.WriteLine($"Página visitada: {url}");
                    break;

                case "2":
                    if (historico.Count <= 1)
                    {
                        Console.WriteLine("Não há página anterior.");
                    }
                    else
                    {
                        string paginaAtual = historico.Pop();
                        avancar.Push(paginaAtual);

                        Console.WriteLine($"Você voltou para: {historico.Peek()}");
                    }
                    break;

                case "3":
                    if (avancar.Count == 0)
                    {
                        Console.WriteLine("Não há página para avançar.");
                    }
                    else
                    {
                        string proximaPagina = avancar.Pop();
                        historico.Push(proximaPagina);

                        Console.WriteLine($"Você avançou para: {historico.Peek()}");
                    }
                    break;

                case "4":
                    if (historico.Count == 0)
                    {
                        Console.WriteLine("Nenhuma página acessada.");
                    }
                    else
                    {
                        Console.WriteLine($"Página atual: {historico.Peek()}");
                    }
                    break;

                case "0":
                    return;

                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }
}