using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exemplo_apostila___relacao_entre_objetos
{
    public class Filial
    {
        public string cidade { get; set; }
        public int NumFilial { get; set; }
        public Banco banco { get; set; }
    }
}
