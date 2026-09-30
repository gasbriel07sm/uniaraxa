using FeiraProjetos.Repositories;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddOpenApi();

// Injeção de Dependência: os repositórios guardam os dados em listas em memória,
// por isso são registrados como Singleton (uma única instância durante toda a execução).
builder.Services.AddSingleton<IProjetoRepository, ProjetoRepository>();
builder.Services.AddSingleton<IVisitaRepository, VisitaRepository>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
