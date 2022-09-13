// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/* 

COMANDO IF
 
  if (condição a ser testada)

{

    comando a ser executado caso a condição seja verdadeira

}


const string APROVADO = "Aprovado";
const string REPROVADO = "Reprovado!";
const string EM_RECUPERACAO = "Em recuperação!";

Console.WriteLine("Digite a nota: ");
decimal nota = Convert.ToDecimal(Console.ReadLine());

if (nota >= 5)
{
    Console.WriteLine(APROVADO);
}

else if (nota >= 4 && nota < 5)
{
  //  Console.WriteLine(EM_RECUPERACAO);
}

else
{
 //fvc   Console.WriteLine(REPROVADO);
}

*/



/*

COMANDO SWITCH

  switch (variável)
{   
    case valor1:
        comando a ser executado;
        break;
    case valor2:
        comando a ser executado;
        break;
    default:
        comando a ser executado;
        break;
}



const string DIAS_31 = "Este mês tem 31 dias!";
const string DIAS_30 = "Este mês tem 30 dias!";
const string DIAS_28 = "Este mês tem 28 dias!";
const string MES_INVALIDO = "Este mês não existe";

Console.WriteLine("Escreva um mês: ");
string mes = Console.ReadLine();

switch (mes.ToUpper())
{
    case "JANEIRO":
    case "MARÇO":
        Console.WriteLine(DIAS_31);
        break;

    case "FEVEREIRO":
        Console.WriteLine(DIAS_28);
        break;

    case "ABRIL":
        Console.WriteLine(DIAS_30);
        break;

    default:
        Console.WriteLine(MES_INVALIDO);
        break;


}

*/

/* 
 COMANDO WHILE

int[] arInt = new int[] { 1, 2, 3, 4, 5 };

int i = 0;

while (i < arInt.Length)
{
    int numero = arInt[i];
    Console.WriteLine(numero);
    i++;
}



for (int j = 0; j < arInt.Length; j++ )
{
    int numero = arInt[j];
    Console.WriteLine(numero);

}
*/

/* COMANDO FOREACH - Funciona para quando temos uma lista e não precisamos necessariamente usar o ÍNDICE - A mesma quantidade de repetições será a mesma quantidade de elementos da lista
*/

int[] arInt = new int[] { 1, 2, 3, 4, 5 }; 
foreach(int numero in arInt)
{
    Console.WriteLine(numero);  
}