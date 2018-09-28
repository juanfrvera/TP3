using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ej3
{
    class Controlador
    {
        ListaPacientes instancia;


        //Metodos
        public void Agregar(string pNombre,string pApellido,string pDni, int pPrioridad)
        {
            Paciente nuevoPaciente = new Paciente(pNombre, pApellido, pDni, pPrioridad);
            instancia.AgregarPaciente(nuevoPaciente);
        }

        public Paciente Atender()
        {
            return instancia.SiguientePaciente();
        }

        public void CambiarTipo()
        {

        }
    }
}
