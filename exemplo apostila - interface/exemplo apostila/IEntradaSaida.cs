using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exemplo_apostila
{
    interface IEntradaSaida
    {
        void Sair();
        void Entrar(string nome, int cod);
    }
}
