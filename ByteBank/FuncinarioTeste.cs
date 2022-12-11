using ByteBank.Funcionarios;

Funcionario Lucas = new Funcionario();
Lucas.Nome = "Lucas Sodré";
Lucas.Cpf = "1651651";
Lucas.Salario = 2000;

Console.WriteLine(Lucas.Nome);
Console.WriteLine(Lucas.getBonificacao());