Estamos aprendendo no curso um conceito importante, o de visibilidade associada a campos e propriedades. Com este recurso conseguimos permitir o acesso a esses membros de classe por meio do nosso código.

A visibilidade de uma classe, método, campo ou propriedade vai nos informar de que modo esse item poderá ser acessado. No C# e em algumas outras linguagens usamos os modificadores de acesso para indicar os padrões de visibilidade. Eles são palavras-chave indicando os padrões de visibilidade de acessos.

No **C#** os modificadores de acesso mais utilizados são:

**public:** acessível de qualquer ponto do código, ou seja não impõe restrições;

**private:** acessível somente dentro do contexto onde foi declarado, ou seja, um membro privado dentro de uma classe só é acessível dentro da própria classe;

**protected:** o elemento é acessível dentro da classe e suas derivadas;

**internal:** é o padrão no C#. Caso nenhum modificador seja declarado, definirá a acessibilidade do elemento dentro do executável ou dll onde foi declarado;

**protected internal:** é proveniente união dos modificadores protected e internal.