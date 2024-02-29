namespace csharp_exception;

public class SaldoInsuficienteException : OperacaoFinanceiraException
{
    public SaldoInsuficienteException(string mensagem) : base(mensagem)
    {
        
    }
}