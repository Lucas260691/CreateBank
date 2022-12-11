
using Bytebank_ADM.Funcionarios;
using Bytebank_ADM.Utilitario;

Funcionario joao = new Funcionario();
joao.Nome = "João Neves";
joao.Cpf = "651651651";
joao.Salario = 2000;

Console.WriteLine(joao.Nome);
Console.WriteLine(joao.getBonificacao());

Diretor rafael = new Diretor();
rafael.Nome = "Rafael Rojas";
rafael.Cpf = "216516516514";
rafael.Salario = 40000;

Console.WriteLine(rafael.Nome);
Console.WriteLine(rafael.getBonificacao());

GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
gerenciador.Registrar(joao);
gerenciador.Registrar(rafael);

Console.WriteLine("Total de bonificações: "+gerenciador.TotalDeBonificacao);