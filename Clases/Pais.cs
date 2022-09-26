using System;
using System.Collections.Generic;
using System.Text;

namespace Clases
{
    class Pais : IValidacion
    {
        public int Id { get; }
        public static int UltimoId { get; } = 1;
        public string CodAlpha { get; set; }
        public string Nombre { get; set; }
        
        
        
        
        public bool ValidarDatos()
        {
            throw new NotImplementedException();
        }
    }
}
