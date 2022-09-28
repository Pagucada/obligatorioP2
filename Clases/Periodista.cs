using System;
using System.Collections.Generic;
using System.Text;

namespace Clases
{
    public class Periodista:IValidacion
    {
        public int Id { get; set; }
        public static int UltimoId { get; set; } = 1;
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public string Contrasenia { get; set; }


        public Periodista(string nombre,string apellido, string email, string contra )
        {
            Id = UltimoId++;
            Nombre = nombre;
            Apellido = apellido;
            Email = email;
            Contrasenia = contra;

        }





         public void ValidarDatos()
        {
            if(string.IsNullOrEmpty(Nombre) == true || string.IsNullOrEmpty(Apellido) == true || string.IsNullOrEmpty(Email) == true || string.IsNullOrEmpty(Contrasenia) == true)
            {
                throw new Exception("Faltan datos");
            }
            int arrobaPos1 = Email.IndexOf("@");
            int arrobaPos2 = Email.LastIndexOf("@");
            
            if(arrobaPos1 == -1)
            {
                throw new Exception("Falta un arroba en el mail");
            }
            else if(arrobaPos1 != arrobaPos2)
            {
                throw new Exception("Solo puede tener un arroba el mail");
            }
            else if (arrobaPos1 == 0|| arrobaPos1 == Email.Length-1)
            {
                throw new Exception("El mail no puede tener arroba ni al principio ni al final");
            }
            if(Contrasenia.Length < 8)
            {
                throw new Exception("La contrasenia debe tener mas de 8 caracteres");
            }
        }

        
    }
}
