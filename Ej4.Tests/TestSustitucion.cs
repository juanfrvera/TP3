using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ej4.Tests
{
    [TestClass]
    public class TestSustitucion
    {
        [TestMethod]
        public void Test()
        {
            EncriptadorSustitucion enc = new EncriptadorSustitucion();

            char[] car = new char[1];
            car[0] = Convert.ToChar(0);
            string encriptada = enc.Encriptar(new string(car) + "Funciona con cualquier cadena 0-=1391-15-15==r ");

            Assert.AreEqual(new string(car) + "Funciona con cualquier cadena 0-=1391-15-15==r ", enc.Desencriptar(encriptada));
        }
    }
}
