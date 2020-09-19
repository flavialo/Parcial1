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
            CountriesController controller = new CountriesController();
            //act
            var lista = controller.GetCountries();
            //assert
            Assert.IsNotNull(lista);
        }
    }
}
