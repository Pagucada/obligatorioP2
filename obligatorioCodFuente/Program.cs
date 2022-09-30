using System;
using Clases;
using System.Collections.Generic;


namespace obligatorioCodFuente
{
    class Program
    {
       
        static void Main(string[] args)
        {
             Sistema sistema = Sistema.GetInstancia();
             MenuPrincipal();
        }

        public static void MenuPrincipal()
        {
            Console.WriteLine("0-Salir\n1-Agregar Periodista\n2-Asignar el valor de categoria financiera para los jugadores" +
                "\n3-Listar partidos de un jugador\n4-Listar Jugadores expulsados\n5-Mostrar partido con mas goles de una seleccion\n6-Listar jugadores con gol");
            int seleccion = Int32.Parse(Console.ReadLine());

               switch (seleccion)
            {
                case 0:
                    break;
                case 1:
                    AgregarPeriodista();
                   break;
                case 2:
                    AsignarValorCatFinanciera();
                    break;
                case 3:
                    ListarPartidosDeJugador();
                    break;
                default:
                    break;
            }
        }

        public static void AgregarPeriodista()
        {
            
            Sistema sistema = Sistema.GetInstancia();
            Console.Clear();
            
            Console.WriteLine("Ingrese nombre del periodista");
            string nombre = Console.ReadLine();
            Console.WriteLine("Ingrese apellido del periodista");
            string apellido = Console.ReadLine();
            Console.WriteLine("Ingrese email del periodista");
            string email = Console.ReadLine();
            Console.WriteLine("Ingrese contraseña del periodista");
            string contra = Console.ReadLine();


            try
            {
            sistema.AltaPeriodista(new Periodista(nombre,apellido,email,contra));

                Console.WriteLine($"Periodista {nombre} {apellido} exitosamente registrado");
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }
            
            
            Console.WriteLine("0-Atras");
            if(Console.ReadLine() == "0")
            {
                Console.Clear();
                MenuPrincipal();
            }
            
            
        }

        public static void AsignarValorCatFinanciera()
        {
            Console.Clear();
            Console.WriteLine("Ingrese nuevo valor para determinar la categoria financiera de los jugadores");
            int NuevoValor = Int32.Parse(Console.ReadLine());
            try
            {
                if (NuevoValor <= 0)
                {
                    throw new Exception("El valor debe ser mayor a 0");
                }
                Jugador.MontoCategoria = NuevoValor;
                Console.WriteLine("El monto fue asignado exitosamente");
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }

            Console.WriteLine("0-Atras");
            if (Console.ReadLine() == "0")
            {
                Console.Clear();
                MenuPrincipal();
            }
        }

        public static void ListarPartidosDeJugador()
        {
            Sistema sistema = Sistema.GetInstancia();
            Console.Clear();
            Console.WriteLine("Ingrese el id de un jugador");
            int IdJugador = Int32.Parse(Console.ReadLine());
            
            List<Partido> partidosJugador = sistema.GetPartidosJugador(IdJugador);

            try
            {
                 bool encontroJugador = false;
                foreach(Jugador j in sistema.GetJugadores())
                
                {
                    if (j.Id.Equals(IdJugador))
                    {
                        encontroJugador = true;
                        Jugador jugador = j;
                        Console.WriteLine($"{jugador.NombreCompleto}\n");
                    }
                }
                if (encontroJugador == false)
                {
                    throw new Exception("El id ingresado no pertenece a ningun jugador");
                }
                if(encontroJugador && partidosJugador.Count == 0)
                {
                    throw new Exception("El jugaor todavia no jugo ningun partido");
                }
            
            foreach(Partido p in partidosJugador)
            {
                Console.WriteLine($"Fecha y hora: {p.FechaYHora}\n Seleccion 1: {p.Seleccion1.Pais_.Nombre}" +
                    $" \n Seleccion 2: {p.Seleccion2.Pais_.Nombre}\n Cantidad de incidencias: {p.Incidencias.Count}");

            }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
            }


            Console.WriteLine("0-Atras");
            if (Console.ReadLine() == "0")
            {
                Console.Clear();
                MenuPrincipal();
            }

        }
    }
}
