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

        public string getNome()
        {
            return this.nome;
        }

        public string getSobrenome()
        {
            return this.sobrenome;
        }

        public void setSobrenome(string sobrenome)
        {
            this.sobrenome = sobrenome;
        }

        public int getIdade()
        {
            return this.idade;
        }

        public void setIdade(int vIdade)
        {
            this.idade = vIdade;
        }

        public double getPeso()
        {
            return this.peso;
        }

        public void setPeso(double Peso)
        {
            this.peso = Peso;
        }

        public string getCor()
        {
            return this.cor;
        }

        public void setCor(string vCor)
        {
            this.cor = vCor;
        }

        public abstract void Comer(string comida, string sobremesa);
        public abstract void Beber();
        public abstract void Correr();
        public abstract void Enxergar();
        public abstract void Ouvir();
       
    }
}
