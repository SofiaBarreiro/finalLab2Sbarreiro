using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ConstructoresCliente()
        {
            Cliente clienteA = new Cliente("Nombre", "Apellido");
            Assert.IsTrue(clienteA.turno == 1);
            Cliente clienteB = new Cliente("Nombre", "Apellido", 5);
            Assert.IsTrue(clienteA.turno == 5);
            Cliente clienteC = new Cliente("Nombre", "Apellido");
            Assert.IsTrue(clienteA.turno == 6);


        }

       
    }
}
