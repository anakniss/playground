using bytebank_adm.Funcionários;

namespace bytebank_ADM.Sistema_Interno;

public abstract class Autenticavel : Funcionario
{
  public string Senha { get; set; }

  public abstract bool Autenticar(string senha);
  public Autenticavel(string cpf, double salario) : base(cpf, salario)
  {
  }
}