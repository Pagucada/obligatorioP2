using System;
using System.Collections.Generic;
using System.Text;

namespace Clases
{
    public class Pais : IValidacion
    {
        public int Id { get; }
        public static int UltimoId { get; } = 1;
        public string CodAlpha { get; set; }
        public string Nombre { get; set; }




        public void ValidarDatos()
        {
            if (CodAlpha.Length != 3 || !String.IsNullOrEmpty(Nombre))
            {
                throw new Exception("El código Alpha3 está mal o falta el nombre del país.");
            }
            
        }
    }
}
