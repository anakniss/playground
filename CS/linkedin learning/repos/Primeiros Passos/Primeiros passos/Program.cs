// See https://aka.ms/new-console-template for more information

//A string é uma instrução sequencial do tipo CHAR

string frase = "O dia está lindo!!!!";

//Console.WriteLine(frase.Substring(0, 10));  //0 = ponto de partida 10 = fim. Neste caso, será retornado "O dia está"

//Console.WriteLine(frase.Replace("lindo", "feio")); //Realiza a substituição

frase.Trim(); //Remove todos os espaços vazios no início e no fim das frases
frase.TrimEnd(); //Remove os espaços vazios apenas no fim das frases
frase.TrimStart(); //Remove os espaços vazios apenas no início das frases


//Obs: O trim o mesmo valor das extremidades das frases, ou seja, se no parâmetro eu coloco '!' e a frase está como "O dia está lindo!!!!!",
//o Trim excluirá todos os "!". 

string cpf = "345678900";

//Console.WriteLine(cpf.PadLeft(11, '0')); //Insere "0" à esquerda até completar o total de 11 caracteres);

string frase2 = frase + "Ensolarado";

//Console.WriteLine(frase2);

string frase3 = $"{frase} Ensolarado";
Console.WriteLine(frase3);
