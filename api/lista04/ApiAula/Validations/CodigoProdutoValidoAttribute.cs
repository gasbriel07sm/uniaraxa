using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace ApiAula.Validations;

public class CodigoProdutoValidoAttribute : ValidationAttribute
{
    private static readonly Regex _formato = new(@"^[A-Z]{3}-\d{4}$", RegexOptions.Compiled);

    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        if (value is null || string.IsNullOrWhiteSpace(value.ToString()))
            return ValidationResult.Success;

        var codigo = value.ToString()!;

        if (!_formato.IsMatch(codigo))
        {
            return new ValidationResult(
                "O código do produto deve seguir o formato 'AAA-1234': 3 letras maiúsculas, um hífen e 4 números (exatamente 8 caracteres). Ex.: ABC-1234.",
                new[] { validationContext.MemberName ?? nameof(codigo) });
        }

        return ValidationResult.Success;
    }
}
