using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ej1
{
    class Animal
    {
        public void Correr()
        {
            Console.WriteLine("Corriendo...");
        }
        public void Saltar()
        {
            Console.WriteLine("Saltando...");
        }
        public virtual void HacerRuido(){}
    }
}
