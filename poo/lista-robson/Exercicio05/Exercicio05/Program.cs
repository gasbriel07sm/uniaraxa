using Exercicio05;

Hospede hospede = new Hospede();
hospede.receberDados();
hospede.atualizarTelefone("123456789");
hospede.exibirDados();

Reserva reserva = new Reserva();
reserva.receberDadosReserva();
reserva.calcularTotal();
reserva.aplicarDesconto(10);
reserva.mostrarReserva();