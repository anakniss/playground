using bytebank_adm.Funcionários;

namespace bytebank_ADM.Sistema_Interno;

public interface IAutenticavel
{
  public string Senha { get; set; }

  public abstract bool Autenticar(string senha);
}