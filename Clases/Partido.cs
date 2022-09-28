using System;
using System.Collections.Generic;
using System.Text;

namespace Clases
{
    public abstract class Partido : IValidacion
    {

        public int Id { get; set; }
        public static int UltimoId { get; set; } = 1;
        public Seleccion Seleccion1 { get; set; }
        public Seleccion Seleccion2 { get; set; }
        public DateTime FechaYHora { get; set; }
        public bool Finalizado { get; set; } = false;
        public List<Incidencia> Incidencias { get; set; } = new List<Incidencia>();
        public string ResultadoFInal { get; set; } = "Pendiente";


        protected Partido(Seleccion seleccion1,Seleccion seleccion2,DateTime fechaHora, bool finalizado)
        {
            Id = UltimoId++;
            Seleccion1 = seleccion1;
            Seleccion2 = seleccion2;
            FechaYHora = fechaHora;
            Finalizado = finalizado;
            //El resultado final no se solicita en esta instancia del obligatorio
        }


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

        public override bool Equals(object obj)
        {
            return obj is Partido partido && partido.Id == this.Id;
        }
    }
}
