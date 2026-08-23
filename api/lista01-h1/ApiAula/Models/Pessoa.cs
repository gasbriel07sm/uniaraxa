using System.ComponentModel.DataAnnotations;

namespace ApiAula.Models;
public class Pessoa
{
    [Required(ErrorMessage = "O nome é obrigatório.")]
    [StringLength(100, MinimumLength = 2, ErrorMessage = "O nome deve ter entre 2 e 100 caracteres.")]
    public string Nome { get; set; } = string.Empty;

    [Required(ErrorMessage = "O peso é obrigatório.")]
    [Range(1, 500, ErrorMessage = "O peso deve estar entre 1 e 500 kg.")]
    public double Peso { get; set; }

    [Required(ErrorMessage = "A altura é obrigatória.")]
    [Range(0.5, 2.7, ErrorMessage = "A altura deve estar em metros (entre 0,5 e 2,7).")]
    public double Altura { get; set; }
}