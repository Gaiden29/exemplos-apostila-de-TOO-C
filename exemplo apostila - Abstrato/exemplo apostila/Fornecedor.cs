﻿using System;
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
        public void ControlarPedido()
        {
            Console.WriteLine("Controle: Controla os pedidos");
        }
    }
}
