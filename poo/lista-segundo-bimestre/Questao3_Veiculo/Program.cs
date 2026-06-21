Console.WriteLine("===== CADASTRO DE CARRO =====");
Carro carro = new Carro();
carro.ReceberDadosCarro();
carro.MostrarDados();

Console.WriteLine();
Console.WriteLine("===== CADASTRO DE MOTO =====");
Moto moto = new Moto();
moto.ReceberDadosMoto();
moto.MostrarDados();

Console.WriteLine();
Console.WriteLine("===== CADASTRO DE CAMINHÃO =====");
Caminhao caminhao = new Caminhao();
caminhao.ReceberDadosCaminhao();
caminhao.MostrarDados();

class Veiculo
{
    public string Modelo { get; set; }
    public int Ano { get; set; }
    public double ValorBaseManutencao { get; set; }

    public virtual void ReceberDados()
    {
        Console.Write("Modelo: ");
        Modelo = Console.ReadLine();

        Console.Write("Ano: ");
        Ano = int.Parse(Console.ReadLine());

        Console.Write("Valor base de manutenção: ");
        ValorBaseManutencao = double.Parse(Console.ReadLine());
    }

    public virtual double CalcularCustoManutencao()
    {
        return ValorBaseManutencao;
    }

    public virtual void MostrarDados()
    {
        Console.WriteLine($"Modelo: {Modelo}");
        Console.WriteLine($"Ano: {Ano}");
        Console.WriteLine($"Custo de manutenção: R$ {CalcularCustoManutencao():F2}");
    }
}

class Carro : Veiculo
{
    public int QuantidadePortas { get; set; }

    public void ReceberDadosCarro()
    {
        ReceberDados();

        Console.Write("Quantidade de portas: ");
        QuantidadePortas = int.Parse(Console.ReadLine());
    }

    public override double CalcularCustoManutencao()
    {
        return ValorBaseManutencao + 200;
    }

    public override void MostrarDados()
    {
        Console.WriteLine("--- Carro ---");
        base.MostrarDados();
        Console.WriteLine($"Portas: {QuantidadePortas}");
    }
}

class Moto : Veiculo
{
    public int Cilindradas { get; set; }

    public void ReceberDadosMoto()
    {
        ReceberDados();

        Console.Write("Cilindradas: ");
        Cilindradas = int.Parse(Console.ReadLine());
    }

    public override double CalcularCustoManutencao()
    {
        return ValorBaseManutencao + 100;
    }

    public override void MostrarDados()
    {
        Console.WriteLine("--- Moto ---");
        base.MostrarDados();
        Console.WriteLine($"Cilindradas: {Cilindradas}");
    }
}

class Caminhao : Veiculo
{
    public double CapacidadeCarga { get; set; }

    public void ReceberDadosCaminhao()
    {
        ReceberDados();

        Console.Write("Capacidade de carga (kg): ");
        CapacidadeCarga = double.Parse(Console.ReadLine());
    }

    public override double CalcularCustoManutencao()
    {
        return ValorBaseManutencao + 500;
    }

    public override void MostrarDados()
    {
        Console.WriteLine("--- Caminhão ---");
        base.MostrarDados();
        Console.WriteLine($"Capacidade de carga: {CapacidadeCarga} kg");
    }
}
