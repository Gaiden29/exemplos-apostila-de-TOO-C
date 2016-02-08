using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exemplo_apostila
{
    public class Fornecedor : Pessoa
    {

        public int numeroFornecedor;
        public string cnpj;

        public Fornecedor(string Nome)
            : base(Nome)
        {
            this.nome = Nome;
        }

        public void ControlarPedido()
        {
            Console.WriteLine("Controle: Controla os pedidos");
        }
    }
}
