using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ej4
{
    class FabricaEncriptadores
    {
        private static FabricaEncriptadores cInstancia;
        public static FabricaEncriptadores Instancia
        {
            get
            {
                if (cInstancia == null)
                    cInstancia = new FabricaEncriptadores();

                return cInstancia;
            }
        }

        private Dictionary<string,IEncriptador> iEncriptadores;


        /// <summary>
        /// Crea el diccionario de encriptadores agregando los distintos encriptadores junto con su clave
        /// </summary>
        private FabricaEncriptadores()
        {
            iEncriptadores = new Dictionary<string, IEncriptador>();

            iEncriptadores.Add("AES", new EncriptadorAES());
            iEncriptadores.Add("Cesar", new EncriptadorCesar(3));
            iEncriptadores.Add("Sustitucion", new EncriptadorSustitucion());
            iEncriptadores.Add("DR", new EncriptadorDR());
            iEncriptadores.Add("Null", new EncriptadorNulo());
        }

        /// <summary>
        /// Devuelve el Encriptador del diccionario cuya clave sea la indicada en pNombre
        /// Si esta clave no esta contenida en el diccionario, devuelve el Encriptador nulo
        /// </summary>
        /// <param name="pNombre"></param>
        /// <returns></returns>
        public IEncriptador GetEncriptador(string pNombre)
        {
            if (iEncriptadores.ContainsKey(pNombre))
                return iEncriptadores[pNombre];
            else
                return iEncriptadores["Null"];
        }
    }
}
