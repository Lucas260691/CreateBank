
using Bytebank_ADM.Funcionarios;
using Bytebank_ADM.Utilitario;

Funcionario joao = new Funcionario("651651651");
joao.Nome = "João Neves";
joao.Salario = 2000;

Console.WriteLine(joao.Nome);
Console.WriteLine(joao.GetBonificacao());

Diretor rafael = new Diretor("216516516514");
rafael.Nome = "Rafael Rojas";
rafael.Salario = 40000;

Console.WriteLine(rafael.Nome);
Console.WriteLine(rafael.GetBonificacao());

GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
gerenciador.Registrar(joao);
gerenciador.Registrar(rafael);

Console.WriteLine("Total de bonificações: "+gerenciador.TotalDeBonificacao);
Console.WriteLine("Total de funcionários:"+Funcionario.TotalDeFuncionarios);