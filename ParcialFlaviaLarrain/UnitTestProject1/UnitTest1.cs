using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ParcialFlaviaLarrain.Controllers;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGet()
        {
            //arrange
            NumeroesController controller = new NumeroesController();
            //act
            var lista = controller.GetNumeroes();
            //assert
            Assert.IsNotNull(lista);
        }
    }
}
