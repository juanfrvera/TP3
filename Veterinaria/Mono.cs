using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ej1
{
    class Mono : Animal
    {
        public override void HacerRuido()
        {
            base.HacerRuido();
            Console.WriteLine("Ua ua");
        }
    }
}
