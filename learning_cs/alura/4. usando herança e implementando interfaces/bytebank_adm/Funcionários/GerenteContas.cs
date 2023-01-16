using bytebank_ADM.Sistema_Interno;

namespace bytebank_adm.Funcionários;

public class GerenteContas : Autenticavel
{
    public GerenteContas(string cpf) : base(cpf, 4000)
    {
        
    }
    public override double GetBonificacao()
    {
        return this.Salario * 0.25;
    }

    public override void AumentarSalario()
    {
        this.Salario *= 1.05;
    }
    
    public override double PremioSemestral()
    {
        return this.Salario * 0.20;
    }
    
    public override bool Autenticar(string senha)
    {
        return this.Senha == senha;
    }
}