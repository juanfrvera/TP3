using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ej4
{
    public abstract class Encriptador: IEncriptador
    {

        private string iNombre;

        //Constructor
        public Encriptador(string pNombre)
        {
            this.iNombre = pNombre;
        }
        //Propiedad
        public string Nombre
        {
            get { return this.iNombre; }
        }
        //Metodos
        public abstract string Encriptar(string pCadena);
        public abstract string Desencriptar(string pCadena);

    }
}
