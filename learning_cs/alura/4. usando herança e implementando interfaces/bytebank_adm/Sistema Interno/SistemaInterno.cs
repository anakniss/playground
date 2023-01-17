using System.Threading.Channels;
using bytebank_adm.Funcionários;
using bytebank_ADM.Parceria;

namespace bytebank_ADM.Sistema_Interno;

public class SistemaInterno
{
    public bool Logar(IAutenticavel funcionario, string senha)
    {
        bool usuarioAutenticado = funcionario.Autenticar(senha);
        if (usuarioAutenticado)
        {
            Console.WriteLine("Bem vindo ao nosso sistema");
            return true;
        }
        else
        {
            Console.WriteLine("Senha incorreta!");
            return false;
        }
    }
    public bool Logar(ParceiroComercial funcionario, string senha)
    {
        bool usuarioAutenticado = funcionario.Autenticar(senha);
        if (usuarioAutenticado)
        {
            Console.WriteLine("Bem vindo ao nosso sistema");
            return true;
        }
        else
        {
            Console.WriteLine("Senha incorreta!");
            return false;
        }
    }
    
}