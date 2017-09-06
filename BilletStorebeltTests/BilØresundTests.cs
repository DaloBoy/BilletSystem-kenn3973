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
    public class BilØresundTests
    {
        [TestMethod()]
        public void KøretøjTestBilØ()
        {
            //Arrange
            var bil = new BilØresund("Bicycle", false);
            //Act
            string køretøj = bil.Køretøj();
            //Assert
            Assert.AreEqual("Øresund Bil", køretøj);
        }

        [TestMethod()]
        public void BilØresundPrisTest()
        {
            //Arrange
            var bil = new BilØresund("Bicycle", false);
            //Act
            int pris = bil.Pris();
            //Assert
            Assert.AreEqual(410, pris);
        }

        [TestMethod()]
        public void BilØresundPrisTestBrobizz()
        {
            //Arrange
            var bil = new BilØresund("Bicycle", true);
            //Act
            int pris = bil.Pris();
            //Assert
            Assert.AreEqual(161, pris);
        }
    }
}