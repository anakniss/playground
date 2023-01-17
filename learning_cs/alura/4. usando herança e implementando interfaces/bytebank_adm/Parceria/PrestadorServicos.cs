using bytebank_ADM.Sistema_Interno;

namespace bytebank_ADM.Parceria;

public abstract class PrestadorServicos : IBonificavel
{
    public string CNPJ { get; set; }
    public abstract double GetBonificacao();
}
