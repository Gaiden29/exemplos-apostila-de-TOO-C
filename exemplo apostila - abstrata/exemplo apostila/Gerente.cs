using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exemplo_apostila
{
    public class Gerente : Funcionario, IEntradaSaida
    {
        public string senhaCofre{get; set;}

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

        public override string FecharCaixa()
        {
            return base.FecharCaixa() + " E relatório emitido!";
        }

        public override void Sair()
        {
            Console.WriteLine("Gerente Deseja Sair?");
        }

        public override void Entrar(string nome, int cod)
        {
            Console.WriteLine("Seja Bem vindo: {0} Cod.: {1}", nome, cod);
        }
    }
}
