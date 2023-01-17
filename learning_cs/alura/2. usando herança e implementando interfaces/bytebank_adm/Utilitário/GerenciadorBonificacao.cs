namespace bytebank_adm.Funcionários.Utilitário;

public class GerenciadorBonificacao
{
    public double TotalBonificacao { get; private set; }

    public void Registrar(Funcionario funcionario)
    {
        this.TotalBonificacao += funcionario.GetBonificacao();
    }
    
    public void Registrar(Diretor diretor)
    {
        this.TotalBonificacao += diretor.GetBonificacao();
    }

    public double GetBonificacao()
    {
        return this.TotalBonificacao;
    }
}
