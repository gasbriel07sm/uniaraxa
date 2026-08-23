namespace ApiAula.Models;

public class ImcResultado
{
    public string Nome { get; set; } = string.Empty;
    public double Peso { get; set; }
    public double Altura { get; set; }
    public double Imc { get; set; }
    public string Classificacao { get; set; } = string.Empty;
    public string Risco { get; set; } = string.Empty;
}