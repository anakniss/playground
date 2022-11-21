### Sobre criação de objeto

Renato foi chamado para colaborar no desenvolvimento de um sistema para venda de e-books. Ele ficou responsável por criar o modelo de classes do projeto. Na etapa de levantamento de requisitos, a equipe dele achou interessante levar para o sistema um conjunto de informações: título do e-book, nome do autor, o ISBN da publicação, valor e os formatos disponíveis para download. Vemos abaixo o código desenvolvido:

```csharp
public class Ebook
    {
        public string titulo;
        public string autor;
        public string isbn;
        public string formatos;
        public double valor;
    }
```

Pensando em quem fará uso da classe `Ebook`, marque a opção correta para criar um objeto dela.

**Alternativa correta**

`Ebook ebook = new Ebook();`

Esta é a opção correta para criar um objeto do tipo `Ebook`, pois para isso precisamos definir uma referência do tipo da classe do objeto e **instanciá-lo** na memória do computador com o operador `new`.