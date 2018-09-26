using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ej1
{
    class Veterinaria
    {
        private Animal[] iAnimales;

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
