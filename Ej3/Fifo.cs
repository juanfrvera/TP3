using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ej3
{
    class Fifo : ListaPacientes
    {

        //Constructor
        public Fifo() : base()
        {
           
        }

        //Metodos

        public override void AgregarPaciente(Paciente pPaciente)
        {
            cPacientes.Add(pPaciente);
        }

        public override void Reordenar()
        {
            cPacientes.OrderBy(p => p.HoraDeLlegada);
        }


    }
}
