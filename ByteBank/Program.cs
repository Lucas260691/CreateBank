using ByteBank;

//ContaCorrente contaDoLucas = new ContaCorrente();
//contaDoLucas.titular = "Lucas Sodré";
//contaDoLucas.numero_agencia = 1;
//contaDoLucas.conta = "1010-x";
//contaDoLucas.saldo = 100;

//Console.WriteLine("Saldo da conta do Lucas = " + contaDoLucas.saldo);

//contaDoLucas.Depositar(100);

//Console.WriteLine("Saldo da conta do Lucas pós-deposito =" + contaDoLucas.saldo);

//ContaCorrente contaDaMaria = new ContaCorrente();
//contaDaMaria.titular = "Maria Souza";
//contaDaMaria.numero_agencia = 13;
//contaDaMaria.conta = "1010-5";
//contaDaMaria.saldo = 350;

//Console.WriteLine("Saldo da conta da Maria =" + contaDaMaria.saldo);

//contaDoLucas.Transferir(50, contaDaMaria);
//Console.WriteLine("Saldo do Lucas = " + contaDoLucas.saldo);
//Console.WriteLine("Saldo da Maria = " + contaDaMaria.saldo);

//ContaCorrente contaDoPedro = new ContaCorrente();
//Console.WriteLine(contaDoPedro.titular);
//Console.WriteLine(contaDoPedro.saldo);
//Console.WriteLine(contaDoPedro.numero_agencia);
//Console.WriteLine(contaDoPedro.conta);


// Tipagem por valor:

//double valor = 300;
//double valor2 = valor;

//Console.WriteLine(valor == valor2);

// Tipagem por referência:



Cliente cliente = new Cliente();
cliente.nome = "Lucas Sodré";
cliente.cpf = "124536882";
cliente.profissao = "Desenvolvedor";

ContaCorrente conta = new ContaCorrente();
conta.titular = cliente;
conta.conta = "1010-x";
conta.numero_agencia= 15;
conta.saldo = 100;

Console.WriteLine("Titular =" + conta.titular.nome);
Console.WriteLine("Cpf =" + conta.titular.cpf);
Console.WriteLine("Profissão =" + conta.titular.profissao);
Console.WriteLine("N° Conta =" + conta.conta);
Console.WriteLine("Saldo = " + conta.saldo);
Console.WriteLine("N° Agência =" + conta.numero_agencia);