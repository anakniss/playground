using System.Threading.Channels;
using bytebank_adm.Funcionários;

namespace bytebank_ADM.Sistema_Interno;

public class SistemaInterno
{
    public bool Logar(Diretor funcionario, string senha)
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
    
    public bool Logar(Autenticavel funcionario, string senha)
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