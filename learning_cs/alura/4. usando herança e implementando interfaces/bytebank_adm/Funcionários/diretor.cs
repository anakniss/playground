namespace bytebank_adm.Funcionários;

public class Diretor : Funcionario
{
    public double GetBonificacao()
    {
        return this.Salario + base.GetBonificacao();
    }

    public override double PremioSemestral()
    {
        return Salario + this.Salario * 1.2;
    }
}