using System;

public class Program
{
    public static void Main(string[] args)
    {
        Aluno a1 = new Aluno();
        Professor p1 = new Professor();
        Disciplina d1 = new Disciplina();
        Notas n1 = new Notas();
        Boletim b1 = new Boletim();

        Console.Write("Nome do aluno: ");
        a1.nome = Console.ReadLine();

        Console.Write("Idade do aluno: ");
        a1.idade = int.Parse(Console.ReadLine());

        Console.Write("Matricula do aluno: ");
        a1.matricula = int.Parse(Console.ReadLine());

        Console.Write("Nome da disciplina: ");
        d1.nome = Console.ReadLine();

        Console.Write("Codigo da disciplina: ");
        d1.codigo = int.Parse(Console.ReadLine());

        Console.Write("Carga Horaria: ");
        d1.cargaHoraria = int.Parse(Console.ReadLine());

        Console.Write("Nome do professor: ");
        p1.nome = Console.ReadLine();

        Console.Write("Codigo do professor: ");
        p1.codigo = int.Parse(Console.ReadLine());

        Console.Write("Formação do professor: ");
        p1.formacao = Console.ReadLine();

        Console.Write("Nota 1: ");
        n1.nota1 = double.Parse(Console.ReadLine());

        Console.Write("Nota 2: ");
        n1.nota2 = double.Parse(Console.ReadLine());

        Console.Write("Nota 3: ");
        n1.nota3 = double.Parse(Console.ReadLine());

        b1.aluno = a1;
        b1.professor = p1;
        b1.disciplina = d1;
        b1.notas = n1;

        double media = (n1.nota1 + n1.nota2 + n1.nota3) / 3;

        string situacao;

        if (media >= 7)
        {
            situacao = "Aprovado";
        }
        else
        {
            situacao = "Reprovado";
        }


        Console.WriteLine("Aluno: " + b1.aluno.nome);
        Console.WriteLine("Disciplina: " + b1.disciplina.nome);
        Console.WriteLine("Professor: " + b1.professor.nome);

        Console.WriteLine("\nNota 1: " + b1.notas.nota1);
        Console.WriteLine("Nota 2: " + b1.notas.nota2);
        Console.WriteLine("Nota 3: " + b1.notas.nota3);

        Console.WriteLine("\nMédia: " + media);
        Console.WriteLine("Situação: " + situacao);
    }
}