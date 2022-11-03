using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando projeto 7 - Condicionais");

        int idadeJoao = 16;
        int quantidadePessos = 2;

        if (idadeJoao >= 18)
        {
            Console.WriteLine("Pode entrar!");
        }
        else
        {
            if (quantidadePessos > 0)
            {
                Console.WriteLine("Ele está acompanhado. Pode entrar!");
            }
            else
            {
                Console.WriteLine("Não pode entrar!");
            }
        }
    }
}