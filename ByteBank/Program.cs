using ByteBank.Contas;
using ByteBank.Titular;

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



//Cliente cliente = new Cliente();
//cliente.nome = "Lucas Sodré";
//cliente.cpf = "124536882";
//cliente.profissao = "Desenvolvedor";

//ContaCorrente conta = new ContaCorrente();
//conta.titular = cliente;
//conta.conta = "1010-x";
//conta.numero_agencia= 15;
//conta.saldo = 100;

//Console.WriteLine("Titular =" + conta.titular.nome);
//Console.WriteLine("Cpf =" + conta.titular.cpf);
//Console.WriteLine("Profissão =" + conta.titular.profissao);
//Console.WriteLine("N° Conta =" + conta.conta);
//Console.WriteLine("Saldo = " + conta.saldo);
//Console.WriteLine("N° Agência =" + conta.numero_agencia);

//ContaCorrente conta2 = new ContaCorrente();
//conta2.titular = new Cliente();
//conta2.titular.nome = "Bel Rojas";
//conta2.titular.profissao = "Professora";
//conta2.titular.cpf = "1654651465";
//conta2.conta = "9999-x";
//conta2.saldo = 500;

//Console.WriteLine(conta2.titular.nome);

//ContaCorrente conta3 = new ContaCorrente();
//conta3.SetSaldo(-10);
//Console.WriteLine(conta3.GetSaldo());

//ContaCorrente conta4 = new ContaCorrente();
//conta4.Numero_agencia = 18;
//conta4.Conta = "1011-H";
//conta4.SetSaldo(200);
//Console.WriteLine(conta4.GetSaldo());
//Console.WriteLine(conta4.Numero_agencia);
//Console.WriteLine(conta4.Conta);

//ContaCorrente conta4 = new ContaCorrente(18, "1010-X");
//conta4.SetSaldo(500);
//conta4.Titular = new Cliente();

//Console.WriteLine(conta4.GetSaldo());
//Console.WriteLine(conta4.Numero_agencia);

//ContaCorrente conta5 = new ContaCorrente(283, "12345-X");
//Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

//ContaCorrente conta6 = new ContaCorrente(284, "9874-Z");
//Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

//ContaCorrente conta7 = new ContaCorrente(285, "1111-Z");
//Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ContaCorrente conta = new ContaCorrente(0, 0);
            }
            catch(ArgumentException ex) 
            {
                Console.WriteLine("Ocorreu um erro do tipo ArgumentExeption");
                Console.WriteLine(ex.Message);
            }
            
            
            Console.ReadLine();
        }
    }
}