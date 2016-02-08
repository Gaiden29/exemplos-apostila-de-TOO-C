using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exemplo_apostila___relacao_entre_objetos
{
    public class Cliente : Pessoa, IDados
    {
        public int numConta { get; set; }
        public string TipoConta { get; set; }


        public string mostarCorrentePoup(string t)
        {
            string tipo;

            if (t == "CP")
            {
                tipo = "Conta Poupança";
            }
            else if (t == "CC")
            {
                tipo = "Conta Corrente";
            }
            else
            {
                tipo = "Conta Indefinida";
            }

            return tipo;
        }
    }
}
