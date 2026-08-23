using ApiAula.Models;
using ApiAula.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApiAula.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PessoaController : ControllerBase
{
    [HttpPost("calcular-imc")]
    [ProducesResponseType(typeof(ImcResultado), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult CalcularImc([FromBody] Pessoa pessoa)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        double imc = Math.Round(ImcService.Calcular(pessoa.Peso, pessoa.Altura), 2);

        var resultado = new ImcResultado
        {
            Nome = pessoa.Nome,
            Peso = pessoa.Peso,
            Altura = pessoa.Altura,
            Imc = imc,
            Classificacao = ImcService.ObterClassificacao(imc),
            Risco = ImcService.ObterRisco(imc)
        };

        return Ok(resultado);
    }

    [HttpGet("consulta-tabela-imc")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult ConsultaTabelaImc([FromQuery] double imc)
    {
        if (imc <= 0 || imc > 100)
            return BadRequest(new { mensagem = "Informe um IMC válido (maior que 0 e menor que 100)." });

        return Ok(new
        {
            imc,
            classificacao = ImcService.ObterClassificacao(imc),
            risco = ImcService.ObterRisco(imc)
        });
    }

    [HttpGet("tabela-imc")]
    public IActionResult TabelaImc()
    {
        var tabela = new[]
        {
            new { faixa = "Abaixo de 16",   classificacao = "Magreza grave" },
            new { faixa = "16 a 16,9",      classificacao = "Magreza moderada" },
            new { faixa = "17 a 18,4",      classificacao = "Magreza leve" },
            new { faixa = "18,5 a 24,9",    classificacao = "Peso normal (eutrofia)" },
            new { faixa = "25 a 29,9",      classificacao = "Sobrepeso" },
            new { faixa = "30 a 34,9",      classificacao = "Obesidade grau I" },
            new { faixa = "35 a 39,9",      classificacao = "Obesidade grau II" },
            new { faixa = "40 ou mais",     classificacao = "Obesidade grau III (mórbida)" }
        };

        return Ok(tabela);
    }
}