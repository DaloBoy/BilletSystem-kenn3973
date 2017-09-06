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
    public class BilTests
    {
        [TestMethod()]
        public void PrisTestBil240()
        {
            //Arrange
            var bil = new Bil("Jeepin", false);
            //Act
            int pris = bil.Pris();
            //Assert
            Assert.AreEqual(240, pris);
        }

        [TestMethod()]
        public void PrisTestBilBrobizz()
        {
            //Arrange
            var bil = new Bil("Jeepin", true);
            //Act
            int pris = bil.Pris();
            //Assert
            Assert.AreEqual(228, pris);
        }

        [TestMethod()]
        public void PrisTestBilWeekendRabatPlusBrobizz()
        {
            //Arrange
            var bil = new Bil("Jeepin", true);
            bil.Dato = new DateTime(2017, 8, 27);
            //Act
            int pris = bil.Pris();
            //Assert
            Assert.AreEqual(182, pris);
        }

        [TestMethod()]
        public void KøretøjTestBil()
        {
            //Arrange
            var bil = new Bil("Jeepin", false);
            //Act
            string køretøj = bil.Køretøj();
            //Assert
            Assert.AreEqual("Bil", køretøj);
        }

        [TestMethod()]
        public void NummerpladeLængdeTestBil()
        {
            //Arrange
            var bil = new Bil("1234567", false);
            //Act
            int nummerplade = bil.NummerpladeLænge();
            //Assert
            Assert.AreEqual(7, nummerplade);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void NummerpladeLængdeTestBil2()
        {
            //Arrange
            var bil = new Bil("87654321", false);
            //Act
            int nummerplade = bil.NummerpladeLænge();

        }
    }
}