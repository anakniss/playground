## Static

Use o modificador static para declarar um membro estático que pertença ao próprio tipo, em vez de um objeto específico. O modificador static pode ser usado para declarar classes static. Em classes, interfaces e structs, você pode adicionar o modificador static a campos, métodos, propriedades, operadores, eventos e construtores. O modificador static não pode ser usado com indexadores ou finalizadores. Para obter mais informações, consulte Classes estáticas e membros de classes estáticas.

## Exemplo

Agora Letícia está trabalhando no projeto do sistema de fornecedores para lojas de roupas e um dos requisitos é saber a quantidade de fornecedores criados durante a execução do programa. Foi desenvolvido o seguinte código:

```  
public class Fornecedor
{
    public int TotalFornecedores { private set { } get { return _totalFornecedores; } }
    public Fornecedor()
    {
    TotalFornecedores++;
    }
}

```

Contudo, ao executar o código, ela percebeu que o valor retornado na propriedade TotalFornecedores é sempre 1.

Marque a alternativa que melhor explica o que aconteceu.

A inconsistência ocorre porque a propriedade TotalFornecedores não está marcada como static.

A pessoa desenvolvedora deveria criar a propriedade como estática, para ser uma característica da classe e não algo compartilhado com todos os objetos da classe.
