using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ej1
{
    class Pinguino : Animal
    {
        public override void HacerRuido()
        {
            base.HacerRuido();
            Console.WriteLine("Nut nut");
        }
    }
}
