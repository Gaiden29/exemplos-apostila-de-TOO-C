using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exemplo_apostila
{
    public abstract class Pessoa
    {
        public string nome { get; set;}
        public string sobrenome { get; set; }
        public int idade { get; set; }
        public double peso { get; set; }
        public string cor { get; set; }


        public abstract void Comer(string comida, string sobremesa);
        public abstract void Beber();
        public abstract void Correr();
        public abstract void Enxergar();
        public abstract void Ouvir();
       
    }
}
