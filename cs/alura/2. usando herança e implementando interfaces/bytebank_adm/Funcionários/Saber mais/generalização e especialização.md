# Para saber mais: generalização e especialização

Na orientação a objetos, a herança é um mecanismo que possibilita que classes compartilhem definições de atributos (propriedades), comportamentos (métodos) e outros membros entre elas. Na representação da herança adotamos uma representação hierárquica.

Abaixo, vemos a hierarquia na forma de um diagrama de classes da UML (Linguagem de Modelagem Unificada):

https://caelum-online-public.s3.amazonaws.com/2533-csharp-heranca-implementando-interfaces/01/imagem6.png

Utilizando a herança temos dois tipos básicos de classes:

Classe base: contém as características que servirão de base para uma outra classe, em algumas literaturas também são chamadas de superclasses;

Classe derivada: herda as características e comportamentos da classe base. Esse tipo de classe também é conhecida como subclasse.

A utilização de uma representação visual como a proporcionada pela UML nos ajuda a visualizar e a entender os conceitos de generalização e especialização que estão intimamente ligados à herança.

Note que no diagrama apresentado acima temos a classe Funcionario, nossa classe base, com as informações genéricas que serão comuns a toda classe que herde dela. Há também as classes Diretor e GerenteDeContas, que redefinem os métodos AumentarSalario() e getBonificacao(), ou seja, elas precisam que os comportamentos sejam específicos. Sendo assim, as especializações se comparam às implementações da classe base.