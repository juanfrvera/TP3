using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ej1
{
    abstract class Animal
    {
        /// <summary>
        /// Escribe "Corriendo..." en pantalla
        /// </summary>
        public void Correr()
        {
            Console.WriteLine("Corriendo...");
        }
        /// <summary>
        /// Escribe "Saltando..." en pantalla
        /// </summary>
        public void Saltar()
        {
            Console.WriteLine("Saltando...");
        }
        /// <summary>
        /// Escribe el ruido particular del animal en pantalla
        /// </summary>
        public abstract void HacerRuido();
    }
}
