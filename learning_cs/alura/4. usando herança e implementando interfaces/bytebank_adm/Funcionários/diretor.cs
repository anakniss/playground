namespace bytebank_adm.Funcionários;

public class Diretor : Funcionario
{
    public static int TotalDeDiretores { get; private set; }
    public double GetBonificacao()
    {
        return this.Salario + base.GetBonificacao();
    }

    public override double PremioSemestral()
    {
        return Salario + this.Salario * 1.2;
    }

    public Diretor(string cpf, double salario) : base(cpf, salario)
    {
        TotalDeDiretores++;
        Console.WriteLine("Criando um diretor");
    }
    public override void AumentarSalario()
    {
        this.Salario *= 1.15;
    }
    
}