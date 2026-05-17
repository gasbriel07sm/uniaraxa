using System;
using System.Collections.Generic;

class ex03
{
	static void Main()
	{
		Console.WriteLine("===== CALCULADORA INFIXADA =====");
		Console.WriteLine("Digite a expressão com espaços entre os valores e operadores.");
		Console.WriteLine("Exemplo: 3 + 4 * 2");
		Console.Write("Expressão: ");

		string expressao = Console.ReadLine();

		double resultado = AvaliarExpressao(expressao);

		Console.WriteLine($"Resultado: {resultado}");
	}

	static double AvaliarExpressao(string expressao)
	{
		Stack<double> operandos = new Stack<double>();
		Stack<char> operadores = new Stack<char>();

		string[] tokens = expressao.Split(' ');

		foreach (string token in tokens)
		{
			if (double.TryParse(token, out double numero))
			{
				operandos.Push(numero);
			}
			else if (EhOperador(token))
			{
				char operadorAtual = token[0];

				while (operadores.Count > 0 &&
					   Precedencia(operadores.Peek()) >= Precedencia(operadorAtual))
				{
					AplicarOperador(operandos, operadores);
				}

				operadores.Push(operadorAtual);
			}
		}

		while (operadores.Count > 0)
		{
			AplicarOperador(operandos, operadores);
		}

		return operandos.Pop();
	}

	static bool EhOperador(string token)
	{
		return token == "+" || token == "-" || token == "*" || token == "/";
	}

	static int Precedencia(char operador)
	{
		if (operador == '+' || operador == '-')
		{
			return 1;
		}

		if (operador == '*' || operador == '/')
		{
			return 2;
		}

		return 0;
	}

	static void AplicarOperador(Stack<double> operandos, Stack<char> operadores)
	{
		double segundoNumero = operandos.Pop();
		double primeiroNumero = operandos.Pop();
		char operador = operadores.Pop();

		double resultado = 0;

		switch (operador)
		{
			case '+':
				resultado = primeiroNumero + segundoNumero;
				break;

			case '-':
				resultado = primeiroNumero - segundoNumero;
				break;

			case '*':
				resultado = primeiroNumero * segundoNumero;
				break;

			case '/':
				resultado = primeiroNumero / segundoNumero;
				break;
		}

		operandos.Push(resultado);
	}
}