/* Fazer um algoritmo que leia um n�mero inteiro positivo e escreva os d�gitos deste n�mero em ordem
crescente. Ex: l�: 1982 escreve: 1289 ; l�: 670638 escreve: 036678 */


#include <stdio.h>

int main() {
	int num, num_un, num_ret, i;

	printf("Digite o n�mero: ");
	scanf_s("%d", &num);

	num_ret = 0;

	for (i = 0; i != 10; i = i + 1) {
		num_ret = num;
		while (num_ret != 0) {
			num_un = num_ret % 10;
			num_ret = num_ret / 10;
			if (num_un == i) {
				printf("%d", num_un);
			}

		}
	}
}