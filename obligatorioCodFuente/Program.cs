using System;
using Clases;

namespace obligatorioCodFuente
{
    class Program
    {
        static void Main(string[] args) 
        {
            Sistema sistema = Sistema.GetInstancia();
           foreach(Jugador j in sistema.Jugadores)
            {
                Console.WriteLine(j.NombreCompleto);
                
            
            }

        }
        
        
    }
}
