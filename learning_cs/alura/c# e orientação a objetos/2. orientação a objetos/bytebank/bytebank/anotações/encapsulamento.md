# Encapsulamento

O encapsulamento é o processo de ocultar ou esconder os membros de uma classe do acesso exterior usando modificadores de acesso. O encapsulamento também é chamado de ocultação de informação ou *information hiding.*O encapsulamento fornece uma maneira de preservar a integridade do estado dos dados. Ao invés de definir campos públicos devemos definir campos de dados privados.A classe bem encapsulada deve ocultar seus dados e os detalhes de implementação do mundo exterior. Isso é denominado programação *caixa preta*. Usando o encapsulamento, a implementação do método pode ser alterada pelo autor da classe sem quebrar qualquer código existente fazendo uso dela.

Um modificador de acesso define o escopo e a visibilidade de um membro da classe. A linguagem C# suporta os seguintes modificadores de acesso:

- **Public**
- **Private**
- **Protected**
- **Internal**
- **Protected Internal.**

O modificador de acesso Public

O modificador de acesso **Public** permite que uma classe exponha suas variáveis de membros e funções de membros a outras funções e objetos.

Qualquer membro público pode ser acessado de fora da classe.

Vejamos o exemplo a seguir:

```csharp
using static System.Console;
namespace Cshp_Encapsulamento
{
    class Retangulo
    {
        //variáveis membros
        public double comprimento;
        public double largura;
        public double GetArea()
        {
            return comprimento * largura;
        }
        public void Exibir()
        {
            WriteLine("Área do Retângulo\n");
            WriteLine($"Comprimento: {comprimento}");
            WriteLine($"Largura: {largura}");
            WriteLine($"Area: {GetArea()}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Retangulo();
            r.comprimento = 2.5;
            r.largura = 1.5;
            r.Exibir();
            ReadLine();
        }
    }
}
```

![Untitled](https://s3-us-west-2.amazonaws.com/secure.notion-static.com/b5ec7b67-827a-4bbe-9e04-c37bf58e4e71/Untitled.png)

Neste código definimos a classe **Retangulo** contendo dois campos : **comprimento e largura** que foram declarados como públicos.Dessa forma eles podem ser acessados diretamente a partir do método **Main**() usando uma instância **r** da classe **Retangulo**.Os métodos **Exibir() e GetArea()** também podem acessar esses campos diretamente pois estão na mesma classe.

Aqui o código não esta encapsulado e pode ser alterado por qualquer programa exterior.

O modificador de acesso Private e o ocultamento da informação

Agora vamos usar o código anterior alterando o escopo dos campos **comprimento e largura** para privados. Fazemos isso usando o modificador de acesso **private**.

Ao fazer isso você verá que os campos não estão mais acessíveis no método **Main**() da classe **Program**, pois o modificador de acesso **private** permite apenas o acesso local aos campos.

![https://www.macoratti.net/18/01/c_encaps11.png](https://www.macoratti.net/18/01/c_encaps11.png)

Os campos agora somente podem ser acessados pelos métodos **GetArea() e Exibir()** da classe **Retangulo**. Esses métodos são públicos e podem ser acessados no método **Main**().

Como então acessar os valores de comprimento e largura ?

Podemos declarar um método público chamado **InformarValores()** e permiter que o valores sejam informados e atribuídos a esses campos:

```
using static System.Console;
```

```
        public doubleGetArea()
        {
            returncomprimento * largura;
        }
        public voidExibir()
        {
            WriteLine("Área do Retângulo\n");
            WriteLine($"Comprimento: {comprimento}");
            WriteLine($"Largura: {largura}");
            WriteLine($"Area: {GetArea()}");
        }
```

---

Executando o projeto iremos obter o seguinte resultado:

![https://www.macoratti.net/18/01/c_encaps12.png](https://www.macoratti.net/18/01/c_encaps12.png)

Essa implementação é mais robusta pois oculta o valor dos campos **largura e comprimento** permitindo que eles sejam acessados somente pelo método **InformaValores**().

Criando propriedades Públicas

Podemos melhorar o código definindo duas propriedades públicas **Comprimento e Largura** que permitem acessar o valor dos campos **comprimento e largura.**

Na definição das propriedades podemos incluir uma lógica não permitindo que valores menores que zero sejam incluídos, se isso ocorrer lançamos uma exceção.

Removemos também o método **Exibir()** da classe **Retangulo** que estava com a responsabilidade de exibir o resultado e usava para isso recursos da interface do usuário.

Veja como ficou o código :

```
using System;
using static System.Console;
```

```
    class Retangulo
    {
 private double comprimento;
        private double largura;
```

```
        public double Largura
        {
            get { return largura; }
            set
            {
 if (value < 0)
                {
                    throw new Exception("O valor da largura não pode ser menor que zero");
                }
                else
                {
                    largura = value;
                }
            }
        }
```

```
    class Program
    {
        static void Main(string[] args)
        {
            var r = new Retangulo();
try
            {
                WriteLine("Informe o comprimento: ");
                r.Comprimento = Convert.ToDouble(Console.ReadLine());
                WriteLine("Informe a largura : ");
                r.Largura = Convert.ToDouble(Console.ReadLine());
                WriteLine($"Area do Retangulo: {r.GetArea()}");
            }
            catch (ArgumentException argEx)
            {
 WriteLine($"Erro : {argEx} ");
            }
            ReadLine();
        }
    }
}
```

---

Neste código temos o encapsulamento aplicado de forma que o código esta mais aderente às boas práticas. Agora a classe **Retangulo** tem somente uma responsabilidade: calcular a área do retângulo.

**Nota**: *Podemos tornar a propriedade **somente leitura** não definindo a propriedade **set**.*

public double Comprimento {     get { return comprimento; }     }

---

Além disso temos as seguintes vantagens:

- Podemos criar as referências as campos apenas quando formos usá-los;
- Podemos verificar ou definir restrições na atribuição/obtenção de valores das propriedades;
- As propriedades permitem um acesso controlado aos campos;
- Como os estado da classe depende dos valores dos campos, usando propriedades podemos assegurar que valores inválidos não sejam atribuidos aos campos;

Quer outros motivos para preferir usar propriedades públicas ao invés de campos ???

- Campos(fields) não podem ser usados em interfaces
- Campos(fields) não permitem ser validados diretamente
- A implementação do databingind é feita pela vinculação de propriedades e não de campos.

## Encapsulando Campos

Quando definimos os campos para uma classe, uma boa prática é criá-los com a visibilidade privada. Para manipulá-los, o mais indicado é usar os métodos ou propriedades públicas. Assim conseguimos manter o princípio do encapsulamento, para restringir o acesso a informações do objeto que podem ser sensíveis, como CPF, ou número da conta. Letícia tem uma nova demanda para entregar ao projeto do ByteBank: a validação do tamanho do nome do cliente (titular) que deve ser maior do que 3 caracteres.

Fazendo uso das propriedades e mantendo operações de leitura e atribuição do campo, marque a alternativa que apresenta um código válido.

```
private string _nome;
public string Nome 
            {
            get
            {
                return _nome;
            }
            set
            {
                if (value.Length < 3)
                {
                    Console.WriteLine("Nome do titular precisa ter pelo menos 3 caracteres.");
                }
                else
                {
                    _nome = value;
                }
            }
 ```

Esta é a forma correta de implementar a validação do tamanho do nome do titular, definindo um if no corpo do set antes de atribuir o valor ao campo privado.