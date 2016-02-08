using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exemplo_apostila
{
    class Program
    {
        static void Main(string[] args)
        {
            //instanciando a classe funcionario
            Funcionario f = new Funcionario("Joaquim");
            f.Sobrenome = "Ferreira";
            f.Idade = 30 ;
            f.Peso = 83.8;
            f.Cor = "Branco";
            f.NumeroFuncionario=12345;
            f.Cpf="123456789-89";

            Console.WriteLine("Nome Completo: {0} {1}", f.Nome,f.Sobrenome);
            Console.WriteLine("Idade: {0}", f.Idade);
            Console.WriteLine("Peso: {0}", f.Peso);
            Console.WriteLine("Cor: {0}", f.Cor);
            Console.WriteLine("Numero de Funcionario: {0}", f.NumeroFuncionario);
            Console.WriteLine("CPF: {0}", f.Cpf);

            f.Comer("Virada Paulista", "Sorvete");
            f.Beber();
            f.Correr();
            f.Enxergar();
            f.Ouvir();
            if (f.LogarCaixa())
            {
                f.AbrirCaixa();
            }else{
                f.FecharCaixa();
            }

            Console.WriteLine("------------------------------------------------------------");
            //instanciando a classe fornecedor

            Fornecedor f2 = new Fornecedor("Joaquim");
            f2.Sobrenome="Ferreira";
            f2.Idade=30;
            f2.Peso=83.8;
            f2.Cor="Branco";
            f2.NumeroFornecedor = 123;
            f2.Cnpj = "123456789-89";

            Console.WriteLine("Nome Completo: {0} {1}", f2.Nome, f2.Sobrenome);
            Console.WriteLine("Idade: {0}", f2.Idade);
            Console.WriteLine("Peso: {0}", f2.Peso);
            Console.WriteLine("Cor: {0}", f2.Cor);
            Console.WriteLine("Numero de Fornecedor: {0}", f2.NumeroFornecedor);
            Console.WriteLine("CNPJ: {0}", f2.Cnpj);

            f2.Comer("Virada Paulista", "Sorvete");
            f2.Beber();
            f2.Correr();
            f2.Enxergar();
            f2.Ouvir();
            f2.ControlarPedido();

            Console.WriteLine("------------------------------------------------------------");
            //instanciando a classe cliente

            Cliente c = new Cliente("Joaquim");
            c.Sobrenome="Ferreira";
            c.Idade=30;
            c.Peso=83.8;
            c.Cor="Branco";
            c.NumeroCliente=123;
            c.Cpf="123456789-89";

            Console.WriteLine("Nome Completo: {0} {1}", c.Nome, c.Sobrenome);
            Console.WriteLine("Idade: {0}", c.Idade);
            Console.WriteLine("Peso: {0}", c.Peso);
            Console.WriteLine("Cor: {0}", c.Cor);
            Console.WriteLine("Numero de Fornecedor: {0}", c.NumeroCliente);
            Console.WriteLine("CPF: {0}", c.Cpf);

            c.Comer("Virada Paulista", "Sorvete");
            c.Beber();
            c.Correr();
            c.Enxergar();
            c.Ouvir();
            c.LogarCompra();
            c.Comprar();
            c.Pagar();

            Console.WriteLine("------------------------------------------------------------");
            //instanciando a classe gerente
            Gerente g = new Gerente("Joaquim");
            g.Sobrenome="Ferreira";
            g.Idade=30;
            g.Peso=83.8;
            g.Cor="Branco";
            g.NumeroFuncionario=123;
            g.Cpf="123456789-89";
            g.SenhaCofre ="000000";

            Console.WriteLine("Nome Completo: {0} {1}", g.Nome, g.Sobrenome);
            Console.WriteLine("Idade: {0}", g.Idade);
            Console.WriteLine("Peso: {0}", g.Peso);
            Console.WriteLine("Cor: {0}", g.Cor);
            Console.WriteLine("Numero de Fornecedor: {0}", g.NumeroFuncionario);
            Console.WriteLine("CPF: {0}", g.Cpf);

            g.Comer("Virada Paulista", "Sorvete");
            g.Beber();
            g.Correr();
            g.Enxergar();
            g.Ouvir();
            g.ControPonto();
            g.GerenciarPagamento();


            Console.ReadKey();
        }
    }
}
