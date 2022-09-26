using System;
using System.Collections.Generic;
using System.Text;

namespace Clases
{
    class PartidoEliminatoria:Partido
    {
        public bool Ganador { get; set; }
        public bool Alargue { get; set; }
        public bool TandaPenales { get; set; }
        public Etapa Etapa { get; set; }
    }
}
