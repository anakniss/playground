using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando Projeto 10 - Calcula Poupança");

        double investimento = 1000;
        
        //redimento de 0.5% (0.005) ao mês

        //int mes = 1;
    
        /*
        while (mes <= 12)
        {
            investimento = investimento + investimento * 0.005;
            Console.WriteLine("No mês " + mes + " você tem R$" + investimento);

            mes = mes + 1;
        }
        */

        for (int mes = 1; mes <= 12; mes = mes++)
        {
            investimento = investimento + investimento * 0.005;
            Console.WriteLine("No mês " + mes + " você tem R$" + investimento);
        }
    }
}