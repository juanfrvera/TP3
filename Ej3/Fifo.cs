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
           cPacientes = cPacientes.OrderBy(p => p.HoraDeLlegada).ToList<Paciente>();
        }

        public override string ObtenerCriterio()
        {
            return "FIFO";
        }
    }
}
