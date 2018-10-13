using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ej4.Tests
{
    [TestClass]
    public class TestCesar
    {
        [TestMethod]
        public void Test()
        {
            EncriptadorCesar enc = new EncriptadorCesar(3);

            char[] car = new char[1];
            car[0] = Convert.ToChar(0);
            string encriptada = enc.Encriptar(new string(car) + "Funciona con cualquier cadena 0-=1391-15-15==r ");

            Assert.AreEqual(new string(car) + "Funciona con cualquier cadena 0-=1391-15-15==r ", enc.Desencriptar(encriptada));
        }
    }
}
