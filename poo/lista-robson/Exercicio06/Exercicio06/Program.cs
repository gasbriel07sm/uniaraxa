using Exercicio06;

Cliente cliente = new Cliente();
cliente.Nome = "Maria Silva";
cliente.Cpf = "123.456.789-00";
cliente.Cidade = "Araxá";

Vendedor vendedor = new Vendedor();
vendedor.Nome = "Robinson";
vendedor.PercentualComissao = 10;

Produto produto = new Produto();
produto.Descricao = "Notebook";
produto.PrecoUnitario = 2500.00;
produto.Quantidade = 2;

Pagamento pagamento = new Pagamento();
pagamento.FormaPagamento = "Cartão de crédito";
pagamento.Parcelas = 3;

Entrega entrega = new Entrega();
entrega.Endereco = "Rua das Flores, 100";
entrega.DistanciaKm = 8;
entrega.TipoEntrega = "Entrega rápida";

Pedido pedido = new Pedido(1);
pedido.Cliente = cliente;
pedido.Vendedor = vendedor;
pedido.Produto = produto;
pedido.Pagamento = pagamento;
pedido.Entrega = entrega;

pedido.ExibirResumo();