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
            if (Pais_ == null || Jugadores.Count < 11)
            {
                throw new Exception("El país falta o la cantidad de jugadores es menor que 11.");
            }
        }
    }
}
