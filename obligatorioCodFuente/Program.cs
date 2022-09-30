using System;
using Clases;

namespace obligatorioCodFuente
{
    class Program
    {
        static void Main(string[] args)
        {
            Sistema sistema = Sistema.GetInstancia();
          

            Console.WriteLine(sistema.Periodistas[0].Nombre);
        }

        
    }
}
