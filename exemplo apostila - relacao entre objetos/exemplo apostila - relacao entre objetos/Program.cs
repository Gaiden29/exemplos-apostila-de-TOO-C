using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exemplo_apostila___relacao_entre_objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Banco b = new Banco();
            b.nome = "Banco ETEC";
            b.pessoas = new List<Pessoa>();
            b.clientes = new List<Cliente>();
            b.filiais = new List<Filial>();

            Pessoa p1 = new Pessoa();
            p1.nome = "João";
            p1.cpf = "230.963.222-85";
            p1.banco = b;

            Pessoa p2 = new Pessoa();
            p2.nome = "Maria";
            p2.cpf = "225.121.521-85";
            p2.banco = b;

            Pessoa p3 = new Pessoa();
            p3.nome = "Pedro";
            p3.cpf = "225.121.521-85";
            p3.banco = b;

            b.pessoas.Add(p1);
            b.pessoas.Add(p2);
            b.pessoas.Add(p3);

            b.mostrarPessoas();

            Cliente c1 = new Cliente();
            c1.nome = "Mariana";
            c1.cpf = "857.698.987-23";
            c1.numConta = 12369;
            c1.banco = b;
            c1.TipoConta =  c1.mostarCorrentePoup("CC");

            Cliente c2 = new Cliente();
            c2.nome = "Joaquim";
            c2.cpf = "988.128.957-83";
            c2.numConta = 21548;
            c2.banco = b;
            c2.TipoConta = c2.mostarCorrentePoup("CP");

            b.clientes.Add(c1);
            b.clientes.Add(c2);

            b.mostrarClientes();

            Filial f1 = new Filial();
            f1.cidade = "Itanhaém";
            f1.NumFilial = 1;
            f1.banco = b;

            Filial f2 = new Filial();
            f2.cidade = "Mongagua";
            f2.NumFilial = 2;
            f2.banco = b;

            b.filiais.Add(f1);
            b.filiais.Add(f2);

            b.mostrarFiliais();

            Console.ReadKey();
        }
    }
}
