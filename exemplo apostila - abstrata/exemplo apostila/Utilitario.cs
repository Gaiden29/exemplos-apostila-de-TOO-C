using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exemplo_apostila
{
    public static class Utilitario
    {
        public static string data;

        public static void MostrarDados(string nome, string sobrenome, string cor, int idade, 
            double peso,int num, string doc)
        {
            Console.WriteLine("Nome Completo: {0} {1}", nome, sobrenome);
            Console.WriteLine("Idade: {0}", idade);
            Console.WriteLine("Peso: {0}", peso);
            Console.WriteLine("Cor: {0}", cor);
            Console.WriteLine("Numero de Funcionario: {0}", num);
            Console.WriteLine("CPF: {0}", doc);
            Console.WriteLine("Data: {0}",data);
        }
    }
}
