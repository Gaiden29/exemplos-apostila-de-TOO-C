using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exemplo_apostila
{
    public class Gerente : Funcionario
    {
        private string senhaCofre;

        public string SenhaCofre
        {
            get { return this.senhaCofre; }
            set { this.senhaCofre = value; }
        }

        public Gerente(string Nome) : base(Nome)
        {
            this.nome = Nome;
        }

        public void ControPonto()
        {
            Console.WriteLine("Controla o Ponto dos funcionarios");
        }

        public void GerenciarPagamento()
        {
            Console.WriteLine("Gerencia o pagamento dos funcionarios");
        }

        
    }
}
