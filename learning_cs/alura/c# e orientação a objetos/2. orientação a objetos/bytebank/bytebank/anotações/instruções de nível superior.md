Nas últimas atualizações do .NET, mais precisamente na versão 9 do C#, foram introduzidos alguns recursos novos com o objetivo de aumentar a produtividade e reduzir o esforço de quem utiliza a linguagem. E uma dessas novidades são as instruções de nível superior (*top level statements*). Mas o que é isso?

As instruções de nível superior facilitam principalmente o trabalho de quem está iniciando na linguagem, mas também podem tornar o código mais limpo para as pessoas que desejam criar uma demonstração rápida sem precisar se preocupar com todo um esqueleto de arquivo. Assim, é possível desenvolver de forma similar a linguagens como Python ou Ruby. Vamos a um exemplo prático?

Quando criamos um projeto do tipo console, até a versão do C# 8, temos por padrão no arquivo `Program.cs` a seguinte estrutura:

```csharp
using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá mundo!");
        }
    }
}

```

Portanto, devemos respeitar essa estrutura, definindo a `class Program`
 e a definição do método `main`. Mas usando o recurso das instruções de nível superior, veja como a escrita do `Olá mundo`, pode ficar bem mais simples:

`Console.WriteLine("Olá mundo!");`

Entretanto o recurso apresenta uma restrição: só podemos ter **um** arquivo de código no projeto que utiliza instrução de nível superior.