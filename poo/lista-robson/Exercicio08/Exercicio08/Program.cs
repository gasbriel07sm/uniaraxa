using Exercicio08;

ReservaHotel r1 = new ReservaHotel("Carlos", 12);
ReservaHotel r2 = new ReservaHotel("", -8, 0, -300);

r1.ExibirReserva();
r2.ExibirReserva();

Console.WriteLine($"Total r1: R$ {r1.CalcularTotal():F2}");
Console.WriteLine($"Total r2: R$ {r2.CalcularTotal():F2}");

r1.AdicionarDiarias(2);
r1.ExibirReserva();

r2.CancelarReserva();
r2.ExibirReserva();

r2.ReativarReserva();
r2.ExibirReserva();