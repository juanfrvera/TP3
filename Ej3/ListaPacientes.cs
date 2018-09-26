using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ej3
{
    abstract class ListaPacientes
    {
        protected List<Paciente> iPacientes;

        //Constructor
        protected ListaPacientes()
        {
            iPacientes = new List<Paciente>();

        }
        //Metodos
        public abstract void AgregarPaciente(Paciente pPaciente);
        public abstract Paciente SiguientePaciente();

        


    }
}
