using ApiAula.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiAula.Controllers;

[ApiController]
[Route("api/[controller]")]
public class FreteController : ControllerBase
{
    private const decimal TaxaPorCm3 = 0.01m;

    private static readonly Dictionary<string, decimal> TarifasPorEstado = new(StringComparer.OrdinalIgnoreCase)
    {
        { "SP", 50.00m },
        { "RJ", 60.00m },
        { "MG", 55.00m }
    };

    private const decimal TarifaPadrao = 70.00m; // demais estados


    [HttpPost("calcular")]
    [ProducesResponseType(typeof(FreteResultado), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult Calcular([FromBody] Produto produto)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        string uf = produto.Uf.Trim().ToUpperInvariant();

        double volume = (double)produto.Altura * produto.Largura * produto.Comprimento;

        decimal taxaEstado = TarifasPorEstado.TryGetValue(uf, out var tarifa)
            ? tarifa
            : TarifaPadrao;

        decimal valorPorVolume = Math.Round((decimal)volume * TaxaPorCm3, 2);

        decimal valorFrete = Math.Round(valorPorVolume + taxaEstado, 2);

        var resultado = new FreteResultado
        {
            NomeProduto = produto.NomeProduto,
            Uf = uf,
            Peso = produto.Peso,
            Volume = Math.Round(volume, 2),
            TaxaPorCm3 = TaxaPorCm3,
            ValorPorVolume = valorPorVolume,
            TaxaEstado = taxaEstado,
            ValorFrete = valorFrete,
            Detalhamento = $"({Math.Round(volume, 2)} cm³ x {TaxaPorCm3:C}) + {taxaEstado:C} = {valorFrete:C}"
        };

        return Ok(resultado);
    }

    [HttpGet("tarifas")]
    public IActionResult Tarifas()
    {
        return Ok(new
        {
            taxaPorCm3 = TaxaPorCm3,
            tarifasPorEstado = TarifasPorEstado,
            tarifaOutrosEstados = TarifaPadrao
        });
    }
}