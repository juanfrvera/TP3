using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ej3
{
    abstract class ListaPacientes
    {
        public enum Tipos {Triaje,Fifo}
        private ListaPacientes instancia;
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
        public abstract void AgregarPaciente(Paciente pPaciente);
        public virtual Paciente SiguientePaciente()
        {
            Paciente paciente = cPacientes[0];
            cPacientes.RemoveAt(0);
            return paciente;
        }
        
        public void ElegirTipo(Tipos pTipo)
        {
            if (pTipo == Tipos.Triaje)
                instancia = new Triaje();
            if (pTipo == Tipos.Fifo)
                instancia = new Fifo();
        }

        public abstract void Reordenar();

    }
}
