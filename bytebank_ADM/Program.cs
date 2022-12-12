
using Bytebank_ADM.Funcionarios;
using Bytebank_ADM.Utilitario;

Funcionario joao = new Funcionario("651651651", 2000);
joao.Nome = "João Neves";

Console.WriteLine(joao.Nome);
Console.WriteLine(joao.GetBonificacao());

Diretor rafael = new Diretor("216516516514", 10000);
rafael.Nome = "Rafael Rojas";


Console.WriteLine(rafael.Nome);
Console.WriteLine(rafael.GetBonificacao());

GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
gerenciador.Registrar(joao);
gerenciador.Registrar(rafael);

Console.WriteLine("Total de bonificações: "+gerenciador.TotalDeBonificacao);
Console.WriteLine("Total de funcionários:"+Funcionario.TotalDeFuncionarios);

joao.AumentarSalario();
rafael.AumentarSalario();

Console.WriteLine("Novo salário do João " + joao.Salario);
Console.WriteLine("Novo salário do Rafael " + rafael.Salario);