using System;
using System.Collections.Generic;
using System.Text;

namespace Clases
{
    public class PartidoEliminatoria:Partido
    {
        public string Ganador { get; set; }
        public bool Alargue { get; set; }
        public bool TandaPenales { get; set; }
        public Etapa Etapa { get; set; }


        public PartidoEliminatoria(Seleccion seleccion1, Seleccion seleccion2, DateTime fechaHora,bool alargue,bool tandaPenales,Etapa etapa) : base(seleccion1,seleccion2,fechaHora)
        {
            Alargue = alargue;
            TandaPenales = tandaPenales;
            Etapa = etapa;
        }

        public void ValidarDatos()
        {
            base.ValidarDatos();
        }
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
        public override void ValidarIncidencia(Incidencia i)
        {
            bool jugadorPertenece = false;
            if (i.Jugador == null)

            {
                throw new Exception("El jugador esta vacio");

            }
            else if (Int32.Parse(i.Minuto) < -1)
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
