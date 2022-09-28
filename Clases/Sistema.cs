using System;
using System.Collections.Generic;
using System.Text;

namespace Clases
{
    public class Sistema
    {
        private static Sistema Instancia = null;
        private List<Jugador> Jugadores = new List<Jugador>();
        private List<Seleccion> Selecciones = new List<Seleccion>();
        private List<Pais> Paises = new List<Pais>();
        private List<Partido> Partidos = new List<Partido>();
        private List<Resenia> Resenias = new List<Resenia>();
        private List<Periodista> Periodistas = new List<Periodista>();


        private Sistema()
        {
            PrecargaJugadores();
            PrecargaPaises();
            PrecargaSelecciones();
        }

        public static Sistema getInstancia() { 
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


        public void AltaPeriodista(Periodista p)
        {
            try
            {
                p.ValidarDatos();

                if (!Periodistas.Contains(p))
                    {
                        Periodistas.Add(p);
                    }

            }
            catch(Exception)
            {
                throw;
            }
        }
        public void AltaJugador(Jugador j)
        {
            try
            {
                j.ValidarDatos();
                if (!Jugadores.Contains(j))
                {
                    Jugadores.Add(j);
                }
            }
            catch (Exception)
            {

                throw;
            }
            
        }
        public void AltaPais(Pais p)
        {
            try
            {
                p.ValidarDatos();
                if (!Paises.Contains(p))
                {
                    Paises.Add(p);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void AltaSeleccion(Seleccion s) 
        {
            s.ValidarDatos();
            if (!Selecciones.Contains(s))
            {
                Selecciones.Add(s);
            }
        }
        public void AltaPartido(Partido p)
        {
            try
            {
                p.ValidarDatos();
                if (!Partidos.Contains(p))
                {
                    Partidos.Add(p);
                }
            }
            catch (Exception)
            {

                throw;
            }
            

        }

    }
}
