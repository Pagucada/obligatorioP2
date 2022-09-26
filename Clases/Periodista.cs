using System;
using System.Collections.Generic;
using System.Text;

namespace Clases
{
    class Periodista
    {
        public int Id { get; set; }
        private static int UltimoId { get; set; } = 1;
        private string Nombre { get; set; }
        private string Apellido { get; set; }
        private string Email { get; set; }
        private string Contrasenia { get; set; }

    }
}
