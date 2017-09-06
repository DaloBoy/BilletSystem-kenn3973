using Microsoft.VisualStudio.TestTools.UnitTesting;
using BilletStorebelt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilletStorebelt.Tests
{
    [TestClass()]
    public class MCØresundTests
    {

        [TestMethod()]
        public void KøretøjTestMCØ()
        {
            //Arrange
            var mc = new MCØresund("Bicycle", false);
            //Act
            string køretøj = mc.Køretøj();
            //Assert
            Assert.AreEqual("Øresund MC", køretøj);
        }

        [TestMethod()]
        public void MCØresundPrisTest()
        {
            //Arrange
            var mc = new MCØresund("Bicycle", false);
            //Act
            int pris = mc.Pris();
            //Assert
            Assert.AreEqual(210, pris);
        }

        [TestMethod()]
        public void MCØresundPrisTestBrobizz()
        {
            //Arrange
            var mc = new MCØresund("Bicycle", true);
            //Act
            int pris = mc.Pris();
            //Assert
            Assert.AreEqual(73, pris);
        }
    }
}