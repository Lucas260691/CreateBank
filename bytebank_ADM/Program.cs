
using Bytebank_ADM.Funcionarios;
using Bytebank_ADM.SistemaInterno;
using Bytebank_ADM.Utilitario;

#region
//Funcionario joao = new Funcionario("651651651", 2000);
//joao.Nome = "João Neves";

//Console.WriteLine(joao.Nome);
//Console.WriteLine(joao.GetBonificacao());

//Diretor rafael = new Diretor("216516516514");
//rafael.Nome = "Rafael Rojas";


//Console.WriteLine(rafael.Nome);
//Console.WriteLine(rafael.GetBonificacao());

//GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
//gerenciador.Registrar(joao);
//gerenciador.Registrar(rafael);

//Console.WriteLine("Total de bonificações: "+gerenciador.TotalDeBonificacao);
//Console.WriteLine("Total de funcionários:"+Funcionario.TotalDeFuncionarios);

//joao.AumentarSalario();
//rafael.AumentarSalario();

//Console.WriteLine("Novo salário do João " + joao.Salario);
//Console.WriteLine("Novo salário do Rafael " + rafael.Salario)
#endregion
//CalcularBonificacao();
UsarSistema();

    void CalcularBonificacao() 
{
    GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

    Designer ulisses = new Designer("165165165");
    ulisses.Nome = "Ulisses Souza";

    Diretor paula = new Diretor("165135165");
    paula.Nome = "Paula Marinho";

    Auxiliar igor = new Auxiliar("151651651");
    igor.Nome = "Igor Dias";

    GerenteDeContas camila = new GerenteDeContas("31651651");
    camila.Nome = "Camila Oliveira";

    gerenciador.Registrar(camila);
    gerenciador.Registrar(igor);
    gerenciador.Registrar(paula);
    gerenciador.Registrar(ulisses);

    Console.WriteLine("Total de Bonificação ="+ gerenciador.TotalDeBonificacao);
}

void UsarSistema()
{
    SistemaInterno sistema = new SistemaInterno();

    Diretor ingrid = new Diretor("3165165");
    ingrid.Nome = "Ingrid Novaes";
    ingrid.Senha = "123";

    GerenteDeContas ursula = new GerenteDeContas("346541654");
    ursula.Nome = "Ursula Alcantara";
    ursula.Senha = "321";

    sistema.Logar(ingrid, "123");
    sistema.Logar(ursula, "963");
}