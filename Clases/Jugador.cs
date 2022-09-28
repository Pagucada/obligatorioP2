using System;
using System.Collections.Generic;
using System.Text;

namespace Clases
{
    public class Jugador : IValidacion
    {
        public int Id { get; set; }
        public static int UltimoId { get; set; } = 1;
        public string NombreCompleto { get; set; }
        public string NumCamiseta { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Altura { get; set; }
        public string PieHabil { get; set; }
        public int ValorMercado { get; set; }
        public Pais PaisPerteneciente { get; set; }
        public string Puesto { get; set; }
        public static int MontoCategoria { get; set; }


        public Jugador(string nombreCompleto,string numCamiseta, DateTime fechaNacimiento, string altura, string pieHabil, int valorMercado, Pais pais,string puesto)
        {
            Id = UltimoId++;
            NombreCompleto = nombreCompleto;
            NumCamiseta = numCamiseta; 
            FechaNacimiento = fechaNacimiento;
            Altura = altura;
            PieHabil = pieHabil;
            ValorMercado = valorMercado;
            PaisPerteneciente = pais;
            Puesto = puesto;
        }






        public void ValidarDatos()
        {
            if (String.IsNullOrEmpty(NombreCompleto) || String.IsNullOrEmpty(NumCamiseta)
                || FechaNacimiento == null || String.IsNullOrEmpty(Altura) || String.IsNullOrEmpty(PieHabil)
                || ValorMercado <= 0 || PaisPerteneciente == null || String.IsNullOrEmpty(Puesto))
            {
                throw new Exception("Faltan valores por ingresar.");
            }
        }


        public override bool Equals(object obj)
        {
            return obj is Jugador jugador && jugador.Id == this.Id;
        }
    }
}
