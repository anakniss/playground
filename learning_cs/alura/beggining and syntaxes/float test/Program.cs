// See https://aka.ms/new-console-template for more information

using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Projeto 3 - Variáveis Ponto Flutuante");

        double salario = 1250.70;

        //Console.WriteLine("Meu salário é: " + salario);

        //int valor = 12.5;             // não compila.

        //int valor2 = 0.0;             // não compila.

        double teste = 125.50; // compila

        //int valor3 = teste;           // não compila.

        int divisao = 7 / 5; //Vale ressaltar que, quando fazemos uma divisão não exata (mas estamos dividindo
        //números inteiros), o C# sempre irá contar a parte decimal do resultado.

        Console.WriteLine(divisao);
    }

}