// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//ARRAY E LIST

//Algumas vezes, em nossos programas, precisaremos trabalhar com o grupos de elementos. No C# temos duas maneiras para trabalhar desta forma: ARRAYS e COLEÇÕES
//Vamos utilizar arrays quando temos uma quantidade definida de elementos. Quando não, usaremos as coleções pois ela trazem maneiras para flexíveis para trabalhar com esse agrupamento
/*
int[] numeros = new int[] { 1, 2, 3, 4, 5 };
int num = numeros[0];

//Console.WriteLine(num);

int total = numeros.Length;

List<int> listNumeros = new List<int>();
List<int> listaNums = new List<int>() {  1, 2, 3, 4, 5 };

int count = listaNums.Count;
listaNums.Add(6);
listaNums.Remove(3);

int numer = listaNums.ElementAt(0);
  
listaNums.Clear();

foreach (int numero in listaNums)
    Console.WriteLine(numero);
*/

/*DICTIONARY

Dictionary<int, string> estados = new Dictionary<int, string>();
estados.Add(1, "RJ");
estados.Add(2, "SP");
estados.Add(3, "SC");

if (!estados.ContainsKey(4))
{
    estados.Add(4, "MG");
}

foreach (string estado in estados.Values)
{
    Console.WriteLine(estado);
}

//O índice do Dicitonary é a própria chave

string est = null;

if (estados.TryGetValue(3, out est))
{
    Console.WriteLine(est);
}  
*/

/*
//QUEUE - FILA - FIRST IN, FIRST OUT (FIFO) - A ordem que inserirmos os elementos, será a ordem de saída

Queue<string> lista = new Queue<string>();
lista.Enqueue("Olá");
lista.Enqueue("pessoal");
lista.Enqueue("do Linkedin");

foreach(string palavra in lista)
    Console.WriteLine(palavra);
    Console.WriteLine("----------------");
    string elem = lista.Dequeue(); //Removerá apenas o primeiro elemento da lista pois não existe ÍNDICE em filas

foreach (string palavra in lista)
    Console.WriteLine(palavra);

int total = lista.Count;

Console.WriteLine("----------------");
Console.WriteLine(lista.Peek()); //Retorna o primeiro objeto mas não remove da lista

*/

/*

//STACK - PILHA - LAST IN, FIRST OUT (LIFO) - O último elemento que inserimos, será o primeiro elemento a sair

Stack<string> lista = new Stack<string>();
lista.Push("Olá");
lista.Push("pessoal");
lista.Push("do Linkedin!!");

foreach(string palavra in lista)
   Console.WriteLine(palavra);
Console.Write("------------");
Console.WriteLine(lista.Pop()); //Remove o objeto

   Console.Write("------------");
foreach (string palavra in lista)
   Console.WriteLine(palavra);

Console.Write("------------");
Console.WriteLine(lista.Peek());

int total = lista.Count; //Total de itens

*/

//SORTEDLIST - Lista Ordenada Automaticamente - Similar ao Dictionary, precisamos definir uma chave e um valor

SortedList<int, string> lista = new SortedList<int, string>();
lista.Add(4, "RJ");
lista.Add(2, "SP");
lista.Add(1, "SC");
lista.Add(3, "MG");

foreach (string estado in lista.Values)
    Console.WriteLine(estado);