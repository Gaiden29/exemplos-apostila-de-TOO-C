using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace exemplo_apostila_excecao
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                calculo.principal();
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Valor invalido");
            }
            catch(Exception e)
            {
                Console.WriteLine("Erro Geral: " + e);
            }
            finally
            {
                Console.WriteLine("Fim do Programa");
            }
            
            Console.ReadKey();
        }
    }
}
