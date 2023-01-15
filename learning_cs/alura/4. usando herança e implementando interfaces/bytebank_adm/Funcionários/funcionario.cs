namespace bytebank_adm.Funcionários;

public class Funcionario
{
    public string Nome { get; set; }
    public string CPF { get; private set; }
    public double Salario { get; protected set; }
    public static int TotalDeFuncionarios { get; private set; }

    public double GetBonificacao()
    {
        return this.Salario * 0.10;
    }

    public virtual double PremioSemestral()
    {
        return this.Salario * 0.20;
    }

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