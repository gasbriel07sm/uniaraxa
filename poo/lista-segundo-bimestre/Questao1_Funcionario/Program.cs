Console.WriteLine("===== CADASTRO DE FUNCIONÁRIO CLT =====");
FuncionarioCLT clt = new FuncionarioCLT();
clt.ReceberDadosCLT();
clt.MostrarDados();

Console.WriteLine();
Console.WriteLine("===== CADASTRO DE FUNCIONÁRIO COMISSIONADO =====");
FuncionarioComissionado com = new FuncionarioComissionado();
com.ReceberDadosComissionado();
com.MostrarDados();

class Funcionario
{

    public string Nome { get; set; }
    public string Cargo { get; set; }
    public double SalarioBase { get; set; }

    public virtual void ReceberDados()
    {
        Console.Write("Nome: ");
        Nome = Console.ReadLine();

        Console.Write("Cargo: ");
        Cargo = Console.ReadLine();

        Console.Write("Salário base: ");

        SalarioBase = double.Parse(Console.ReadLine());
    }

    public virtual double CalcularSalarioFinal()
    {
        return SalarioBase;
    }

    public virtual void MostrarDados()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Cargo: {Cargo}");

        Console.WriteLine($"Salário final: R$ {CalcularSalarioFinal():F2}");
    }
}

class FuncionarioCLT : Funcionario
{

    public double Bonus { get; set; }

    public void ReceberDadosCLT()
    {

        ReceberDados();

        Console.Write("Bônus: ");
        Bonus = double.Parse(Console.ReadLine());
    }

    public override double CalcularSalarioFinal()
    {
        return SalarioBase + Bonus;
    }

    public override void MostrarDados()
    {
        Console.WriteLine("--- Funcionário CLT ---");
        base.MostrarDados();
        Console.WriteLine($"Bônus: R$ {Bonus:F2}");
    }
}

class FuncionarioComissionado : Funcionario
{

    public double TotalVendas { get; set; }
    public double PercentualComissao { get; set; }

    public void ReceberDadosComissionado()
    {
        ReceberDados();

        Console.Write("Total de vendas: ");
        TotalVendas = double.Parse(Console.ReadLine());

        Console.Write("Percentual de comissão (%): ");
        PercentualComissao = double.Parse(Console.ReadLine());
    }

    public override double CalcularSalarioFinal()
    {
        return SalarioBase + (TotalVendas * PercentualComissao / 100);
    }

    public override void MostrarDados()
    {
        Console.WriteLine("--- Funcionário Comissionado ---");
        base.MostrarDados();
        Console.WriteLine($"Total de vendas: R$ {TotalVendas:F2}");
        Console.WriteLine($"Comissão: {PercentualComissao}%");
    }
}
