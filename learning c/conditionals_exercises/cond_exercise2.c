/*Um professor resolveu considerar, para c�lculo da m�dia aritm�tica final do semestre, somente as tr�s
maiores notas das quatro provas realizadas pelos alunos.Para auxili� - lo, deve - se fazer um algoritmo que leia as
quatro notas de um aluno e escreva a m�dia aritm�tica considerando apenas as suas tr�s maiores notas.*/

#include <stdio.h>

int main() {
	float nota1, nota2, nota3, nota4, menor_nota, media;

	printf("Digite a primeira nota do aluno: ");
	scanf_s("%f", &nota1);
	printf("Digite a segunda nota do aluno: ");
	scanf_s("%f", &nota2);
	printf("Digite a terceira nota do aluno: ");
	scanf_s("%f", &nota3);
	printf("Digite a quarta nota do aluno: ");
	scanf_s("%f", &nota4);

	menor_nota = 10;


	if(nota1 < menor_nota) {
		menor_nota = nota1;
	}
	if(nota2 < menor_nota) {
		menor_nota = nota2;
	}
	if(nota3 < menor_nota) {
		menor_nota = nota3;
	}
	if (nota4 < menor_nota) {
		menor_nota = nota4;
	}

	media = (nota1 + nota2 + nota3 + nota4 - menor_nota)/3;

	printf("A menor nota �: %f \n", menor_nota);

	printf("A m�dia do aluno �: %f \n", media);
}
