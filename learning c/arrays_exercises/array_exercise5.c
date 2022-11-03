/* Fazer um algoritmo que leia vinte n�meros inteiros armazenando-os em um vetor, a seguir, troque o
conte�do da primeira posi��o do vetor com o conte�do da segunda posi��o, o conte�do da terceira posi��o com
o da quarta, e assim, sucessivamente at� trocar o conte�do da d�cima nona com o da vig�sima e escreva o vetor
ap�s estas modifica��es. */


#include <stdio.h>
#define QUANT 20

int calculo(int nums[QUANT]) {
	int i, i2;

	i2 = 0;

	for (i = 0; i < QUANT; i = i + 2) {
		i2 = nums[i];
		nums[i] = nums[i + 1];
		nums[i + 1] = i2;
	}



}

void teste(int num_test, int nums[QUANT], int nums_esperado[QUANT]) {
	calculo(nums);
	int i, correto = 1;

	for (i = 0; i < QUANT; i++) {

		if (nums[i] != nums_esperado[i]) {
			correto = 0;
			printf("No �ndice %d esperava-se %d mas cont�m %d\n", i, nums_esperado[i], nums[i]);
		}

	}
	if (correto) {
		printf("O teste %d est� CORRETO!\n", num_test);
	}
	else {
		printf("O teste %d est� INCORRETO\n", num_test);
	}
}

int main() {
	int nums[QUANT] = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
	int nums_esperado[QUANT] = {2, 1, 4, 3, 6, 5, 8, 7, 10, 9, 12, 11, 14, 13, 16, 15, 18, 17, 20, 19};
	teste(1, nums, nums_esperado);

	int nums1[QUANT] = {111, 2, 3, 444, 5, 56, 7, 8, 879, 10, 11, 112, 133, 14, 115, 16, 17, 1128, 19, 200 };
	int nums_esperado1[QUANT] = {2, 111, 444, 3, 56, 5, 8, 7, 10, 879, 112, 11, 14, 133, 16, 115, 1128, 17, 200, 19};
	teste(2, nums1, nums_esperado1);
}