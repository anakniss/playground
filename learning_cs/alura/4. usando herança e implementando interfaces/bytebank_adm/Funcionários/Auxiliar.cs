namespace bytebank_adm.Funcionários;

public class Auxiliar : Funcionario
{
    public Auxiliar(string cpf) : base(cpf, 2000)
    {
        
    }
    public override double GetBonificacao()
    {
        return this.Salario * 0.2;
    }

    public override void AumentarSalario()
    {
        this.Salario *= 1.1;
    }

    public override double PremioSemestral()
    {
        return this.Salario * 0.20;
    }
}