using Bytebank_ADM.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bytebank_ADM.SistemaInterno
{
    public interface IAutenticavel 
    {
        public string Login { get; set; }
        public string Senha { get; set; }
        

        public bool Autenticar(string login, string senha);
       
    }
}
