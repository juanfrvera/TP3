using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ej3
{
    class Paciente
    {
        string iNombre;
        string iApellido;
        int iPrioridad;
        string iDni;
        DateTime iHoraDeLlegada;


        //Constructor
        public Paciente(string pNombre,string pApellido, string pDni, int pPrioridad)
        {
            this.iNombre = pNombre;
            this.iApellido = pApellido;
            this.iDni = pDni;
            this.iPrioridad = pPrioridad;
            this.iHoraDeLlegada = DateTime.Now;

        }

        public int Prioridad
        {
            get { return this.iPrioridad; }
        }

        public DateTime HoraDeLlegada
        {
            get { return this.iHoraDeLlegada; }
        }



    }
}
