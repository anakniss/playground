/*Fazer um algoritmo que leia um n�mero (considere n�meros de 5 d�gitos). Escreva quantos algarismos deste
n�mero s�o �mpares e tamb�m a soma dos algarismos pares.*/

#include <stdio.h>

int main() {
	int num, soma_par, soma_imp, num1, num2, num3, num4, num5;

	soma_imp = 0;
	soma_par = 0;

	printf("Digite um valor com 5 d�gitos: ");
	scanf_s("%d", &num);

	num1 = num % 10;
	if (num1 % 2 == 1){
		soma_imp = soma_imp + 1;
	}
	else {
		soma_par = soma_par + num1;
	}
	num = num / 10;
	num2 = num % 10;
	if (num2 % 2 == 1) {
		soma_imp = soma_imp + 1;
	}
	else {
		soma_par = soma_par + num2;
	}
	num = num / 10;
	num3 = num % 10;
	if (num3 % 2 == 1) {
		soma_imp = soma_imp + 1;
	}
	else {
		soma_par = soma_par + num3;
	}
	num = num / 10;
	num4 = num % 10;
	if (num4 % 2 == 1) {
		soma_imp = soma_imp + 1;
	}
	else {
		soma_par = soma_par + num4;
	}
	num = num / 10;
	num5 = num % 10;
	if (num5 % 2 == 1) {
		soma_imp = soma_imp + 1;
	}
	else {
		soma_par = soma_par + num5;
	}
	
	printf("O n�mero possui %d algarismos �mpares", soma_imp);
	printf("A soma dos n�meros pares �: %d", soma_par);
}
