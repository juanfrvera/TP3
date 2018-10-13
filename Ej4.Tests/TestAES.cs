using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ej4;

namespace Ej4.Tests
{
    [TestClass]
    public class TestAES
    {
        [TestMethod]
        public void TestMethod1()
        {
            EncriptadorAES enc = new EncriptadorAES();
            string encriptada = enc.Encriptar("Si estas leyendo esto es porque queres asegurarte de que funciona nuestro AES");

            Assert.AreEqual("Si estas leyendo esto es porque queres asegurarte de que funciona nuestro AES", enc.Desencriptar(encriptada));

        }
    }
}
