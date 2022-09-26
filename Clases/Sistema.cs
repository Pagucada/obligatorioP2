using System;
using System.Collections.Generic;
using System.Text;

namespace Clases
{
    class Sistema
    {
        private static Sistema Instancia = null;
        private List<Jugador> Jugadores = new List<Jugador>();
        private List<Seleccion> Selecciones = new List<Seleccion>();
        private List<Pais> Paises = new List<Pais>();
        private List<Partido> Partidos = new List<Partido>();
        private List<Resenia> Resenia = new List<Resenia>();


        private Sistema()
        {
            PrecargaJugadores();
            PrecargaPaises();
            PrecargaSelecciones();
        }

        public Sistema getInstancia() { 
        if(Instancia == null)
            {
                Instancia = new Sistema();
            }
            return Instancia;
        }


        private void PrecargaPaises()
        {

        }
        private void PrecargaJugadores()
        {

        }
        private void PrecargaSelecciones()
        {

        }



        private void AltaJugador()
        {

        }
        private void AltaPais()
        {

        }
        private void AltaSeleccion() 
        { 

        }
        private void AltaPartido()
        {

        }

    }
}
