﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exemplo_apostila
{
    public class  Funcionario : Pessoa
    {
        public int numeroFuncionario { get; set; }
        public string cpf { get; set; }

        public Funcionario(string Nome)
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

        public bool LogarCaixa()
        {
            if (numeroFuncionario == 12345)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public virtual string FecharCaixa()
        {
            return "Caixa Fechado!";
        }

        public void AbrirCaixa()
        {
            Console.WriteLine("Caixa Aberto");
        }

        public void AbrirCaixa(string nome)
        {
            Console.WriteLine("Caixa Aberto Sr. {0}",nome);
        }
    }
}
