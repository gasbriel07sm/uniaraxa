using ApiAula.Models;
using Microsoft.AspNetCore.Mvc;

namespace ApiAula.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProdutoController : ControllerBase
{
    private static readonly List<Produto> _produtos = new();

    // a. Adicionar um produto
    [HttpPost]
    [ProducesResponseType(typeof(Produto), StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status409Conflict)]
    public IActionResult Adicionar([FromBody] Produto produto)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        bool jaExiste = _produtos.Any(p => p.CodigoProduto == produto.CodigoProduto);
        if (jaExiste)
            return Conflict(new { mensagem = $"Já existe um produto cadastrado com o código {produto.CodigoProduto}." });

        _produtos.Add(produto);

        return CreatedAtAction(nameof(BuscarPorCodigo), new { codigo = produto.CodigoProduto }, produto);
    }

    // b. Atualizar os dados de um produto 
    [HttpPut("{codigo}")]
    [ProducesResponseType(typeof(Produto), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IActionResult Atualizar(string codigo, [FromBody] Produto produto)
    {
        if (!ModelState.IsValid)
            return BadRequest(ModelState);

        var existente = _produtos.FirstOrDefault(p => p.CodigoProduto == codigo);
        if (existente is null)
            return NotFound(new { mensagem = $"Nenhum produto encontrado com o código {codigo}." });

        existente.Descricao = produto.Descricao;
        existente.Preco = produto.Preco;
        existente.Estoque = produto.Estoque;

        return Ok(existente);
    }

    // c. Remover um produto pelo código
    [HttpDelete("{codigo}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IActionResult Remover(string codigo)
    {
        var existente = _produtos.FirstOrDefault(p => p.CodigoProduto == codigo);
        if (existente is null)
            return NotFound(new { mensagem = $"Nenhum produto encontrado com o código {codigo}." });

        _produtos.Remove(existente);
        return NoContent();
    }

    // d. Buscar todos os produtos
    [HttpGet]
    [ProducesResponseType(typeof(IEnumerable<Produto>), StatusCodes.Status200OK)]
    public IActionResult BuscarTodos()
    {
        return Ok(_produtos);
    }

    // e. Buscar um produto específico informando o código
    [HttpGet("{codigo}")]
    [ProducesResponseType(typeof(Produto), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public IActionResult BuscarPorCodigo(string codigo)
    {
        var produto = _produtos.FirstOrDefault(p => p.CodigoProduto == codigo);
        if (produto is null)
            return NotFound(new { mensagem = $"Nenhum produto encontrado com o código {codigo}." });

        return Ok(produto);
    }

    // f. Buscar apenas os produtos que ainda têm estoque disponível
    [HttpGet("em-estoque")]
    [ProducesResponseType(typeof(IEnumerable<Produto>), StatusCodes.Status200OK)]
    public IActionResult BuscarEmEstoque()
    {
        var comEstoque = _produtos.Where(p => p.Estoque > 0).ToList();
        return Ok(comEstoque);
    }

    // g. Buscar produtos por descrição (contém o texto informado, sem diferenciar maiúsc./minúsc.)
    [HttpGet("buscar-por-descricao")]
    [ProducesResponseType(typeof(IEnumerable<Produto>), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    public IActionResult BuscarPorDescricao([FromQuery] string descricao)
    {
        if (string.IsNullOrWhiteSpace(descricao))
            return BadRequest(new { mensagem = "Informe uma descrição para a busca." });

        var produtos = _produtos
            .Where(p => p.Descricao.Contains(descricao, StringComparison.OrdinalIgnoreCase))
            .ToList();

        return Ok(produtos);
    }
}
