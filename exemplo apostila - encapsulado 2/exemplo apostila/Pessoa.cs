using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exemplo_apostila
{
    public abstract class Pessoa
    {
        protected string nome;
        protected string sobrenome;
        protected int idade;
        protected double peso;
        protected string cor;

        public string Nome
        {
            get { return this.nome; }
        }

        public string Sobrenome
        {
            get { return this.sobrenome; }
            set { this.sobrenome = value; }
        }

        public int Idade
        {
            get { return this.idade; }
            set { this.idade = value; }
        }

        public double Peso
        {
            get { return this.peso; }
            set { this.peso = value; }
        }

        public string Cor
        {
            get { return this.cor; }
            set { this.cor = value; }
        }

        public abstract void Comer(string comida, string sobremesa);
        public abstract void Beber();
        public abstract void Correr();
        public abstract void Enxergar();
        public abstract void Ouvir();
       
    }
}
