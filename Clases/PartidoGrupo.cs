using System;
using System.Collections.Generic;
using System.Text;

namespace Clases
{
    public class PartidoGrupo:Partido
    {
        public NombresGrupos NombreGrupo { get; set; }

        public PartidoGrupo(Seleccion seleccion1, Seleccion seleccion2, DateTime fechaHora, bool finalizado, NombresGrupos nombreGrupo):base(seleccion1,seleccion2,fechaHora,finalizado)
        {
            NombreGrupo = nombreGrupo;
        }
    }
}
