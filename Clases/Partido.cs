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
        public string ResultadoFinal { get; set; } = "Pendiente";


        protected Partido(Seleccion seleccion1, Seleccion seleccion2, DateTime fechaHora)
        {
            Id = UltimoId++;
            Seleccion1 = seleccion1;
            Seleccion2 = seleccion2;
            FechaYHora = fechaHora;

            //El resultado final no se solicita en esta instancia del obligatorio
        }



        public void ValidarDatos()
        {
            if (Seleccion1 == null || Seleccion2 == null)
            {
                throw new Exception("Las selecciones no pueden ingresarse vacías.");
            }
            else if (FechaYHora.Ticks < new DateTime(2022, 11, 20).Ticks || FechaYHora.Ticks > new DateTime(2022, 12, 18).Ticks)
            {
                throw new Exception("La fecha está ingresada en un rango que no corresponde.");
            }
        }
        //Devuelve la cantidad de goles en un Partido
        public int GetCantidadDeGoles()
        {
            int contadorGoles = 0;
            foreach (Incidencia i in Incidencias)
            {
                if (i.Tipo == EnumIncidencia.Gol)
                {
                    contadorGoles++;
                }
            }
            return contadorGoles;
        }

        public override bool Equals(object obj)
        {
            return obj is Partido partido && partido.Id == this.Id;
        }
        //Define metodos abstractos para dar de alta y validar las incidencias de el partido
        public abstract void AltaIncidencia(Incidencia i);
       
        public abstract void ValidarIncidencia(Incidencia i);
    
        }
}

