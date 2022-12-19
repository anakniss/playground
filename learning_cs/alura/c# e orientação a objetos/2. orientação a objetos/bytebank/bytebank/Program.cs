using bytebank.Contas;
using bytebank.Titular;

// ContaCorrente contaAndre = new ContaCorrente();
// contaAndre.titular = "André Silva";
// contaAndre.numeroAgencia = 15;
// contaAndre.conta = "1010-X";
// contaAndre.saldo = 100;
//
// Console.WriteLine("Saldo da conta do André = " + contaAndre.saldo);
//
// ContaCorrente contaMaria = new ContaCorrente();
// contaMaria.titular = "Maria Souza";
// contaMaria.numeroAgencia = 17;
// contaMaria.conta = "1010-";
// contaMaria.saldo = 350;
//
// Console.WriteLine("Saldo da conta da Maria = " + contaMaria.saldo);
//
// contaAndre.Transferir(50, contaMaria);
// Console.WriteLine("Saldo do André = "+ contaAndre.saldo);
// Console.WriteLine("Saldo da Maria = " + contaMaria.saldo);
//
// ContaCorrente contaDoPedro = new ContaCorrente();
// contaDoPedro.titular = "Pedro Silva";
// Console.WriteLine(contaDoPedro.titular);
// Console.WriteLine(contaDoPedro.conta);
// Console.WriteLine(contaDoPedro.numeroAgencia);
// Console.WriteLine(contaDoPedro.saldo);

// Cliente cliente = new Cliente();
// cliente.nome = "André Silva";
// cliente.cpf = "123456";
// cliente.profissao = "Analista";
//
// ContaCorrente conta = new ContaCorrente();
// conta.titular = cliente;
// conta.conta = "1010-X";
// conta.numeroAgencia = 15;
// conta.saldo = 100;
//
// Console.WriteLine("Titular = " + conta.titular.nome);
// Console.WriteLine("CPF = " + conta.titular.cpf);
// Console.WriteLine("Profissão = " + conta.titular.profissao);
// Console.WriteLine("Número da Conta = " + conta.conta);
// Console.WriteLine("Saldo = " + conta.saldo);
// Console.WriteLine("Número da Agência = " + conta.numeroAgencia);

// ContaCorrente conta3 = new ContaCorrente();
// conta3.NumeroAgencia = 18;
// conta3.Conta = "1011-H";
// conta3.SetSaldo(200);
// Console.WriteLine(conta3.GetSaldo());
// Console.WriteLine(conta3.NumeroAgencia);
// Console.WriteLine(conta3.Conta);

// ContaCorrente conta4 = new ContaCorrente(18, "1010-X");
// conta4.SetSaldo(500);
// conta4.Titular = new Cliente();
// Console.WriteLine(conta4.GetSaldo());
// Console.WriteLine(conta4.NumeroAgencia);

ContaCorrente conta5 = new ContaCorrente(282, "1234-X");
Console.WriteLine(ContaCorrente.TotalContasCriadas);

ContaCorrente conta6 = new ContaCorrente(284, "9874-Z");
Console.WriteLine(ContaCorrente.TotalContasCriadas);

ContaCorrente conta7 = new ContaCorrente(214, "9544-Z");
Console.WriteLine(ContaCorrente.TotalContasCriadas);

