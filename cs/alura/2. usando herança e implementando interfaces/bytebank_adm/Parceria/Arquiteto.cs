using bytebank_ADM.Sistema_Interno;

namespace bytebank_ADM.Parceria;

public class Arquiteto : PrestadorServicos, IAutenticavel
{
    public string Senha { get; set; }
    public override double GetBonificacao()
    {
        return 1000;
    }
    public bool Autenticar(string senha)
    {
        return Senha == senha;
    }
}