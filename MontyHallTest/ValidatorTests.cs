using Microsoft.VisualStudio.TestTools.UnitTesting;
using MontyHallApp;
using System;
using System.Collections.Generic;
using System.Text;

namespace MontyHallApp.Tests
{
    [TestClass()]
    public class ValidatorTests
    {
        Validator validator = new Validator();

        [TestMethod()]
        public void IsValidStrategyTest()
        {
            bool isValid = validator.IsValidStrategy("a");
            Assert.IsTrue(isValid);
        }

        [TestMethod()]
        public void IsInValidStrategyTest()
        {
            bool isValid = validator.IsValidStrategy("x");
            Assert.IsFalse(isValid);
        }

        [TestMethod()]
        public void IsValidSimulationCountTest()
        {
            bool isValid = validator.IsValidSimulationCount("2");
            Assert.IsTrue(isValid);
        }

        [TestMethod()]
        public void IsInValidSimulationCountTest()
        {
            bool isValid = validator.IsValidSimulationCount("x");
            Assert.IsFalse(isValid);
        }
    }
}