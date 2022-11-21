using bytebank;

ContaCorrente contaAndre = new ContaCorrente();
contaAndre.titular = "André Silva";
contaAndre.numeroAgencia = 15;
contaAndre.conta = "1010-X";
contaAndre.saldo = 100;

Console.WriteLine("Saldo da conta do André = " + contaAndre.saldo);

ContaCorrente contaMaria = new ContaCorrente();
contaMaria.titular = "Maria Souza";
contaMaria.numeroAgencia = 17;
contaMaria.conta = "1010-";
contaMaria.saldo = 350;

Console.WriteLine("Saldo da conta da Maria = " + contaMaria.saldo);

contaAndre.Transferir(50, contaMaria);
Console.WriteLine("Saldo do André = "+ contaAndre.saldo);
Console.WriteLine("Saldo da Maria = " + contaMaria.saldo);

