/*Fazer um algoritmo que leia um n�mero inteiro N e escreva os N primeiros n�meros inteiros positivos.*/

#include <stdio.h>

int main() {
	int num, rep, i;
	printf("Digite um n�mero: ");
	scanf_s("%d", &num);
	printf("Digite a quantidade de repeti��es que deseja: ");
	scanf_s("%d", &rep);

	for (i = 0; i < rep; i++) {
		num = num + 1;
		printf("%d \n", num);
	}

}