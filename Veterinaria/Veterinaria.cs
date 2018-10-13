using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ej1
{
    class Veterinaria
    {
        private Animal[] iAnimales;
        /// <summary>
        /// Recorre la lista pAnimales y les envia el mensaje "HacerRuido" a cada uno.
        /// </summary>
        /// <param name="pAnimales"></param>
        public void AceptarAnimales(Animal[] pAnimales)
        {
            iAnimales = pAnimales;
            foreach (Animal animal in iAnimales)
            {
                animal.HacerRuido();
            }
        } 
    }
}
