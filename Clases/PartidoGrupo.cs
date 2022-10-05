using System;
using System.Collections.Generic;
using System.Text;

namespace Clases
{
    public class PartidoGrupo:Partido
    {
       

        public NombresGrupos NombreGrupo { get; set; }

        public PartidoGrupo(Seleccion seleccion1, Seleccion seleccion2, DateTime fechaHora, NombresGrupos nombreGrupo):base(seleccion1,seleccion2,fechaHora)
        {
            NombreGrupo = nombreGrupo;
        }

        public void ValidarDatos()
        {
            base.ValidarDatos();

            {

            }
        }

        //Da de alta una nueva incidencia
        public override void AltaIncidencia(Incidencia i)
        {
            try
            {
                ValidarIncidencia(i);
                Incidencias.Add(i);
            }
            catch (Exception)
            {

                throw;
            }

        }

        //Valida una incidencia
        public override void ValidarIncidencia(Incidencia i)
        {
            bool jugadorPertenece = false;
            if (i.Jugador == null)

            {
                throw new Exception("El jugador esta vacio");

            }
            else if (Int32.Parse(i.Minuto) <= -1)
            {
                throw new Exception("El valor de minuto no es valido");
            }

            foreach (Jugador jugador in Seleccion1.Jugadores)
            {
                if (jugador.Equals(i.Jugador))
                {
                    jugadorPertenece = true;
                }
            }
            foreach (Jugador jugador in Seleccion2.Jugadores)
            {
                if (jugador.Equals(i.Jugador))
                {
                    jugadorPertenece = true;
                }
            }
            if (jugadorPertenece == false)
            {
                throw new Exception("El jugador no pertenece a ninguno de los planteles que juegan el partido");
            }

        }
    }
}
