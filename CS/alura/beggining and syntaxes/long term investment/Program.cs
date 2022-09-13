using System;

public class Program
{
    public static void Main(string [] args)
    {     
        Console.WriteLine("Executando Projeto 12 - Investimento a Longo Prazo");

        double fatorRendimento = 1.005;
        double investimento = 1000;

        for (int anos = 1; anos <= 5; anos++)
        {
            for (int mes = 1; mes <= 12; mes++)
            {
                investimento *= fatorRendimento; //investimento = investimento * fatorRendimento
            }
            fatorRendimento = fatorRendimento + 0.001; //fatorRendimento += 0.001
        }
        
        Console.WriteLine("Depois de 5 anos você terá R$" + investimento);

    }
}