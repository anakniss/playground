namespace desafio_II;

public class Pedido
{
    public int numeroPedido;
    public Cliente cliente;
    public ItemPedido item;
    public float totalPedido;

    public class ItemPedido
    {
        public int quantidade;
        public int numeroPedido;
        public Produto produto1;
        public Produto produto2;
        public Produto produto3;
    }
    
    public class Produto
    {
        int codigoProduto;
        string Descricao;
        double valorUnitario;
        double quantidade;
    }
    
    public class Cliente
    {
        public string nome;
        public string cpf;
        public string email;       
        public Endereco endereco;        
    }
    
    public class Endereco
    {
        public string rua;
        public string bairro;
        public string cidade;
        public string cep;
        public int numero;
    }
}