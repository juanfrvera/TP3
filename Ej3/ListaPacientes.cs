using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ej3
{
    abstract class ListaPacientes
    {
        public enum Tipos {Triaje,Fifo}
        protected static List<Paciente> cPacientes;

        //Constructor
        static ListaPacientes()
        {
            cPacientes = new List<Paciente>();
        }

        protected ListaPacientes()
        {
            Reordenar();
        }
        
        //Metodos
        /// <summary>
        /// Agrega un paciente a la lista de pacientes
        /// </summary>
        /// <param name="pPaciente"></param>
        public abstract void AgregarPaciente(Paciente pPaciente);

        /// <summary>
        /// Devuelve el siguiente paciente a atender
        /// </summary>
        /// <returns></returns>
        public virtual Paciente SiguientePaciente()
        {
            if (cPacientes.Count > 0)
            {
                Paciente paciente = cPacientes[0];
                cPacientes.RemoveAt(0);
                return paciente;
            }
            return null;
        }

        /// <summary>
        /// Reordena la lista segun el nuevo criterio
        /// </summary>
        public abstract void Reordenar();
        /// <summary>
        /// Devuelve el criterio usado
        /// </summary>
        /// <returns></returns>
        public abstract string ObtenerCriterio();
    }
}
