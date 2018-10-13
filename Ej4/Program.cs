using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ej4
{
    class Program
    {
        static void Main(string[] args){
            Controlador cont = new Controlador();
            string encriptada = "", metodo = "Null";
            int respuesta = -1;
            while (respuesta != 3)
            {
                Console.Clear();
                Console.WriteLine("Cadena encriptada:");
                Console.WriteLine(encriptada);
                Console.WriteLine("Metodo elegido: " + metodo);

                Console.WriteLine("1. Encriptar nueva cadena.");
                if (encriptada.Length > 0)
                    Console.WriteLine("2. Desencriptar ultima cadena.");
                Console.WriteLine("3. Salir.");

                try
                {
                    respuesta = Convert.ToInt16(Console.ReadLine());
                }
                catch (Exception)
                {
                    continue;
                    throw;
                }
                Console.Clear();
                switch (respuesta)
                {
                    case 1:
                        Console.Write("Ingrese cadena: ");
                        encriptada = Console.ReadLine();
                        Console.WriteLine("Ingrese metodo (AES, Cesar, Sustitucion, DR):");
                        metodo = Console.ReadLine();
                        encriptada = cont.Encriptar(encriptada, metodo);
                        break;
                    case 2:
                        if(encriptada.Length > 0)
                        {
                            Console.WriteLine("Cadena usada: " + encriptada);
                            Console.WriteLine("Metodo usado: " + metodo);
                            Console.WriteLine();
                            Console.WriteLine("Cadena desencriptada: " + cont.Desencriptar(encriptada, metodo));
                            Console.ReadKey();
                        }
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
