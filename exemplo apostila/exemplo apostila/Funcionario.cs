using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exemplo_apostila
{
    public class  Funcionario : Pessoa
    {
        public int numeroFuncionario;
        public string cpf;

        public Funcionario(string Nome):base(Nome)
        {
            this.nome = Nome;
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
