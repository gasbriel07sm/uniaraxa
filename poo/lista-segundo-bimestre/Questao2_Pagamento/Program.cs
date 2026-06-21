Console.WriteLine("===== PAGAMENTO VIA PIX =====");
PagamentoPix pix = new PagamentoPix();
pix.ReceberDadosPix();
pix.ProcessarPagamento();
pix.MostrarPagamento();

Console.WriteLine();
Console.WriteLine("===== PAGAMENTO VIA CARTÃO DE CRÉDITO =====");
PagamentoCartaoCredito cartao = new PagamentoCartaoCredito();
cartao.ReceberDadosCartao();
cartao.ProcessarPagamento();
cartao.MostrarPagamento();

class Pagamento
{
    public string NomeCliente { get; set; }
    public double Valor { get; set; }

    public virtual void ReceberDados()
    {
        Console.Write("Nome do cliente: ");
        NomeCliente = Console.ReadLine();

        Console.Write("Valor do pagamento: ");
        Valor = double.Parse(Console.ReadLine());
    }

    public virtual void ProcessarPagamento()
    {
        Console.WriteLine("Pagamento processado.");
    }

    public virtual void MostrarPagamento()
    {
        Console.WriteLine($"Cliente: {NomeCliente}");
        Console.WriteLine($"Valor: R$ {Valor:F2}");
    }
}

class PagamentoPix : Pagamento
{
    public string ChavePix { get; set; }

    public void ReceberDadosPix()
    {
        ReceberDados();

        Console.Write("Chave Pix: ");
        ChavePix = Console.ReadLine();
    }

    public override void ProcessarPagamento()
    {
        Console.WriteLine("Pagamento via Pix aprovado instantaneamente!");
    }

    public override void MostrarPagamento()
    {
        Console.WriteLine("--- Pagamento Pix ---");
        base.MostrarPagamento();
        Console.WriteLine($"Chave Pix: {ChavePix}");
        Console.WriteLine("Status: Aprovado");
    }
}

class PagamentoCartaoCredito : Pagamento
{
    public int QuantidadeParcelas { get; set; }
    public double ValorParcela { get; set; }

    public void ReceberDadosCartao()
    {
        ReceberDados();

        Console.Write("Quantidade de parcelas: ");
        QuantidadeParcelas = int.Parse(Console.ReadLine());

        if (QuantidadeParcelas <= 0)
        {
            QuantidadeParcelas = 1;
        }
    }

    public override void ProcessarPagamento()
    {
        ValorParcela = Valor / QuantidadeParcelas;
        Console.WriteLine("Pagamento aprovado no cartão de crédito!");
    }

    public override void MostrarPagamento()
    {
        Console.WriteLine("--- Pagamento Cartão de Crédito ---");
        base.MostrarPagamento();
        Console.WriteLine($"Parcelas: {QuantidadeParcelas}x");
        Console.WriteLine($"Valor da parcela: R$ {ValorParcela:F2}");
    }
}
