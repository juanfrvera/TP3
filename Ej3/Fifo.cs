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
            iPacientes.Add(pPaciente);
        }

        public override Paciente SiguientePaciente()
        {
            Paciente paciente = iPacientes[0];
            iPacientes.RemoveAt(0);
            return paciente;
        }

    }
}
