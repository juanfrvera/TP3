using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ej4.Tests
{
    [TestClass]
    public class TestDR
    {
        [TestMethod]
        public void TestMethod1()
        {
            Encriptador enc = new EncriptadorDR();
            string original = "Hola soy Juan, me gusta la manzana verde";
            string encriptada = enc.Encriptar(original);

            Assert.AreEqual(original, enc.Desencriptar(encriptada));
        }
    }
}