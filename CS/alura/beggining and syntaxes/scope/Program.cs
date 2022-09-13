using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando projeto 7 - Condicionais");

        int idadeJoao = 16;
        int quantidadePessoas = 2;

        bool acompanhado = quantidadePessoas > 1;

        // string textoAdicional;
       //Quando tipado o valor de uma variável dentro de um escopo, ela será válida apenas dentro dele 
        if (acompanhado == true)
        {
            string textoAdicional = "João está acompanhado"; 
        }
        else
        {
            string textoAdicional = "João não está acompanhado";
        }

        if (idadeJoao >= 18 || quantidadePessoas > 1) 
        {
            Console.WriteLine("Pode entrar!");
        }
        else
        {
            Console.WriteLine("Não pode entrar!");
        }
    }
}