using System;
using System.Collections.Generic;
using System.Text;

namespace Clases
{
    public class Jugador : IValidacion, IComparable, IComparer<Jugador>
    {
        public int Id { get; set; }
        public string NombreCompleto { get; set; }
        public string NumCamiseta { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public double Altura { get; set; } = 0;
        public string PieHabil { get; set; }
        public int ValorMercado { get; set; }
        public string Moneda { get; set; }
        public Pais PaisPerteneciente { get; set; }
        public string Puesto { get; set; }
        public static int MontoCategoria { get; set; }


        public Jugador(int id, string numCamiseta, string nombreCompleto, DateTime fechaNacimiento, double altura, string pieHabil, int valorMercado,string moneda, Pais pais,string puesto)
        {
            Id = id;
            NombreCompleto = nombreCompleto;
            NumCamiseta = numCamiseta; 
            FechaNacimiento = fechaNacimiento;
            Altura = altura;
            PieHabil = pieHabil;
            ValorMercado = valorMercado;
            PaisPerteneciente = pais;
            Puesto = puesto;
            Moneda = moneda;
        }






        public void ValidarDatos()
        {
            if (String.IsNullOrEmpty(NombreCompleto) || String.IsNullOrEmpty(NumCamiseta)
                || FechaNacimiento == DateTime.MinValue || Altura == 0 || String.IsNullOrEmpty(PieHabil)
                || ValorMercado <= 0 || PaisPerteneciente == null || String.IsNullOrEmpty(Puesto))
            {
                throw new Exception("Faltan valores por ingresar.");
            }
        }


        public override bool Equals(object obj)
        {
            return obj is Jugador jugador && jugador.Id == this.Id;
        }


        public string VerCategoriaFinanciera()
        {
            if(ValorMercado >= Jugador.MontoCategoria)
            {
                return "vip";
            }
            else
            {
                return "estandar";
            }
        }
        public int CompareTo(object obj)
        {
            Jugador jugadorOtro = (Jugador)obj;

            if(ValorMercado.CompareTo(jugadorOtro.ValorMercado) >0)
            {
                return -1;
            }
            else if (ValorMercado.CompareTo(jugadorOtro.ValorMercado) <0)
            {
                return 1;
            }
            else
            {
                return Compare(this, jugadorOtro);
            }

      
        }

        public int Compare(Jugador x, Jugador y)
        {
            if (x.NombreCompleto.CompareTo(y.NombreCompleto) < 0)
            {
                return -1;
            }
            if (x.NombreCompleto.CompareTo(y.NombreCompleto) > 0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}
