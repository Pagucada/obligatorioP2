using System;
using System.Collections.Generic;
using System.Text;

namespace Clases
{
    public class Pais : IValidacion
    {
        public int Id { get; set; }
        public static int UltimoId { get; set; } = 1;
        public string CodAlpha { get; set; }
        public string Nombre { get; set; }

        public Pais(string nombre, string codAlpha)
        {
            Id = UltimoId++;
            CodAlpha = codAlpha;
            Nombre = nombre;

        }


        public void ValidarDatos()
        {
            if (CodAlpha.Length != 3 || String.IsNullOrEmpty(Nombre))
            {
                throw new Exception("El código Alpha3 está mal o falta el nombre del país.");
            }
            
        }

        public override bool Equals(object obj)
        {
            return obj is Pais pais && pais.Id == Id;
        }
    }
}
