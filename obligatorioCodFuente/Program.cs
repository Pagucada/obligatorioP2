using System;
using Clases;
using System.Collections.Generic;


namespace obligatorioCodFuente
{
    class Program
    {
        public static Sistema sistema = Sistema.GetInstancia();
        static void Main(string[] args)
        {
            
             MenuPrincipal();
        }

        public static void MenuPrincipal()
        {
            Console.WriteLine("0-Salir\n1-Agregar Periodista\n2-Asignar el valor de categoria financiera para los jugadores" +
                "\n3-Listar partidos de un jugador\n4-Listar Jugadores expulsados\n5-Mostrar partido con mas goles de una seleccion\n6-Listar jugadores con gol en un partido");
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
                case 4:
                    ListarJugadoresExpulsados();
                    break;
                case 5:
                    PartidoConMasGoles();
                    break;
                case 6:
                    ListarJugadoresConGol();
                    break;
                default:
                   
                    break;
            }
        }

       

        public static void AgregarPeriodista()
        {
            
           
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
                sistema.SetCatFinanciera(NuevoValor);
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
                    throw new Exception("El jugador todavia no jugo ningun partido");
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
        public static void ListarJugadoresExpulsados()
        {
            
            Console.Clear();
            List<Jugador> JugadoresExpulsados = sistema.GetJugadoresExpulsados();
            JugadoresExpulsados.Sort();
            try
            {
                if(JugadoresExpulsados.Count == 0)
                {
                    throw new Exception("No hay registro de jugadores expulsados");
                }

                foreach(Jugador j in JugadoresExpulsados)
                {
                    Console.WriteLine(j.NombreCompleto + " " + j.ValorMercado);
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
        public static void PartidoConMasGoles() 
        {
           
            Console.Clear();
            Console.WriteLine("Ingrese el nombre de la seleccion");
            Seleccion seleccion = sistema.GetSeleccion(Console.ReadLine());
            List<Partido> PartidosMasGoles = sistema.GetPartidoConMasGoles(seleccion);
            try
            {
                if(seleccion == null)
                {
                    throw new Exception("La seleccion ingresada no existe");
                }
                if (PartidosMasGoles.Count == 0)
                {
                    throw new Exception("No se encontraron registros");
                }
                
                foreach(Partido p in PartidosMasGoles) 
                {
                    Console.WriteLine($"{p.Seleccion1.Pais_.Nombre} contra {p.Seleccion2.Pais_.Nombre} Cantidad de goles: {p.GetCantidadDeGoles()}");
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

        public static void ListarJugadoresConGol()
        {
            
            Console.Clear();
            Console.WriteLine("Ingrese el id de un partido");
            int idPartido = Int32.Parse(Console.ReadLine());
            List<Jugador> JugadoresConGol = sistema.GetJugadoresConGolEnPartido(idPartido);

            try
            {
                if(sistema.GetPartido(idPartido) == null)
                {
                    throw new Exception("El partido ingresado no existe");
                }
                if(JugadoresConGol.Count == 0)
                {
                    throw new Exception("No hubo goles en el partido");
                }


                Console.WriteLine($"Id del partido: {sistema.GetPartido(idPartido).Id} || Seleccion 1: {sistema.GetPartido(idPartido).Seleccion1.Pais_.Nombre} || Seleccion 2: {sistema.GetPartido(idPartido).Seleccion2.Pais_.Nombre}");
                Console.WriteLine("Jugadores que metieron gol: ");
                foreach(Jugador j in JugadoresConGol)
                {
                    Console.WriteLine($"Nombre: {j.NombreCompleto} || Valor de mercado: {j.ValorMercado} || Categoria Financiera: {j.VerCategoriaFinanciera()}");
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
