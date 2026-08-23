using System.ComponentModel.DataAnnotations;

namespace ApiAula.Models;

public class Produto
{
    [Required(ErrorMessage = "O nome do produto é obrigatório.")]
    [StringLength(120, MinimumLength = 2)]
    public string NomeProduto { get; set; } = string.Empty;

    [Range(0.01f, 1000f, ErrorMessage = "O peso deve ser maior que zero.")]
    public float Peso { get; set; }

    [Range(0.1f, 500f, ErrorMessage = "A altura deve ser maior que zero.")]
    public float Altura { get; set; }

    [Range(0.1f, 500f, ErrorMessage = "A largura deve ser maior que zero.")]
    public float Largura { get; set; }

    [Range(0.1f, 500f, ErrorMessage = "O comprimento deve ser maior que zero.")]
    public float Comprimento { get; set; }

    [Required(ErrorMessage = "A UF é obrigatória.")]
    [StringLength(2, MinimumLength = 2, ErrorMessage = "A UF deve ter exatamente 2 caracteres.")]
    [RegularExpression("^[A-Za-z]{2}$", ErrorMessage = "A UF deve conter apenas letras. Ex.: MG")]
    public string Uf { get; set; } = string.Empty;
}

public class FreteResultado
{
    public string NomeProduto { get; set; } = string.Empty;
    public string Uf { get; set; } = string.Empty;
    public float Peso { get; set; }
    public double Volume { get; set; }
    public decimal TaxaPorCm3 { get; set; }
    public decimal ValorPorVolume { get; set; }
    public decimal TaxaEstado { get; set; }
    public decimal ValorFrete { get; set; }
    public string Detalhamento { get; set; } = string.Empty;
}