using System;

class Ex06
{
    static char[,] tabuleiro = new char[3, 3];

    static void Main()
    {
        // Inicializa o tabuleiro com números de 1-9 para facilitar a escolha
        char num = '1';
        for (int i = 0; i < 3; i++)
            for (int j = 0; j < 3; j++)
                tabuleiro[i, j] = num++;

        int jogadas = 0;
        char vencedor = ' ';

        Console.WriteLine("===== JOGO DA VELHA =====");
        Console.WriteLine("Jogador 1 = X  |  Jogador 2 = O");
        Console.WriteLine("Use os números do teclado para escolher a posição:\n");
        Console.WriteLine(" 1 | 2 | 3 ");
        Console.WriteLine(" 4 | 5 | 6 ");
        Console.WriteLine(" 7 | 8 | 9 \n");

        while (jogadas < 9 && vencedor == ' ')
        {
            // Contador par = Jogador 1 (X), ímpar = Jogador 2 (O)
            int jogador = (jogadas % 2 == 0) ? 1 : 2;
            char simbolo = (jogador == 1) ? 'X' : 'O';

            MostrarTabuleiro();
            Console.Write("Jogador " + jogador + " (" + simbolo + "), escolha a posição (1-9): ");

            int pos;
            bool valido = false;

            while (!valido)
            {
                string entrada = Console.ReadLine();
                if (int.TryParse(entrada, out pos) && pos >= 1 && pos <= 9)
                {
                    int linha = (pos - 1) / 3;
                    int coluna = (pos - 1) % 3;

                    if (tabuleiro[linha, coluna] != 'X' && tabuleiro[linha, coluna] != 'O')
                    {
                        tabuleiro[linha, coluna] = simbolo;
                        valido = true;
                        jogadas++;
                    }
                    else
                    {
                        Console.Write("Posição já ocupada! Tente outra (1-9): ");
                    }
                }
                else
                {
                    Console.Write("Entrada inválida! Digite um número de 1 a 9: ");
                }
            }

            vencedor = VerificarVencedor();
        }

        MostrarTabuleiro();

        if (vencedor != ' ')
            Console.WriteLine("Jogador " + (vencedor == 'X' ? "1 (X)" : "2 (O)") + " VENCEU!");
        else
            Console.WriteLine("EMPATE! Nenhum jogador venceu.");
    }

    static void MostrarTabuleiro()
    {
        Console.WriteLine();
        for (int i = 0; i < 3; i++)
        {
            Console.Write(" " + tabuleiro[i, 0] + " | " + tabuleiro[i, 1] + " | " + tabuleiro[i, 2]);
            Console.WriteLine();
            if (i < 2) Console.WriteLine("---+---+---");
        }
        Console.WriteLine();
    }

    static char VerificarVencedor()
    {
        // Verifica linhas
        for (int i = 0; i < 3; i++)
            if (tabuleiro[i, 0] == tabuleiro[i, 1] && tabuleiro[i, 1] == tabuleiro[i, 2])
                return tabuleiro[i, 0];

        // Verifica colunas
        for (int j = 0; j < 3; j++)
            if (tabuleiro[0, j] == tabuleiro[1, j] && tabuleiro[1, j] == tabuleiro[2, j])
                return tabuleiro[0, j];

        // Verifica diagonal principal
        if (tabuleiro[0, 0] == tabuleiro[1, 1] && tabuleiro[1, 1] == tabuleiro[2, 2])
            return tabuleiro[0, 0];

        // Verifica diagonal secundária
        if (tabuleiro[0, 2] == tabuleiro[1, 1] && tabuleiro[1, 1] == tabuleiro[2, 0])
            return tabuleiro[0, 2];

        return ' '; // Nenhum vencedor ainda
    }
}