namespace ApiAula.Services;

public static class ImcService
{
    public static double Calcular(double peso, double alturaEmMetros)
    {
        return peso / (alturaEmMetros * alturaEmMetros);
    }

    public static string ObterClassificacao(double imc) => imc switch
    {
        < 16.0  => "Magreza grave",
        < 17.0  => "Magreza moderada",
        < 18.5  => "Magreza leve",
        < 25.0  => "Peso normal (eutrofia)",
        < 30.0  => "Sobrepeso",
        < 35.0  => "Obesidade grau I",
        < 40.0  => "Obesidade grau II",
        _       => "Obesidade grau III (mórbida)"
    };

    public static string ObterRisco(double imc) => imc switch
    {
        < 18.5 => "Risco aumentado por desnutrição",
        < 25.0 => "Risco baixo",
        < 30.0 => "Risco moderado",
        < 35.0 => "Risco alto",
        < 40.0 => "Risco muito alto",
        _      => "Risco extremamente alto"
    };
}