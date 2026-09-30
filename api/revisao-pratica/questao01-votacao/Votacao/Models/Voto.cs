using System.ComponentModel.DataAnnotations;

namespace Votacao.Models;

public class Voto
{
    [Required(ErrorMessage = "O RA do aluno é obrigatório.")]
    public string RaAluno { get; set; } = string.Empty;

    // Preenchida pela própria API no momento em que o voto é registrado.
    public DateTime DataVoto { get; set; }

    [Required(ErrorMessage = "O número do candidato é obrigatório.")]
    [Range(10, 99, ErrorMessage = "O número do candidato deve estar entre 10 e 99.")]
    public int? NumeroCandidato { get; set; }
}
