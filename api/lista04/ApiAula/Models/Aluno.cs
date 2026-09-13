using System.ComponentModel.DataAnnotations;
using ApiAula.Validations;

namespace ApiAula.Models;

// Questão 4 - Validações da classe Aluno (Nome, Ra, Email, Cpf, Ativo).
public class Aluno
{
    [Required(ErrorMessage = "O nome é obrigatório.")]
    [StringLength(100, MinimumLength = 3, ErrorMessage = "O nome deve ter entre 3 e 100 caracteres.")]
    public string Nome { get; set; } = string.Empty;

    // Validação customizada: começa com "RA" + 6 dígitos (0 a 9). Ex.: RA123456
    [Required(ErrorMessage = "O RA é obrigatório.")]
    [RaValido]
    public string Ra { get; set; } = string.Empty;

    [Required(ErrorMessage = "O e-mail é obrigatório.")]
    [EmailAddress(ErrorMessage = "Informe um e-mail em formato válido. Ex.: aluno@email.com")]
    public string Email { get; set; } = string.Empty;

    [Required(ErrorMessage = "O CPF é obrigatório.")]
    [RegularExpression(@"\d{11}", ErrorMessage = "O CPF deve conter exatamente 11 dígitos numéricos (somente números).")]
    public string Cpf { get; set; } = string.Empty;

    // Indica se o aluno está ativo. Como é bool, o valor padrão é "false".
    public bool Ativo { get; set; }
}
