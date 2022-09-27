using System;
using System.Collections.Generic;
using System.Text;

namespace Clases
{
    public class Jugador : IValidacion
    {
        private int Id { get; set; }
        private int UltimoId { get; set; } = 1;
        private string NombreCompleto { get; set; }
        private string NumCamiseta { get; set; }
        private DateTime FechaNacimiento { get; set; }
        private string Altura { get; set; }
        private string PieHabil { get; set; }
        private int ValorMercado { get; set; }
        private Pais PaisPerteneciente { get; set; }
        private string Puesto { get; set; }
        private static int MontoCategoria { get; set; }









        public void ValidarDatos()
        {
            if (String.IsNullOrEmpty(NombreCompleto) || String.IsNullOrEmpty(NumCamiseta) || FechaNacimiento == null
                || FechaNacimiento == null || String.IsNullOrEmpty(Altura) || String.IsNullOrEmpty(PieHabil)
                || ValorMercado <= 0 || PaisPerteneciente == null || String.IsNullOrEmpty(Puesto))
            {
                throw new Exception("Faltan valores por ingresar.");
            }
        }
    }
}
