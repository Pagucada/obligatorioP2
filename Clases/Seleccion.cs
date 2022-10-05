using System;
using System.Collections.Generic;
using System.Text;

namespace Clases
{
    public class Seleccion : IValidacion
    {
        public Pais Pais_ { get; set; }
        public List<Jugador> Jugadores { get; set; } = new List<Jugador>();
        
        public Seleccion(Pais pais)
        {
            Pais_ = pais;
        }
        


        public void ValidarDatos()
        {
            if (Pais_ == null || Jugadores.Count < 11)
            {
                throw new Exception("El país falta o la cantidad de jugadores es menor que 11.");
            }
        }

        //Agrega un nuevo jugador a la seleccion si esta NO lo contiene
        public void AgregarJugador(Jugador j)
        {
            if (!Jugadores.Contains(j))
            {
                Jugadores.Add(j);
            }
        }

        public override bool Equals(object obj)
        {
            return obj is Seleccion seleccion && seleccion.Pais_ == this.Pais_;
        }
    }
}
