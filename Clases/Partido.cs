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



        public void ValidarDatos()
        {
            if(Seleccion1 == null || Seleccion2 == null)
            {
                throw new Exception("Las selecciones no pueden ingresarse vacías.");
            }
            else if(FechaYHora.Ticks < new DateTime(11,20,2022).Ticks && FechaYHora.Ticks > new DateTime(12, 18, 2022).Ticks)
            {
                throw new Exception("La fecha está ingresada en un rango que no corresponde.");
            }
        }
    }
}
