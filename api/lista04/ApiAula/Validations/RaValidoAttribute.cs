using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace ApiAula.Validations;

public class RaValidoAttribute : ValidationAttribute
{

    private static readonly Regex _formato = new(@"^RA\d{6}$", RegexOptions.Compiled);

    protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
    {
        if (value is null || string.IsNullOrWhiteSpace(value.ToString()))
            return ValidationResult.Success;

        var ra = value.ToString()!;

        if (!_formato.IsMatch(ra))
        {
            return new ValidationResult(
                "O RA deve começar com as letras 'RA' seguidas de exatamente 6 dígitos (0 a 9). Ex.: RA123456.",
                new[] { validationContext.MemberName ?? nameof(ra) });
        }

        return ValidationResult.Success;
    }
}
