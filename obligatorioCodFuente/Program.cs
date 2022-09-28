using System;
using Clases;

namespace obligatorioCodFuente
{
    class Program
    {
        static void Main(string[] args) 
        {
            Sistema sistema = Sistema.getInstancia();

            sistema.AltaPeriodista(new Periodista("Lucas","Giordano","olahol@a","abcd1234") ) ;
        }
        
        
    }
}
