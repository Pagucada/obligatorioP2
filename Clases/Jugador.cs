using System;
using System.Collections.Generic;
using System.Text;

namespace Clases
{
    public class Jugador : IValidacion
    {
        private int Id { get; set; }
        private int UltimoId { get; set; }
        private string NombreCompleto { get; set; }
        private string NumCamiseta { get; set; }
        private DateTime FechaNacimiento { get; set; }
        







        public void ValidarDatos()
        {
            throw new NotImplementedException();
        }
    }
}
