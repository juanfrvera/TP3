using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ej3
{
    class Program
    {

        

        static void Main(string[] args)
        {
            Controlador controlador = new Controlador();
            string opcion = "0";
            while (opcion != "4")
            {


                DibujarPantalla();
                opcion = Console.ReadLine();
                Console.Clear();
                switch (opcion)
                {

                    case "1":
                        Console.WriteLine("Nombre de Paciente: ");
                        string iNombre = Console.ReadLine();
                        Console.WriteLine("Apellido del Paciente: ");
                        string iApellido = Console.ReadLine();
                        Console.WriteLine("DNI: ");
                        string iDni = Console.ReadLine();
                        Console.WriteLine("Prioridad: ");
                        int iPrioridad = Convert.ToInt16(Console.ReadLine());
                        controlador.Agregar(iNombre, iApellido, iDni, iPrioridad);

                        Console.WriteLine("Paciente agregado con exito");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "2":
                        DatosPaciente datos = controlador.AtenderPaciente();
                        if (datos != null)
                        {
                            Console.WriteLine("Nombre y Apellido del Paciente: {0} {1}", datos.Nombre, datos.Apellido);
                            Console.WriteLine("DNI: {0}", datos.Dni);
                            Console.WriteLine("Prioridad: {0}", datos.Prioridad);
                            Console.WriteLine("Hora de llegada: {0}", datos.HoraDeLlegada );
                        }
                        else
                        {
                            Console.WriteLine("No quedan pacientes por atender");
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "3":
                        bool salir = false;
                        while (!salir)
                        {
                            Console.WriteLine("El criterio de busqueda actual es: {0}", controlador.ObtenerCriterioDeSeleccion());
                            Console.WriteLine("Desea cambiar de criterio de seleccion? : 'S' para Si, 'N' para salir");
                            opcion = Console.ReadLine();
                            switch (opcion.ToLower())
                            {
                                case "s":
                                    controlador.CambiarTipo();
                                    Console.WriteLine("Cambio realizado con exito.");
                                    Console.WriteLine();
                                    break;
                                case "n":
                                    salir = true;
                                    break;
                                default:
                                    continue;
                            }
                        }
                        Console.Clear();
                        break;
                }
            }
        }
        //Metodos
        static void DibujarPantalla()
        {
            Console.WriteLine("Agregar Paciente (1)");
            Console.WriteLine("Atender Paciente (2)");
            Console.WriteLine("Cambiar Tipo de Atencion (3)");
            Console.WriteLine("Cerrar (4)");
        }
    }
}
