using System;
using System.Collections.Generic;
using System.Text;

namespace Clases
{
    public class PartidoGrupo:Partido
    {
        private DateTime dateTime;

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
    }
}
