/*Fazer um algoritmo que leia dez n�meros inteiros e para cada n�mero lido escreva o respectivo quadrado.*/

#include <stdio.h>

int main() {
	int num, i;

	for (i = 0; i < 10; i++) {
		printf("Digite um n�mero: ");
		scanf_s("%d", &num);
		num = num * num;
		printf("Seu quadrado �: %d \n", num);
	}

} 

