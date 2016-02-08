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
            f.setSobrenome("Ferreira");
            f.setIdade(30);
            f.setPeso(83.8);
            f.setCor("Branco");
            f.setNumeroFuncionario(12345);
            f.setCpf("123456789-89");

            Console.WriteLine("Nome Completo: {0} {1}", f.getNome(), f.getSobrenome());
            Console.WriteLine("Idade: {0}", f.getIdade());
            Console.WriteLine("Peso: {0}", f.getPeso());
            Console.WriteLine("Cor: {0}", f.getCor());
            Console.WriteLine("Numero de Funcionario: {0}", f.getNumeroFuncionario());
            Console.WriteLine("CPF: {0}", f.getCpf());

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
            f2.setSobrenome("Ferreira");
            f2.setIdade(30);
            f2.setPeso(83.8);
            f2.setCor("Branco");
            f2.setNumeroFornecedor(123);
            f2.setCnpj("123456789-89");

            Console.WriteLine("Nome Completo: {0} {1}", f2.getNome(), f2.getSobrenome());
            Console.WriteLine("Idade: {0}", f2.getIdade());
            Console.WriteLine("Peso: {0}", f2.getPeso());
            Console.WriteLine("Cor: {0}", f2.getCor());
            Console.WriteLine("Numero de Fornecedor: {0}", f2.getNumeroFornecedor());
            Console.WriteLine("CNPJ: {0}", f2.getCnpj());

            f2.Comer("Virada Paulista", "Sorvete");
            f2.Beber();
            f2.Correr();
            f2.Enxergar();
            f2.Ouvir();
            f2.ControlarPedido();

            Console.WriteLine("------------------------------------------------------------");

            //instanciando a classe cliente

            Cliente c = new Cliente("Joaquim");
            c.setSobrenome("Ferreira");
            c.setIdade(30);
            c.setPeso(83.8);
            c.setCor("Branco");
            c.setNumeroCliente(123);
            c.setCpf("123456789-89");

            Console.WriteLine("Nome Completo: {0} {1}", c.getNome(), c.getSobrenome());
            Console.WriteLine("Idade: {0}", c.getIdade());
            Console.WriteLine("Peso: {0}", c.getPeso());
            Console.WriteLine("Cor: {0}", c.getCor());
            Console.WriteLine("Numero de Fornecedor: {0}", c.getNumeroCliente());
            Console.WriteLine("CPF: {0}", c.getCpf());

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
            g.setSobrenome("Ferreira");
            g.setIdade(30);
            g.setPeso(83.8);
            g.setCor("Branco");
            g.setNumeroFuncionario(123);
            g.setCpf("123456789-89");
            g.setSenhaCofre("000000");

            Console.WriteLine("Nome Completo: {0} {1}", g.getNome(), g.getSobrenome());
            Console.WriteLine("Idade: {0}", g.getIdade());
            Console.WriteLine("Peso: {0}", g.getPeso());
            Console.WriteLine("Cor: {0}", g.getCor());
            Console.WriteLine("Numero de Fornecedor: {0}", g.getNumeroFuncionario());
            Console.WriteLine("CPF: {0}", g.getCpf());

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
