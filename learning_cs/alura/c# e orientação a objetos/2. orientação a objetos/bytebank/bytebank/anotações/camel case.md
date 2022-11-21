## Camel Case e Pascal Case

• `PascalCase`: neste padrão, *capitule* o primeiro caractere de cada palavra. A Microsoft recomenda a utilização do PascalCase quando for nomear classes, propriedades, enumeradores, interfaces, records e estruturas. Observe um exemplo:

```csharp
public class ContaCorrente
{
}
```

• `camelCase`: neste padrão, *capitule* cada palavra, exceto a primeira. A recomendação é usar quando for nomear variáveis que definem campos e parâmetros de métodos. Você ainda pode aplicar para campos *private* ou *internal* o prefixo `_` (*underscore*):

```csharp
public class Categoria
{
    internal  bool  _status;
    private  string _descricaoCategoria;
    public string DescricaoCategoria {get;set;}
}

```

### Sobre criação de objeto