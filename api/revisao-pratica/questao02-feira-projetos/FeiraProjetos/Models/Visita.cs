using System.ComponentModel.DataAnnotations;

namespace FeiraProjetos.Models;

public class Visita
{
    [Required(ErrorMessage = "O RA do aluno é obrigatório.")]
    public string RaAluno { get; set; } = string.Empty;

    [Required(ErrorMessage = "A data da visita é obrigatória.")]
    public DateTime? DataVisita { get; set; }

    [Required(ErrorMessage = "O número do projeto é obrigatório.")]
    [Range(10, 99, ErrorMessage = "O número do projeto deve estar entre 10 e 99.")]
    public int? NumeroProjeto { get; set; }

    // Regra de negócio: nota mínima 0 e nota máxima 5.
    [Required(ErrorMessage = "A nota é obrigatória.")]
    [Range(0, 5, ErrorMessage = "A nota deve estar entre 0 e 5.")]
    public int? Nota { get; set; }
}
