using bytebank_ADM.Sistema_Interno;

namespace bytebank_adm.Funcionários;

public class Diretor : FuncionarioAutenticavel
{
    public static int TotalDeDiretores { get; private set; }
    public override double GetBonificacao()
    {
        return this.Salario * 0.17;
    }

    public override double PremioSemestral()
    {
        return Salario + this.Salario * 1.2;
    }

    public Diretor(string cpf) : base(cpf, 5000)
    {
        TotalDeDiretores++;
    }
    public override void AumentarSalario()
    {
        this.Salario *= 1.15;
    }
}