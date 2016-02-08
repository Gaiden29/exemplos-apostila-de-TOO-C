using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exemplo_apostila
{
    public class Cliente : Pessoa
    {

        public int numeroCliente;
        public string cpf;

        public Cliente(string Nome)
            : base(Nome)
        {
            this.nome = Nome;
        }

        public bool LogarCompra()
        {
            if (numeroCliente == 123)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Comprar()
        {
            Console.WriteLine("Compra efeutada");
        }
        public void Pagar()
        {
            Console.WriteLine("Pagamento Efetuado");
        }
    }
}
