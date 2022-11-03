using System;

class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando o projeto 5 - Caracteres e Textos");

        char letra = 'a';
        Console.WriteLine(letra);

        letra = (char)65;  //Na tabela ASCII, o número 65 corresponde a letra A (maiúscula)
        Console.WriteLine(letra);

        letra = (char)(65 + 1);
        Console.WriteLine(letra);

        string primeiraFrase = "Alura - Cursos de Tecnologia ";
        Console.WriteLine(primeiraFrase + 2022); //Concatenação

        string vazia = "";
        Console.WriteLine(vazia);

        letra = ' '; //Não é possível deixar um char vazio

        //O "@" permite a formatação conforme digitado no código
        string cursos = @"Cursos Disponíveis: 
        - GO 
        - C# 
        - Python
        - Java";
        Console.WriteLine(cursos);
    }
}