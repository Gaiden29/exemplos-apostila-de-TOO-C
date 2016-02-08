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
            f.sobrenome = "Ferreira";
            f.idade = 30 ;
            f.peso = 83.8;
            f.cor = "Branco";
            f.numeroFuncionario=12345;
            f.cpf="123456789-89";

            Console.WriteLine("Nome Completo: {0} {1}", f.nome,f.sobrenome);
            Console.WriteLine("Idade: {0}", f.idade);
            Console.WriteLine("Peso: {0}", f.peso);
            Console.WriteLine("Cor: {0}", f.cor);
            Console.WriteLine("Numero de Funcionario: {0}", f.numeroFuncionario);
            Console.WriteLine("CPF: {0}", f.cpf);

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
            f2.sobrenome="Ferreira";
            f2.idade=30;
            f2.peso=83.8;
            f2.cor="Branco";
            f2.numeroFornecedor = 123;
            f2.cnpj = "123456789-89";

            Console.WriteLine("Nome Completo: {0} {1}", f2.nome, f2.sobrenome);
            Console.WriteLine("Idade: {0}", f2.idade);
            Console.WriteLine("Peso: {0}", f2.peso);
            Console.WriteLine("Cor: {0}", f2.cor);
            Console.WriteLine("Numero de Fornecedor: {0}", f2.numeroFornecedor);
            Console.WriteLine("CNPJ: {0}", f2.cnpj);

            f2.Comer("Virada Paulista", "Sorvete");
            f2.Beber();
            f2.Correr();
            f2.Enxergar();
            f2.Ouvir();
            f2.ControlarPedido();

            Console.WriteLine("------------------------------------------------------------");
            //instanciando a classe cliente

            Cliente c = new Cliente("Joaquim");
            c.sobrenome="Ferreira";
            c.idade=30;
            c.peso=83.8;
            c.cor="Branco";
            c.numeroCliente=123;
            c.cpf="123456789-89";

            Console.WriteLine("Nome Completo: {0} {1}", c.nome, c.sobrenome);
            Console.WriteLine("Idade: {0}", c.idade);
            Console.WriteLine("Peso: {0}", c.peso);
            Console.WriteLine("Cor: {0}", c.cor);
            Console.WriteLine("Numero de Fornecedor: {0}", c.numeroCliente);
            Console.WriteLine("CPF: {0}", c.cpf);

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
            g.sobrenome="Ferreira";
            g.idade=30;
            g.peso=83.8;
            g.cor="Branco";
            g.numeroFuncionario=123;
            g.cpf="123456789-89";
            g.senhaCofre ="000000";

            Console.WriteLine("Nome Completo: {0} {1}", g.nome, g.sobrenome);
            Console.WriteLine("Idade: {0}", g.idade);
            Console.WriteLine("Peso: {0}", g.peso);
            Console.WriteLine("Cor: {0}", g.cor);
            Console.WriteLine("Numero de Fornecedor: {0}", g.numeroFuncionario);
            Console.WriteLine("CPF: {0}", g.cpf);

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
