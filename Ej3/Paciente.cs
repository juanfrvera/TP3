﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ej3
{
    class Paciente
    {
        private string iNombre;
        private string iApellido;
        private string iDni;
        private int iPrioridad;
        private DateTime iHoraDeLlegada;


        //Constructor
        public Paciente(string pNombre, string pApellido, string pDni, int pPrioridad)
        {
            this.iNombre = pNombre;
            this.iApellido = pApellido;
            this.iDni = pDni;
            this.iPrioridad = pPrioridad;
            this.iHoraDeLlegada = DateTime.Now;

        }

        public string Nombre
        {
            get { return this.iNombre; }
        }

        public string Apellido
        {
            get { return this.iApellido; }
        }

        public string Dni
        {
            get { return this.iDni; }
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
