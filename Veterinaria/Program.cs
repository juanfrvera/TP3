using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ej1
{
    class Program
    {
        static void Main(string[] args)
        {
            Veterinaria vet = new Veterinaria();
            Animal[] animales = new Animal[4];
            animales[0] = new Mono();
            animales[1] = new Pinguino();
            animales[2] = new Perro();
            animales[3] = new Gato();

            vet.AceptarAnimales(animales);

            animales[0].Saltar();
            animales[1].Correr();

            Console.ReadKey();
        }
    }
}
