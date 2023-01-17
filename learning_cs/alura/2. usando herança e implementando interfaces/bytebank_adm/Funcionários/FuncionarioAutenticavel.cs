using bytebank_ADM.Sistema_Interno;

namespace bytebank_adm.Funcionários;

public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
{
    public string Senha { get; set; }
    public bool Autenticar(string senha)
    {
        return this.Senha == senha;
    }

    protected FuncionarioAutenticavel(string cpf, double salario) : base(cpf, salario)
    {
        
    }
}