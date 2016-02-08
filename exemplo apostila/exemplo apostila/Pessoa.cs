using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exemplo_apostila
{
    public class Pessoa
    {
        public string nome;
        public string sobrenome;
        public int idade;
        public double peso;
        public string cor;

        public  Pessoa(string Nome)
        {
            this.nome = Nome;
        }

        public void Comer(string comida, string sobremesa)
        {
            Console.WriteLine("comida: " + comida + " Sobremesa: " + sobremesa);
        }

        public void Beber()
        {
            Console.WriteLine("Beber: Refrigerante");
        }

        public void Correr()
        {
            Console.WriteLine("Correr: Pouco");
        }

        public void Enxergar()
        {
            Console.WriteLine("Enxergar: Bem");
        }

        public void Ouvir()
        {
            Console.WriteLine("Ouvir: muito bem");
        }

    }
}
