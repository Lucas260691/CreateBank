using ByteBank;

ContaCorrente contaDoLucas = new ContaCorrente();
contaDoLucas.titular = "Lucas Sodré";
contaDoLucas.numero_agencia = 1;
contaDoLucas.conta = "1010-x";
contaDoLucas.saldo = 100;

Console.WriteLine("Saldo da conta do Lucas = " + contaDoLucas.saldo);

contaDoLucas.Depositar(100);

Console.WriteLine("Saldo da conta do Lucas pós-deposito =" + contaDoLucas.saldo);
