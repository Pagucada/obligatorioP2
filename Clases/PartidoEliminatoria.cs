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
    }
}
