using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exemplo_apostila___relacao_entre_objetos
{
    public class Banco
    {
        public List<Pessoa> pessoas {get; set;}
        public List<Cliente> clientes { get; set; }
        public List<Filial> filiais { get; set; }

        public string nome { get; set; }

        public void mostrarPessoas()
        {
            Console.WriteLine("Lista de Pessoas:");
            foreach (Pessoa p in pessoas) 
            {
                Console.WriteLine("Nome: {0}  CPF: {1} Banco: {2}",p.nome,p.cpf,p.banco.nome);
            }
        }

        public void mostrarClientes()
        {
            Console.WriteLine("Lista de Clientes:");
            foreach (Cliente c in clientes)
            {
                Console.WriteLine("Nome: {0}  CPF: {1} Conta: {2}  Banco: {3} \nTipo Conta: {4}", c.nome, c.cpf, c.numConta, c.banco.nome, c.TipoConta);
            }
        }

        public void mostrarFiliais()
        {
            Console.WriteLine("Lista de Filiais:");
            foreach (Filial f in filiais)
            {
                Console.WriteLine("Cidade: {0}  Num: {1} Banco: {2}",f.cidade,f.NumFilial,f.banco.nome);
            }
        }
    }
}
