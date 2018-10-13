using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ej4
{
    public interface IEncriptador
    {
        string Encriptar(string pCadena);
        string Desencriptar(string pCadena);
    }
}
