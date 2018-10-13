using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ej4
{
    //Basado en la encriptacion Vigenere
    public class EncriptadorSustitucion : Encriptador
    {
        private byte[] iKey;//Clave para las sustituciones
        
        //Constructor
        public EncriptadorSustitucion() : base("Sustitucion")
        {
            this.iKey = new byte[5];
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                iKey[i] = (Byte)rnd.Next(256);
            }
        }

        /// <summary>
        /// Suma a cada caracter de la cadena su correspondiente desplazamiento en iKey
        /// pModificador toma los valores -1 y 1, de esta forma al desencriptar pModificador = -1
        /// y a cada caracter se le estaria restando su correspondiente desplazamiento en iKey
        /// </summary>
        /// <param name="pCadena"></param>
        /// <param name="pModificador"></param>
        /// <returns></returns>
        private string Reemplazar(string pCadena, int pModificador)
        {
            char[] caracteres = new char[pCadena.Length];
            for (int i = 0; i < pCadena.Length; i++)
            {
                caracteres[i] = Convert.ToChar((256 + Convert.ToByte(pCadena[i]) + pModificador*iKey[i%iKey.Length]) % 256);
            }
            return new string(caracteres);
        }
        public override string Encriptar(string pCadena)
        {
            return Reemplazar(pCadena, 1);
        }
        public override string Desencriptar(string pCadena)
        {
            return Reemplazar(pCadena, -1);
        }
    }
}
