using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ej4
{
    public class EncriptadorCesar : Encriptador

    {
        private int iDesplazamiento;
        
        //Constructor
        public EncriptadorCesar(int pDesplazamiento) : base("Cesar")
        {
            this.iDesplazamiento = pDesplazamiento;
        }
        //Metodos
        private string Desplazar(string pCadena, int pDesplazamiento)
        {
            char[] caracteres = new char[pCadena.Length];
            for (int i = 0; i < pCadena.Length; i++)
            {
                caracteres[i] = Convert.ToChar((256 + Convert.ToByte(pCadena[i]) - pDesplazamiento) % 256);
            }
            return new string(caracteres);
        }
        public override string Encriptar(string pCadena)
        {
            return Desplazar(pCadena, iDesplazamiento);
        }
        public override string Desencriptar(string pCadena)
        {
            return Desplazar(pCadena, -iDesplazamiento);
        }
    }
}
