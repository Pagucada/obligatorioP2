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
            //precarga
        }

        public Sistema getInstancia() { 
        if(Instancia == null)
            {
                Instancia = new Sistema();
            }
            return Instancia;
        }

    }
}
