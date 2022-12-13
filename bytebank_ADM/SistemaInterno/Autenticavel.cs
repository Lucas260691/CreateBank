using Bytebank_ADM.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank_ADM.SistemaInterno
{
    public abstract class Autenticavel : Funcionario
    {
        protected Autenticavel(string cpf, double salario) : base(cpf, salario) 
        {
        }
        public string Senha { get; set; }
        public string Login { get; set; }

        public virtual bool Autenticar(string login, string senha)
        {
            return (Senha == senha && Login == login);
        }
       
    }
}
