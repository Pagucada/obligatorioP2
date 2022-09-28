using System;
using System.Collections.Generic;
using System.Text;

namespace Clases
{
    public class Resenia
    {
        public Periodista Periodista_ { get; set; }
        public DateTime Fecha { get; set; }
        public Partido Partido_ { get; set; }
        public string Titulo { get; set; }
        public string Contenido { get; set; }


        public Resenia(Periodista periodista,DateTime fecha,Partido partido, string titulo,string contenido)
        {
            Periodista_ = periodista;
            Fecha = fecha;
            Partido_ = partido;
            Titulo = titulo;
            Contenido = contenido;
        }
    }
}
