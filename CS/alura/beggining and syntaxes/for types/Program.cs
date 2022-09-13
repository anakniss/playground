using System;

public class Program
{
    public static void Main(string [] args)
    {     
       Console.WriteLine("Projeto 13 - Encadeando For");
       
       //*
       //**
       //***
       //****
       //*****

       for (int contadorLinhas = 0; contadorLinhas < 10; contadorLinhas++)
       {
           for (int contadorColunas = 0; contadorColunas < 10; contadorColunas++)
           {
               Console.Write("*");
               if (contadorColunas >= contadorLinhas)
               {
                   break;
               }
           }
           Console.WriteLine();
       }
    }
}