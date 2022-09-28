using System;
using Clases;

namespace obligatorioCodFuente
{
    class Program
    {
        static void Main(string[] args) 
        {
            Sistema sistema = Sistema.GetInstancia();
           foreach(Seleccion s in sistema.Selecciones)
            {
                Console.WriteLine(s.Pais_.Nombre);
                
                foreach(Jugador j in s.Jugadores)
                {
                    Console.WriteLine(j.NombreCompleto);
                }
                Console.WriteLine("");
            }
            Console.ReadKey();
        }
        
        
    }
}
