/*Fazer um algoritmo que leia tr�s notas(n�meros com casas decimais) de um aluno e a quantidade de faltas
(n�mero inteiro) escrevendo o conceito(n�mero inteiro) deste aluno.O algoritmo dever� calcular a m�dia
aritm�tica das notas e determinar o conceito a partir da tabela abaixo.Al�m disto, o aluno, para ser aprovado,
dever� ter no m�ximo cinco faltas, caso contr�rio o conceito ser� zero.*/




#include <stdio.h>

int main() {
	float num1, num2, num3, media;

	printf("Digite a primeira nota do aluno: ");
	scanf_s("%f", &num1);
	printf("Digite a segunda nota do aluno: ");
	scanf_s("%f", &num2);
	printf("Digite a terceira nota do aluno: ");
	scanf_s("%f", &num3);

	int faltas;

	printf("Digite a quantidade de faltas que o aluno tem: ");
	scanf_s("%d", &faltas);

	media = (num1 + num2 + num2) / 3;
	printf("A m�dia do aluno eh: %f \n", media);

	if (media < 6 || faltas > 5) {
		printf("Conceito 0\n");
	}
	if (media >= 6 && media < 7 && faltas <= 5) {
		printf("Conceito 1\n");
	}
	if (media >= 7 && media < 8 && faltas <= 5) {
		printf("Conceito 2\n");
	}
	if (media >= 8 && media < 9 && faltas <= 5) {
		printf("Conceito 3\n");
	}
	if (media >= 9 && faltas <= 5) {
		printf("Conceito 4 \n");
	}

}