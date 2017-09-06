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
    public class MCTests
    {
        [TestMethod()]
        public void PrisTestMC125()
        {
            //Arrange
            var mc = new MC("Bicycle", false);
            //Act
            int pris = mc.Pris();
            //Assert
            Assert.AreEqual(125, pris);
        }

        [TestMethod()]
        public void PrisTestMCBrobizz()
        {
            //Arrange
            var mc = new MC("Bicycle", true);
            //Act
            int pris = mc.Pris();
            //Assert
            Assert.AreEqual(118, pris);
        }

        [TestMethod()]
        public void KøretøjTestMC()
        {
            //Arrange
            var mc = new MC("Bicycle", false);
            //Act
            string køretøj = mc.Køretøj();
            //Assert
            Assert.AreEqual("MC", køretøj);
        }

        [TestMethod()]
        public void NummerpladeLængdeTestMC()
        {
            //Arrange
            var mc = new MC("7654321", false);
            //Act
            int nummerplade = mc.NummerpladeLænge();
            //Assert
            Assert.AreEqual(7, nummerplade);
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void NummerpladeLængdeTestMC2()
        {
            //Arrange
            var mc = new MC("87654321", false);
            //Act
            int nummerplade = mc.NummerpladeLænge();
        }
    }
}