/*2) Fazer um algoritmo que leia dez n�meros inteiros armazenando-os em um vetor e escreva primeiramente
todos os n�meros pares lidos e ap�s todos os �mpares. Exemplo:*/

#include <stdio.h>

int main() {
	int nums[10], i;


	for (i = 0; i < 10; i++) {

		scanf_s("%d", &nums[i]);

	}

	for (i = 0; i < 10; i++) {

		if (nums[i] % 2 == 0) {

			printf("%d\n", nums[i]);

		}
	}

	for (i = 0; i < 10; i++) {

		if (nums[i] % 2 != 0) {
			printf("%d\n", nums[i]);
		}
	}
}














/*
int main() {
	int nums[1000], i;

	for (i = 0; i < 10; i++) {

		scanf_s("%d", &nums[i]);

	}

	for (i = 9; i >= 0 ; i--) {

		printf("%d\n", nums[i]);
	}
}



int main() {
	int nums[10];
	
	for (int i = 0; i < 10; i++)
	{
		scanf_s("%d", &nums[i]);
	}

	for (int i = 0; i < 10; i++)
	{
		printf("%d", nums[i]);
	}
}

*/