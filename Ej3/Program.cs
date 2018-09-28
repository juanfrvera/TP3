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

            DibujarPantalla();
            string opcion = Console.ReadLine();
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
                    Controlador.Agregar(iNombre, iApellido, iDni, iPrioridad);
                    break;
                case "2":
                    Controlador.SiguientePaciente();
                    break;
                case "3":
                    Controlador.CambiarTipo();
            }



        }

        //Metodos
        static void DibujarPantalla()
        {
            Console.WriteLine("Agregar Paciente (1)");
            Console.WriteLine("Atender Paciente (2)");
            Console.WriteLine("Cambiar Tipo de Atencion (3)");
            Console.WriteLine("Cerrar esta melda (4)");
        }
    }
}
