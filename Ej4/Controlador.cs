using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ej4
{
    class Controlador
    {
        /// <summary>
        /// Encripta pCadena segun el metodo indicado en pMetodo
        /// </summary>
        /// <param name="pCadena"></param>
        /// <param name="pMetodo"></param>
        /// <returns></returns>
        public string Encriptar(string pCadena, string pMetodo)
        {
            return FabricaEncriptadores.Instancia.GetEncriptador(pMetodo).Encriptar(pCadena);
        }
        /// <summary>
        /// Desencripta la cadena "pCadena" segun el metodo indicado en "pMetodo"
        /// </summary>
        /// <param name="pCadena"></param>
        /// <param name="pMetodo"></param>
        /// <returns></returns>
        public string Desencriptar(string pCadena, string pMetodo)
        {
            return FabricaEncriptadores.Instancia.GetEncriptador(pMetodo).Desencriptar(pCadena);
        }
    }
}
