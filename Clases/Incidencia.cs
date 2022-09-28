using System;
using System.Collections.Generic;
using System.Text;

namespace Clases
{
    public class Incidencia
    {
        public EnumIncidencia Tipo {get;set;}
        public string Minuto { get; set; }
        public Jugador Jugador { get; set; }


        public Incidencia(EnumIncidencia tipo, string minuto, Jugador jugador)
        {
            Tipo = tipo;
            Minuto = minuto;
            Jugador = jugador;
        }
    }
}
