using System.ComponentModel;
using System.Threading.Channels;
using bytebank_adm.Funcionários;
using bytebank_adm.Funcionários.Utilitário;
using bytebank_ADM.Sistema_Interno;

#region MyRegion

// Funcionario pedro = new Funcionario();
// pedro.Nome = "Pedro Malazartes";
// pedro.CPF = "123456789";
// pedro.Salario = 2000;
//
// Console.WriteLine(pedro.Nome);
// Console.WriteLine(pedro.GetBonificacao());
//
// Diretor roberta = new Diretor();
// roberta.Nome = "Roberta Silva";
// roberta.CPF = "987654321";
// roberta.Salario = 5000;
//
// Console.WriteLine(roberta.Nome);
// Console.WriteLine(roberta.GetBonificacao());
//
// GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();
// gerenciador.Registrar(pedro);
// gerenciador.Registrar(roberta);
//
// Console.WriteLine("Total de bonificações: " + gerenciador.TotalBonificacao);

// GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();
//
// Funcionario andre = new Funcionario("546.879.157-20", 2000);
// andre.Nome = "André";
//
// Diretor maria = new Diretor("454.658.148-3");
// maria.Nome = "Maria";
//
// gerenciador.Registrar(maria);
// gerenciador.Registrar(andre);
//
// Console.WriteLine("Total de bonificações: " + gerenciador.GetBonificacao());
// Console.WriteLine("Total prêmio semestral: " + maria.PremioSemestral());
//
// Console.WriteLine("Total de funcionários: " + Funcionario.TotalDeFuncionarios);
// Console.WriteLine("Total de diretores: " + Diretor.TotalDeDiretores);
//
// andre.AumentarSalario();
// maria.AumentarSalario();
//
// Console.WriteLine("Novo salário do André: " + andre.Salario );
// Console.WriteLine("Novo salário do Maria: " + maria.Salario );

#endregion

UsarSistema();

void CalcularBonificacao()
{
    GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

    Designer ulisses = new Designer("123456");
    ulisses.Nome = "Ulisses Souza";

    Diretor paula = new Diretor("654321");
    paula.Nome = "Paula Souza";

    Auxiliar igor = new Auxiliar("436799");
    igor.Nome = "Igor Dias";

    GerenteContas camila = new GerenteContas("987654");
    camila.Nome = "Camila Oliveira";

    gerenciador.Registrar(ulisses);
    gerenciador.Registrar(paula);
    gerenciador.Registrar(igor);
    gerenciador.Registrar(camila);

    Console.WriteLine("Total de Bonificação: " + gerenciador.TotalBonificacao);
}

void UsarSistema()
{
    SistemaInterno sistema = new SistemaInterno();
    Diretor ingrid = new Diretor("987654");
    ingrid.Nome = "Ingrid Novaes";
    ingrid.Senha = "123";

    GerenteContas ursula = new GerenteContas("765432");
    ursula.Nome = "Ursula Alcantara";
    ursula.Senha = "321";
    
    sistema.Logar(ingrid, "123");
    sistema.Logar(ursula, "963");
}