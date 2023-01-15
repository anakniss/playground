using bytebank_adm.Funcionários;
using bytebank_adm.Funcionários.Utilitário;

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

GerenciadorBonificacao gerenciador = new GerenciadorBonificacao();

Funcionario andre = new Funcionario();
andre.Nome = "André";
andre.CPF = "546.879.157-20";
andre.Salario = 2000;

Diretor maria = new Diretor();
maria.Nome = "Maria";
maria.CPF = "454.658.148-3";
maria.Salario = 5000;

gerenciador.Registrar(maria);
gerenciador.Registrar(andre);

Console.WriteLine("Total de bonificações: " + gerenciador.GetBonificacao());
Console.WriteLine("Total prêmio semestral: " + maria.PremioSemestral());

Console.WriteLine("Total de funcionários: " + Funcionario.TotalDeFuncionarios);
