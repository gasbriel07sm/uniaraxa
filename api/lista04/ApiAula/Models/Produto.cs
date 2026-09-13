using System.ComponentModel.DataAnnotations;
using ApiAula.Validations;

namespace ApiAula.Models;

// Questão 5 - Validações da classe Produto (Descrição, preço, estoque e codigoProduto).
public class Produto
{
    [Required(ErrorMessage = "A descrição é obrigatória.")]
    [StringLength(200, MinimumLength = 3, ErrorMessage = "A descrição deve ter entre 3 e 200 caracteres.")]
    public string Descricao { get; set; } = string.Empty;

    [Required(ErrorMessage = "O preço é obrigatório.")]
    [Range(0.01, 1_000_000, ErrorMessage = "O preço deve ser maior que zero.")]
    public decimal Preco { get; set; }

    [Required(ErrorMessage = "O estoque é obrigatório.")]
    [Range(0, int.MaxValue, ErrorMessage = "O estoque não pode ser negativo.")]
    public int Estoque { get; set; }

    // Validação customizada: formato "AAA-1234" (3 letras maiúsculas, hífen e 4 números).
    [Required(ErrorMessage = "O código do produto é obrigatório.")]
    [CodigoProdutoValido]
    public string CodigoProduto { get; set; } = string.Empty;
}
