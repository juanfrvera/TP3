﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ej3
{
    class Triaje : ListaPacientes
    {





        //Metodos

        public override void AgregarPaciente(Paciente pPaciente)
        {
            int i = 0;
            bool salir = false;
            if ((cPacientes.Count == 0) || (pPaciente.Prioridad==5))
                cPacientes.Add(pPaciente);
            else
                while ((!salir) && (i<cPacientes.Count))
                {
                    if (pPaciente.Prioridad >= cPacientes[i].Prioridad)
                        i++;
                    else
                        salir = true;
                }

                cPacientes.Insert(i, pPaciente);
        }

        public override void Reordenar()
        {
            cPacientes.OrderBy(p => p.Prioridad).ThenBy(p => p.HoraDeLlegada);
        }

    }
}
