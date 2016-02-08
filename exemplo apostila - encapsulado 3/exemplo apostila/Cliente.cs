using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exemplo_apostila
{
    public class Cliente : Pessoa
    {
        public int numeroCliente { get; set; }
        public string cpf { get; set; }

        public Cliente(string Nome)
        {
            this.nome = Nome;
        }

        public override void Comer(string comida, string sobremesa)
        {
            Console.WriteLine("comida: " + comida + " Sobremesa: " + sobremesa);
        }

        public override void Beber()
        {
            Console.WriteLine("Beber: Refrigerante");
        }

        public override void Correr()
        {
            Console.WriteLine("Correr: Pouco");
        }

        public override void Enxergar()
        {
            Console.WriteLine("Enxergar: Bem");
        }

        public override void Ouvir()
        {
            Console.WriteLine("Ouvir: muito bem");
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
