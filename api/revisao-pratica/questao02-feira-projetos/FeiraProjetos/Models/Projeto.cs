using System.ComponentModel.DataAnnotations;

namespace FeiraProjetos.Models;

public class Projeto
{
    [Required(ErrorMessage = "O nome do projeto é obrigatório.")]
    [StringLength(50, MinimumLength = 3, ErrorMessage = "O nome do projeto deve ter entre 3 e 50 caracteres.")]
    public string Nome { get; set; } = string.Empty;

    [Required(ErrorMessage = "O e-mail é obrigatório.")]
    [EmailAddress(ErrorMessage = "Informe um e-mail em formato válido. Ex.: grupo@email.com")]
    public string Email { get; set; } = string.Empty;

    [Required(ErrorMessage = "A turma é obrigatória.")]
    [Range(1, 8, ErrorMessage = "A turma deve ser um número entre 1 e 8.")]
    public int? Turma { get; set; }

    [Required(ErrorMessage = "A descrição do projeto é obrigatória.")]
    [StringLength(500, ErrorMessage = "A descrição do projeto deve ter no máximo 500 caracteres.")]
    public string Descricao { get; set; } = string.Empty;

    [Required(ErrorMessage = "O número do projeto é obrigatório.")]
    [Range(10, 99, ErrorMessage = "O número do projeto deve estar entre 10 e 99.")]
    public int? Numero { get; set; }
}
