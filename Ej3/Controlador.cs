using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ej3
{
    class Controlador
    {
        ListaPacientes instancia;

        /// <summary>
        /// Por defecto la lista inicia en FIFO
        /// </summary>
        public Controlador()
        {
            instancia = new Fifo();
        }

        //Metodos
        public void Agregar(string pNombre,string pApellido,string pDni, int pPrioridad)
        {
            Paciente nuevoPaciente = new Paciente(pNombre, pApellido, pDni, pPrioridad);
            instancia.AgregarPaciente(nuevoPaciente);
        }

        public DatosPaciente AtenderPaciente()
        {
            Paciente paciente = instancia.SiguientePaciente();
            if (paciente == null )
                {
                    return null;
                }
            DatosPaciente datos = new DatosPaciente(paciente.Nombre, paciente.Apellido, paciente.Dni, paciente.Prioridad, paciente.HoraDeLlegada.ToString());
            return datos;
        }

        public void CambiarTipo()
        {
            Type tipoActual = instancia.GetType();
            if (tipoActual == typeof(Fifo))
                {
                    instancia = new Triaje();
                }
            else
                {
                    instancia = new Fifo();
                }
            instancia.Reordenar();

        }
        public string ObtenerCriterioDeSeleccion()
        {

            return instancia.ObtenerCriterio();
        }

    }

   
}
