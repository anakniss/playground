namespace bytebank_adm.Funcionários;

public class Designer : Funcionario
{
    public Designer(string cpf) : base(cpf, 3000)
    {
        
    }
    public override double GetBonificacao()
    {
        return this.Salario * 0.17;
    }

    public override void AumentarSalario()
    {
        this.Salario *= 1.11;
    }
    
    public override double PremioSemestral()
    {
        return this.Salario * 0.20;
    }
}