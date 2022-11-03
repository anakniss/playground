using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orientação_a_Objetos
{
    public class Usuario
    {
        public string Email;
        public string Senha;
        public string Nome;

        public void Logar()
        {
            Console.WriteLine("O usuário logou");
        }

    }
}
