using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exemplo_apostila
{
    public abstract class Pessoa
    {
        public string nome;
        public string sobrenome;
        public int idade;
        public double peso;
        public string cor;


        public abstract void Comer(string comida, string sobremesa);
        public abstract void Beber();
        public abstract void Correr();
        public abstract void Enxergar();
        public abstract void Ouvir();
       
    }
}
