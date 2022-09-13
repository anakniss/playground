// See https://aka.ms/new-console-template for more information



//Operadores Aritméticos

int adicao = 5 + 3;
int subtracao = 5 - 3;
int multiplicacao = 5 * 3;
int divisao = 5 / 3;

int expr = (1 + 2) * 5 - 2 / 2;

//Operadores Relacionais

string cidade1 = "Blumenau";
string cidade2 = "Teresópolis";

bool ret1 = cidade1 == cidade2;
bool ret2 = cidade1 != cidade2;

int i = 2;
int j = 5;

bool ret3 = i == j;
bool ret4 = i != j;
bool ret5 = i > j;
bool ret6 = i >= j;
bool ret7 = i < j;
bool ret8 = i <= j;

//Operadores Lógicos

bool ret9 = i == j && cidade1 == cidade2;
bool ret10 = i != j && cidade1 != cidade2;
bool ret11 = i < j || cidade1 == cidade2;
bool ret12 = !(i < j); //negando condição


Console.WriteLine(ret11);

