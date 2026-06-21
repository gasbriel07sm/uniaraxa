decimal valorCompra = 100.00m;

IDesconto descontoComum = new DescontoClienteComum();
IDesconto descontoVip = new DescontoClienteVip();

Console.WriteLine($"Valor original da compra: R$ {valorCompra:F2}");
Console.WriteLine();

Console.WriteLine($"Cliente Comum (5%):  R$ {descontoComum.Calcular(valorCompra):F2}");
Console.WriteLine($"Cliente VIP (10%):   R$ {descontoVip.Calcular(valorCompra):F2}");

interface IDesconto
{
    decimal Calcular(decimal valor);
}

class DescontoClienteComum : IDesconto
{
    public decimal Calcular(decimal valor)
    {

        return valor - (valor * 0.05m);
    }
}

class DescontoClienteVip : IDesconto
{
    public decimal Calcular(decimal valor)
    {

        return valor - (valor * 0.10m);
    }
}
