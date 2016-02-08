using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exemplo_apostila___relacao_entre_objetos
{
    public class Pessoa
    {
        public string nome {get; set;}
        public string cpf { get; set; }
        public Banco banco { get; set; }
    }
}
