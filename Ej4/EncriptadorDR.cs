using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ej4
{
    //Este encriptador toma una cadena, se construye otra invirtiendola a medida que se va transformando
    //cada letra de la misma en 2 caracteres que se escriben consecutivos.
    //Para desencriptar usamos la semisuma de estos dos caracteres consecutivos
    public class EncriptadorDR : Encriptador
    {
        public EncriptadorDR() : base("DR"){}
        public override string Encriptar(string pCadena)
        {
            Random rnd = new Random();
            char[] cadena = new char[pCadena.Length * 2];
            for (int i = 0; i < pCadena.Length; i++)
            {
                int desp = rnd.Next(4, 30);
                cadena[cadena.Length - 2*i - 1] = Convert.ToChar((256 + Convert.ToByte(pCadena[i]) - desp) % 256);
                cadena[cadena.Length - 2*i - 2] = Convert.ToChar((256 + Convert.ToByte(pCadena[i]) + desp) % 256);
            }
            return new string(cadena);
        }

        public override string Desencriptar(string pCadena)
        {
            uint izquierda = 0;
            uint derecha = 0;

            char[] cadena = new char[pCadena.Length / 2];
            for (int i = 0; i < cadena.Length; i++)
            {
                izquierda = Convert.ToByte(pCadena[pCadena.Length - 2 * i - 1]);
                derecha = Convert.ToByte(pCadena[pCadena.Length - 2 * i - 2]);

                if (izquierda > derecha) derecha = derecha + 256;
                cadena[i] = Convert.ToChar((izquierda + derecha) / 2);

            }
            return new string(cadena);
        }

    }
}
