#include <stdio.h>

int func2(int base,int altura) {
	int area;
	area = base * altura;
	return area;
}



void func() {
	int base, altura, area;
	printf("Digite a base do ret�ngulo: ");
	scanf_s("%d", &base);
	printf("Digite a altura do ret�ngulo: ");
	scanf_s("%d", &altura);
	area = func2(base, altura);
		printf("A �rea do ret�ngulo �: %d \n", area);
}

void func1(int quant) {
	int i;
	for (i = 0; i < quant; i++) {
		func();
	}
}


int main() {

	int quant1, i;

	printf("Digite quantas vezes voc� precisa da fun��o: ");
	scanf_s("%d", &quant1);

	func1(quant1);

	printf("%d", func2(10, 10) + func2(2, 5));
}

