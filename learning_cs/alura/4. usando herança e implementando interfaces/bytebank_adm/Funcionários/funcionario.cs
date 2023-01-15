namespace bytebank_adm.Funcionários;

public class Funcionario
{
    public string Nome { get; set; }
    public string CPF { get; set; }
    public double Salario { get; set; }
    public static int TotalDeFuncionarios { get; private set; }

    public double GetBonificacao()
    {
        return this.Salario * 0.10;
    }

    public virtual double PremioSemestral()
    {
        return this.Salario * 0.20;
    }

    public Funcionario()
    {
        TotalDeFuncionarios++;
    }
}