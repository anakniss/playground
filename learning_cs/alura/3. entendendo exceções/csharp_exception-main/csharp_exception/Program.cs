using ByteBank;
using csharp_exception;
using csharp_exception.Titular;
using csharp_exception.Contas;

LeitorArquivo leitor = new LeitorArquivo("contas.txt");

try
{
    leitor.LerProximaLinha();
    leitor.LerProximaLinha();
    leitor.Dispose();
}
catch (IOException)
{
    Console.WriteLine("Leitura de arquivo interrompida");
}

finally
{
    leitor.Dispose();
}

// try
// {
//     ContaCorrente conta1 = new ContaCorrente(278, "1234-X");
//     conta1.Sacar(50);
//     Console.WriteLine(conta1.GetSaldo());
//     conta1.Sacar(150);
//     Console.WriteLine(conta1.GetSaldo());
// }
// catch (ArgumentException ex)
// {
//     Console.WriteLine("Parâmetro com erro" + ex.ParamName);
//     Console.WriteLine("Não é possível criar uma conta com o número de agência menor ou igual a zero!");
//     Console.WriteLine(ex.Message);
//
// }
//
// catch (SaldoInsuficienteException ex)
// {
//     Console.WriteLine("Operação negada! Saldo insuficiente!");
//     Console.Write(ex.Message);
// }

