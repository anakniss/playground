O encapsulamento é uma prática recomendada. Definimos campos privados usando métodos públicos ou utilizando propriedades. Com base nisso, Pedro criou a seguinte classe:

```
class Aluno
    {
        public int Matricula { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public bool Status { get; set; }
        public int TipoCurso { get; set; }
    }
```

Porém, a propriedade `Matricula` precisa validar a operação de `Set`, não permitindo a inserção de valores menores ou iguais a zero.

Como Pedro poderia resolver o problema? E você, consegue solucionar esse desafio?.

Uma possível solução seria criar uma validação na propriedade `Matricula` da seguinte forma:

```
        private int matricula;
        public int Matricula
        {
            get
            {
                return matricula;
            }

            set
            {
                if (value <= 0)
                {
                    Console.WriteLine("Valor da matrícula não pode ser menor que zero.");
                }
                else
                {
                    matricula = value;
                }
             }
        }
```

Lembre-se de continuar praticando bastante e se desafiando sempre.