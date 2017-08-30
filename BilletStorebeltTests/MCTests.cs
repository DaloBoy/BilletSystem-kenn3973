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
            var mc = new MC("BeepBeepImABicycle");
            //Act
            int pris = mc.Pris();
            //Assert
            Assert.AreEqual(125, pris);
        }

        [TestMethod()]
        public void KøretøjTestMC()
        {
            //Arrange
            var mc = new MC("BeepBeepImABicycle");
            //Act
            string køretøj = mc.Køretøj();
            //Assert
            Assert.AreEqual("MC", køretøj);
        }
    }
}