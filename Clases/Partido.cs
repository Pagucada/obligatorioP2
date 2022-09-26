using System;
using System.Collections.Generic;
using System.Text;

namespace Clases
{
    class Partido : IValidacion
    {

        public int Id { get; }
        public static int UltimoId { get; } = 1;
        public Seleccion Seleccion1 { get; set; }
        public Seleccion Seleccion2 { get; set; }
        public DateTime FechaYHora { get; set; }
        public bool Finalizado { get; set; }
        public List<Incidencia> Incidencias { get; set; } = new List<Incidencia>();
        public string ResultadoFInal { get; set; }



        public bool ValidarDatos()
        {
         
        }
    }
}
