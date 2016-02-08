using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exemplo_apostila
{
    public class  Funcionario : Pessoa
    {
        private int numeroFuncionario;
        private string cpf;

        public int NumeroFuncionario
        {
            get { return numeroFuncionario; }
            set { this.numeroFuncionario = value; }
        }

        public string Cpf
        {
            get { return cpf; }
            set { this.cpf = value; }
        }

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

        public void FecharCaixa()
        {
            Console.WriteLine("Caixa Fechado");
        }
        public void AbrirCaixa()
        {
            Console.WriteLine("Caixa Aberto");
        }
    }
}
