using System;
using System.Collections.Generic;
using System.Text;

namespace Clases
{
    class Seleccion : IValidacion
    {
        private Pais Pais_ { get; set; }
        private List<Jugador> Jugadores { get; set; } = new List<Jugador>();
        public void ValidarDatos()
        {
            throw new NotImplementedException();
        }
    }
}
