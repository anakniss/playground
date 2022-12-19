using bytebank.Titular;

namespace bytebank.Contas;

public class ContaCorrente
{
    //A propriedade "static" permite que a contagem seja relacionada diretamente a classe e não ao objeto. Sendo assim, 
    //será contado o número total de contas criadas. O private no set significa que não podemos definir valores externamente.
    public static int TotalContasCriadas { get; private set; }
    private int numeroAgencia;

    public int NumeroAgencia
    {
        get { return this.numeroAgencia; }
        set
        {
            if (value > 0)
            {
                this.numeroAgencia = value;
            }
        }
    }
    public string Conta { get; set; }
    private double saldo = 100;

    public Cliente Titular  { get; set;}

    public void Depositar(double valor)
    {
        this.saldo += valor;
    }

    public bool Sacar(double valor)
    {
        if (valor <= saldo){
            this.saldo -= valor;

            return true;
        }

        else
        {
            return false;
        }
    }
    
    public bool Transferir(double valor, ContaCorrente destino)
    {
        if (this.saldo < valor)
        {
            return false;
        }
        else
        {
            this.Sacar(valor);
            destino.Depositar(valor);
            return true;
        }
    }

    public void SetSaldo(double valor)
    {
        if (valor < 0)
        {
            return;
        }
        else
        {
            saldo = saldo + valor;
        }

    }
    
    public double GetSaldo()
    {
        return this.saldo;
    }

    public ContaCorrente(int numeroAgencia, string numeroConta)
    {
        this.numeroAgencia = numeroAgencia;
        this.Conta = numeroConta;
        TotalContasCriadas++;
    }
}