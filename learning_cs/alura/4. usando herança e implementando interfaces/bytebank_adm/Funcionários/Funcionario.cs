namespace bytebank_adm.Funcionários;

public abstract class Funcionario
{
    public string Nome { get; set; }
    public string CPF { get; private set; }
    public double Salario { get; protected set; }
    public static int TotalDeFuncionarios { get; private set; }

    public abstract double GetBonificacao();

    public abstract double PremioSemestral();

    public Funcionario(string cpf, double salario)
    {
        this.Salario = salario;
        this.CPF = CPF;
        TotalDeFuncionarios++;
        //Console.WriteLine("Criando funcionário");
    }

    public virtual void AumentarSalario()
    {
        this.Salario *= 1.10;
    }
}