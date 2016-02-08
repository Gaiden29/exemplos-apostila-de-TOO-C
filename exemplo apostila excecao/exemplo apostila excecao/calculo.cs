using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exemplo_apostila_excecao
{
    public static class calculo
    {
        public static void principal()
        {
            string nome;
            int idade;
            int nascimento;

            Console.WriteLine("Digite Seu Nome: ");
            nome = Console.ReadLine();

            Console.WriteLine("Digite Sua Idade: ");
            idade = Convert.ToInt32(Console.ReadLine());

            if (idade < 0)
            {
                throw new ArgumentException();
            }

            nascimento = 2015 - idade;

            Console.Clear();

            Console.WriteLine("{0} Você nasceu em: {1}", nome, nascimento);
        }
    }
}
